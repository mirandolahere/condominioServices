using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio.Usuario
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<LoginDato> Login(UsuariosBE parametro);
    }
}
