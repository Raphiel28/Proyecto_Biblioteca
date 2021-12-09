using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Data.AdminUsuarios
{
    public class Usuario
    {
        static public string correo { get; set; }
        static public string contrasena { get; set; }

        static public long id { get; set; }

        static public bool admin { get; set; }
    }
}
