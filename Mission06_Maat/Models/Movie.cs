using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Maat.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        // Foreign key for Categories
        public int? CategoryId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        [Required]
        public bool Edited { get; set; } // Assuming 0 is false and 1 is true

        public string LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; } // Assuming 0 is false and 1 is true

        public string Notes { get; set; }

        // Navigation property for the Categories table
        public Category Category { get; set; }
    }
}
