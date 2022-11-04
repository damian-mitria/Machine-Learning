using Microsoft.AspNetCore.Mvc;
using ML.Logica;
using System.Diagnostics;

namespace ML.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Frase()
        {
            return View();
        }



    }
}