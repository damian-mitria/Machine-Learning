using Microsoft.AspNetCore.Mvc;
using ML.Logica;
using ML_Web;
using System.Diagnostics;
using System.Drawing;
using static ML_Web.Fotos;


namespace ML.Controllers
{
    public class HomeController : Controller
    {

        public string? frase { get; set; }
        public string? resultado { get; set; }

        public string? porcentaje { get; set; }
        public ICategoriaServicio _CategoriaServicio { get; set; }

        public HomeController(ICategoriaServicio categoriaServicio)
        {
            _CategoriaServicio = categoriaServicio;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Foto()
        {
            ViewBag.resultadoFoto = "";
            ViewBag.resultadoSQL = "";
            return View();
        }

        [HttpPost]
        public IActionResult Foto(ModelInput imagen)
        {
            
            var sampleData = new Fotos.ModelInput();
            sampleData.ImageSource = @"C:\Users\damia\OneDrive\Escritorio\silla-delfina-unican-1.jpg";

            var result = Fotos.Predict(sampleData);

            if (result.Prediction == "Lapiceras")
            {
                resultado = "Lapi";
            }
            if (result.Prediction == "Liquid Paper")
            {
                resultado = "Liqui";
            }
            if (result.Prediction == "Silla")
            {
                resultado = "Silla MOSTRELLI!!!";
            }


            ViewBag.resultadoFoto = resultado;

            ViewBag.resultadoSQL = sampleData.ImageSource.ToString();
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