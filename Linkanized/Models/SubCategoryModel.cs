using System.ComponentModel.DataAnnotations;

namespace Linkanized.Models
{
    public class SubCategoryModel
    {
        [Key]
        public int Id { get; set; }

        public int MainCategoryId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}