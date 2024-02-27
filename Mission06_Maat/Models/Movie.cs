using Mission06_Maat.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Mission06_Maat.Models
{
    public class Movie
    {
        //required fields: title, year, edited, copiedtoplex
        [Key]
        [Required]
        public int MovieId { get; set; }

        //set foreign key relationship
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        [Required]
        public Category? Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        //prevent unrealistic years
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be 1888 or later")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}