using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Logica
{
    public class CategoriaServicio : ICategoriaServicio
    {

        private MLContext _context;

        public CategoriaServicio(MLContext context)
        {
            _context = context;
        }

        public void guardar(Categorium categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }
    }
}
