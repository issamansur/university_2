using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab6.DatabaseContext;

public partial class Item: IValidatableObject
{
    public Item()
    {

    }
    public Item(string title, int amount, decimal price, int rating)
    {
        Title = title;
        Amount = amount;
        Price = price;
        Rating = rating;
    }

    public int ItemId { get; set; }

    public string Title { get; set; } = null!;

    public int Amount { get; set; }

    public decimal Price { get; set; }
    public int Rating { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(Title))
        {
            yield return new ValidationResult("Item's title must not be empty");
        }

        if (Amount < 0)
        {
            yield return new ValidationResult("Amount must not be less than zero");
        }

        if (Price <= 0)
        {
            yield return new ValidationResult("Price must not be less than zero or equal to zero");
        }

        if (Rating < 1 || Rating > 5)
        {
            yield return new ValidationResult("Rating must be between 1 and 5");
        }
    }
}
