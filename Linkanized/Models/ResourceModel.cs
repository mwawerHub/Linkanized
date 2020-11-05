using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Linkanized.Models
{
    public class ResourceModel
    {
        [Key]
        public int Id { get; set; }

        public int MainCategoryId { get; set; }
        public int SubCategoryId { get; set; }

        [Required]
        [DisplayName("Friendly Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Resource Url")]
        public string Url { get; set; }
    }
}