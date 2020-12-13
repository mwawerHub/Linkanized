using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Linkanized.Models
{
    public class ResourceModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MainCategoryId { get; set; }

        [Required]
        [DisplayName("Main Category")]
        public MainCategoryModel MainCategory { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        [Required]
        [DisplayName("Sub Category")]
        public SubCategoryModel SubCategory { get; set; }

        [Required]
        [DisplayName("Friendly Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Resource Url")]
        public string Url { get; set; }

        public string Description { get; set; }
    }
}