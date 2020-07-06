
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages.Paginas
{
    public class MostrarConcursantesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public ConcursantesDTO persona {get; set;}

        public void OnGet(){
            
        }
    }
}