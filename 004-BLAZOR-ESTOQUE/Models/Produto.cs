using System.ComponentModel.DataAnnotations;

namespace _004_BLAZOR_ESTOQUE.Models
{
    public class Produto
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string  Description { get; set; }
        [MaxLength(250)]
        public string ImageUrl { get; set; }

        
        public decimal Price { get; set; }

      
    }
}
