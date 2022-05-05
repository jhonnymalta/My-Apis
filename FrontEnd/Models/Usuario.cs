using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome é Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email é Obrigatório")]
        [EmailAddress(ErrorMessage ="Informe um e-mail Valido")]
        public string Email { get; set; }
        [Range(18,65,ErrorMessage ="Idade válida somente entro 18 e 65 anos.")]
        public int  Idade { get; set; }
    }
}
