using System;
using System.Collections.Generic;

namespace ML.Data.Entidades
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
