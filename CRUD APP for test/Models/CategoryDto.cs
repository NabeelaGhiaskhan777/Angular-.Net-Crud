using System.ComponentModel.DataAnnotations;

namespace CRUD_APP_for_test.Models
{
    public class CategoryDto
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductDto>? Products { get; set; }
    }
}
