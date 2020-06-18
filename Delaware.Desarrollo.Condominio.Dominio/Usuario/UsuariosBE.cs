using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio
{
    public class UsuariosBE
    {
        public int? idPersona { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
        public String idUsuario { get; set; }
        public int? intentos { get; set; }
        public int? estado { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public string nombreUsuario { get; set; }
        public DateTime? fechaExpiracionIntento { get; set; }
        public DateTime? fechaInicioBloqueo { get; set; }
    }
}
