using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class Categoria
    {

        public int CategoryId { get; set; }

        [Required(ErrorMessage ="O nome da categoria é obrigatório.")]
        [MaxLength(50,ErrorMessage ="Character maximo deve ser 50.")]
        public string Name { get; set; }

        [MaxLength(200,ErrorMessage ="Máximo de caracter permitido é de 200")]
        public string ShortDescription { get; set; }

        
    }
}
