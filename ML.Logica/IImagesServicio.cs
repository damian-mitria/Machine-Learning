using Microsoft.AspNetCore.Http;
using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Logica.Images
{
    public interface IImagesServicio
    {

        string guardarImagen(IFormFile formFile);

    }
}