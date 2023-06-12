using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab6.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ShopEmail = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShopAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    OrderCID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Items",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK_Orders_Shops",
                        column: x => x.ShopID,
                        principalTable: "Shops",
                        principalColumn: "ShopID");
                });

            migrationBuilder.CreateTable(
                name: "ShopItem",
                columns: table => new
                {
                    ShopID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ShopItem_Items",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK_ShopItem_Shops",
                        column: x => x.ShopID,
                        principalTable: "Shops",
                        principalColumn: "ShopID");
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    DelAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DelCourier = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DelCost = table.Column<decimal>(type: "money", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Delivery_Delivery",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemID",
                table: "Orders",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShopID",
                table: "Orders",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopItem_ItemID",
                table: "ShopItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopItem_ShopID",
                table: "ShopItem",
                column: "ShopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "ShopItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
