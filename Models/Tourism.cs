using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Tourism
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationName { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Range(0, 10000)]
        public decimal PricePerDay { get; set; }

        public bool IsAvailable { get; set; }

        public string? ImageUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }
    }
}