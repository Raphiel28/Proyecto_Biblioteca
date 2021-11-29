using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace biblioteca.Models
{
    public partial class Libros
    {
        public Libros()
        {
            Facturas = new HashSet<Facturas>();
        }

        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }
        public string GeneroLibro { get; set; }
        public double Precio { get; set; }
        public int CopiasDisponibles { get; set; }
        public int Ventas { get; set; }
        public string EditorialLibro { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
