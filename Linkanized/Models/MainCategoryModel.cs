using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Linkanized.Models
{
    public class MainCategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Main Category")]
        public string Name { get; set; }
    }
}