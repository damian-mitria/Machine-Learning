using System;
using System.Collections.Generic;

namespace ML.Data.Entidades
{
    public partial class Image
    {
        public int IdImages { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Path { get; set; }
    }
}
