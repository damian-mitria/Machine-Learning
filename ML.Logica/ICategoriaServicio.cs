using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Logica
{
    public interface ICategoriaServicio
    {
        dynamic GetDescription(string prediction);
        void guardar(Categorium categoria);

        dynamic GetInformacion(string prediction);
  
    }
}
