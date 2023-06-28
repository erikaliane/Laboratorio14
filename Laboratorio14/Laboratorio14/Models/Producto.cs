using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14.Models
{
    public class Producto
    {
        public int ProductoId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal  Precio { get; set; }

        public string  FechadeVencimiento { get; set; }

    }
}
