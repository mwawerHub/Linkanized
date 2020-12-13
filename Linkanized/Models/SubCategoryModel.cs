using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linkanized.Models
{
    public class SubCategoryModel
    {
        [Key]
        public int Id { get; set; }

        public int MainCategoryId { get; set; }

        [ForeignKey("MainCategoryId")]
        public MainCategoryModel MainCategory { get; set; }

        [Required]
        [DisplayName("Sub Category")]
        public string Name { get; set; }
    }
}