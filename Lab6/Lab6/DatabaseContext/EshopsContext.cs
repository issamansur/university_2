using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lab6.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Lab6.DatabaseContext;

public partial class EshopsContext : DbContext, IItemRep, IShopRep
{
    public EshopsContext()
    {
    }

    public EshopsContext(DbContextOptions<EshopsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<ShopItem> ShopItems { get; set; }

    //-

    public void AddShop(string name, string email, string address)
    {
        Shop shop = new(name, email, address);
        Shops.Add(shop);
    }

    public void AddShop(Shop shop) => Shops.Add(shop);

    public bool DeleteShop(int id)
    {
        Shop? f;
        if ((f = Shops.Find(id)) != null)
        {
            Shops.Remove(f);
            return true;
        }
        return false;
    }

    public bool UpdateShopEmail(int id, string newEmail)
    {
        Shop? f;
        if ((f = Shops.Find(id)) != null)
        {
            f.ShopEmail = newEmail;
            return true;
        }
        return false;
    }

    public bool UpdateShopAddress(int id, string newAddress)
    {
        Shop? f;
        if ((f = Shops.Find(id)) != null)
        {
            f.ShopAddress = newAddress;
            return true;
        }
        return false;
    }

    public void AddItem(string title, int amount, decimal price) => Items.Add(new Item(title, amount, price));
    public void AddItem(Item item) => Items.Add(item);
    public bool DeleteItem(int id)
    {
        Item? i;
        if ((i = Items.Find(id)) != null)
        {
            Items.Remove(i);
            return true;
        }
        return false;
    }
    public bool UpdateItemAmount(int id, int addAmount)
    {
        Item? i;
        if ((i = Items.Find(id)) != null)
        {
            i.Amount += addAmount;
            return true;
        }
        return false;
    }
    public bool UpdateItemPrice(int id, decimal newPrice)
    {
        Item? i;
        if ((i = Items.Find(id)) != null)
        {
            i.Price = newPrice;
            return true;
        }
        return false;
    }
    //-

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.\\;Initial Catalog=EShops;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("Delivery");

            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderID");
            entity.Property(e => e.DelAddress).HasMaxLength(50);
            entity.Property(e => e.DelCost).HasColumnType("money");
            entity.Property(e => e.DelCourier).HasMaxLength(15);
            entity.Property(e => e.DelDate).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delivery_Delivery");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Title).HasMaxLength(30);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.OrderCid).HasColumnName("OrderCID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("ShopID");

            entity.HasOne(d => d.Item).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Items");

            entity.HasOne(d => d.Shop).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Shops");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.Property(e => e.ShopId).HasColumnName("ShopID");
            entity.Property(e => e.ShopAddress).HasMaxLength(50);
            entity.Property(e => e.ShopEmail).HasMaxLength(20);
            entity.Property(e => e.ShopName).HasMaxLength(15);
        });

        modelBuilder.Entity<ShopItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShopItem");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ShopId).HasColumnName("ShopID");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShopItem_Items");

            entity.HasOne(d => d.Shop).WithMany()
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShopItem_Shops");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    public override int SaveChanges()
    {
        var error = new List<ValidationResult>();

        foreach (var entry in this.ChangeTracker.Entries())
        {
            if (entry.Entity is IValidatableObject && entry.State == EntityState.Added || entry.State == EntityState.Modified)
            {
                var localErr = new List<ValidationResult>();
                if (!Validator.TryValidateObject(entry.Entity, new ValidationContext(entry.Entity), localErr))
                {
                    error.AddRange(localErr);
                }
            }
        }

        if (error.Any())
        {
            throw new ApplicationException("there are errors in entities");
        }

        return base.SaveChanges();
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
