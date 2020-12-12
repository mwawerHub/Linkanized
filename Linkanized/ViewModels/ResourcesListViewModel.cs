using Linkanized.Models;

namespace Linkanized.ViewModels
{
    public class ResourcesListViewModel
    {
        public int MainCategoryId { get; set; }
        public MainCategoryModel MainCategory { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategoryModel SubCategory { get; set; }
        public ResourceModel Resource { get; set; }
    }
}