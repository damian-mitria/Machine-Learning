using ML.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Logica
{
    public interface IViajeServicio
    {
        float predecirPrecio(ViajeModel viajeModel);
    }
}
