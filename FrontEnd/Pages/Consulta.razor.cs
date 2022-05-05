using Microsoft.AspNetCore.Components;

namespace FrontEnd.Pages
{
    public class ConsultaBase : ComponentBase
    {

        protected string numAde;
        [Parameter]
        public int incremento { get; set; }
        protected int count = 0;

        [Parameter]
        public string texto { get; set; }

        protected void contador()
        {
            count += incremento;
        }
    }
}

