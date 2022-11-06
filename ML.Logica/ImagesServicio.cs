using Microsoft.AspNetCore.Http;
using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ML.Logica.Images
{
    public class ImagesServicio : IImagesServicio
    {
        private MLContext _context;

        public ImagesServicio(MLContext context)
        {
            _context = context;
        }

       public string GuardarImagen(IFormFile formFile)
       {
         try 
            {
                string fileName = Path.GetFileName(formFile.FileName);

                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images", fileName);

                GuardarEnBd(uploadpath,fileName);

                var stream = new FileStream(uploadpath, FileMode.Create);

                formFile.CopyTo(stream);

                stream.Close();
                stream.Dispose();

                return  uploadpath;
            }
            catch
            {
                return "Error while uploading the files.";
            }

        }

        public void GuardarEnBd(string path,string nombre)
        {

        Image imagen = new Image();

        imagen.Path = path;
        imagen.Nombre = nombre;

        _context.Add(imagen);
            _context.SaveChanges();
        }

       public List<Image> ObtenerImagenes()
       {
        return _context.Images.OrderByDescending(o => o.IdImages).ToList();
       }



    
    }
}