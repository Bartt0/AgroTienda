using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agroTienda.Models
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
    }
}