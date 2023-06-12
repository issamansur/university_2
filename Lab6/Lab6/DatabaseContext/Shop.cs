using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab6.DatabaseContext;

public partial class Shop: IValidatableObject
{
    public Shop()
    {

    }
    public Shop(string name, string? email, string? address)
    {
        ShopName = name; 
        ShopEmail = email; 
        ShopAddress = address;
    }

    public int ShopId { get; set; }

    public string ShopName { get; set; } = null!;

    public string? ShopEmail { get; set; }

    public string? ShopAddress { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(ShopName))
        {
            yield return new ValidationResult("Shop name must not be empty");
        }

        if (ShopEmail != null && !ShopEmail.ToLower().EndsWith("@mail.ru"))
        {
            yield return new ValidationResult("U can use only МЫЛО");
        }
    }
}
