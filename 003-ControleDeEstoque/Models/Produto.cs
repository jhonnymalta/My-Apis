using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _003_ControleDeEstoque.Models
{
    public class Produto
    {
        [Key]        
        public int Id { get; set; }

        [Required]
        [StringLength(30,MinimumLength = 3,ErrorMessage ="O Nome do produto deve ter no mínimo 3 character.")]
        public string Name { get; set; }

        [MaxLength(200,ErrorMessage ="A descrição deve ter no máximo 200 characteres.")]
        public string shortDescription { get; set; }
        [Required]
        [Precision(18,2)]
        public decimal Price { get; set; }


        [Range(0,2000)]
        public int Quantity { get; set; }
    }
}
