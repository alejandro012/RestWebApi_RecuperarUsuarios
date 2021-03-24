using System;
using System.Collections.Generic;

#nullable disable

namespace WSRecuperarUsuarios.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Eliminado { get; set; }
    }
}
