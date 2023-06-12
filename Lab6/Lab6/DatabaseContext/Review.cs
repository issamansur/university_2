using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab6.DatabaseContext
{
    public partial class Review: IValidatableObject
    {
        public Review()
        {

        }

        public Review(int itemId, string name, string description, int rating)
        {
            ItemId = itemId;
            Name = name;
            Description = description;
            Rating = rating;
        }

        public int ReviewId { get; set; }
        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }
        public virtual Item Item { get; set; } = null!;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                yield return new ValidationResult("User's name must not be empty");
            }

            if (Rating < 1 || Rating > 5)
            {
                yield return new ValidationResult("Rating must be between 1 and 5");
            }
        }
    }
}
