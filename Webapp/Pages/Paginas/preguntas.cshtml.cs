
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace Webapp.Pages.Paginas
{
    public class PreguntasModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string concurso {get; set;} = "Responder Preguntas";
        public string error {get; set;} = "Lo lamentamos y no queremos ofenderlo pero este juego esta hecho para personas mas jovenes";

        [BindProperty]
        public ConcursantesDTO concursante {get; set;}
        [BindProperty(SupportsGet = true)]
        public static IList<ConcursantesDTO> concursantes = new List<ConcursantesDTO> ();

        public void OnGet()
        {
        }

        public ActionResult OnPost(){ 
            concursantes.Add(concursante);
            concursantes[concursantes.Count - 1].turno = concursantes.Count;
            concursantes[concursantes.Count - 1].concurso = concurso;
            return RedirectToPage("/paginas/mostrarConcursantes", concursante);
        }
    }
}