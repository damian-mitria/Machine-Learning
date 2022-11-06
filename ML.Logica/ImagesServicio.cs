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

       public string guardarImagen(IFormFile formFile)
       {
         try 
            {
                string fileName = Path.GetFileName(formFile.FileName);

                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images", fileName);

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

    
    }
}