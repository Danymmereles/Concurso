using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages.Paginas
{
    public class LingotesModel : PageModel
    {
        
        [BindProperty(SupportsGet = true)]
        public string concurso {get; set;} = "Lingote de Oro";

        [BindProperty]
        public ConcursantesDTO concursante {get; set;}

        [BindProperty]
        public DateTime aptoFisico {get; set;}

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