using Microsoft.AspNetCore.Mvc;
using ML.Logica;
using ML.Logica.Images;
using ML_Web;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using static ML_Web.Fotos;


namespace ML.Controllers
{
    public class HomeController : Controller
    {

        public string? frase { get; set; }
        public string? resultado { get; set; }

        public string? porcentaje { get; set; }
        public ICategoriaServicio _CategoriaServicio { get; set; }
        public IImagesServicio _ImagesServicio { get; set; }

        public HomeController(ICategoriaServicio categoriaServicio, IImagesServicio imagesServicio)
        {
            _CategoriaServicio = categoriaServicio;
            _ImagesServicio = imagesServicio;

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

            return View(_ImagesServicio.ObtenerImagenes());
        }

        [HttpPost]
        public IActionResult Foto(IFormFile formFile)
        {

            string path = _ImagesServicio.GuardarImagen(formFile);

            var sampleData = new Fotos.ModelInput();
            sampleData.ImageSource = path;

            var result = Fotos.Predict(sampleData);

            if (result.Prediction == "Lapiceras")
            {
                resultado = "Es una lapicera";
            }
            if (result.Prediction == "Liquid Paper")
            {
                resultado = "Es un liquid paper";
            }
            if (result.Prediction == "Silla")
            {
                resultado = "Es una silla";
            }

            ViewBag.resultadoFoto = resultado;

            ViewBag.ImageURL = formFile.FileName;

            ViewBag.porcentaje = (result.Score.Max() * 100).ToString();

            //ViewBag.resultadoSQL = _CategoriaServicio.GetDescription(result.Prediction);

            ViewBag.resultadoSQL = _CategoriaServicio.GetInformacion(result.Prediction);

            return View(_ImagesServicio.ObtenerImagenes());

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
