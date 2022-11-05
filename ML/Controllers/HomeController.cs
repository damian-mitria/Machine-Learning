using Microsoft.AspNetCore.Mvc;
using ML.Logica;
using ML_Web;
using System.Diagnostics;

namespace ML.Controllers
{
    public class HomeController : Controller
    {

        public string? frase { get; set; }
        public string? resultado { get; set; }
        public ICategoriaServicio _CategoriaServicio { get; set; }

        public HomeController(ICategoriaServicio categoriaServicio)
        {
            _CategoriaServicio = categoriaServicio;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Foto()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Frase()
        {
            ViewBag.dato = "";
            return View();
        }

        public IActionResult Informacion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Frase(String frase)
        {
            var sampleData = new Frases.ModelInput();
            sampleData.Col0 = frase;

            var prediccion = Frases.Predict(sampleData);

            if ((int)prediccion.Prediction == 0)
            {
                resultado = "Negativo"; 
            }
            else 
            {
                resultado = "Positivo";
            }

            ViewBag.dato = resultado;
           
            return View();
        }



    }
}