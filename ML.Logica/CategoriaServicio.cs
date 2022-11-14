using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using static System.Net.WebRequestMethods;
using System.Text.Encodings.Web;
using System.Net.NetworkInformation;
using System.Xml;

namespace ML.Logica
{
    public class CategoriaServicio : ICategoriaServicio
    {

        private MLContext _context;

        public CategoriaServicio(MLContext context)
        {
            _context = context;
        }

        public dynamic GetDescription(string prediction)
        {
            return _context.Categoria.Where(c=>c.Nombre.Equals(prediction)).FirstOrDefault().Descripcion;
        }

        public dynamic GetInformacion(string prediction)
        {
            String url = String.Format("https://es.wikipedia.org/w/api.php?action=query&list=search&srprop=snippet&format=json&origin=*&utf8=&srsearch={0}", prediction);
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            String respuesta = webClient.DownloadString(url);
            var = 223

            return respuesta;
        }

        public void guardar(Categorium categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }
    }
}
