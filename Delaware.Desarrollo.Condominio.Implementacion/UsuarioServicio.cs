using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using Delaware.Desarrollo.Condominio.Negocio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class UsuarioServicio : IUsuarioServicio
    {

        private UsuarioNegocio _ProyectoNegocio = new UsuarioNegocio();

        public ResultadoBE<IEnumerable<LoginDato>> Login(UsuariosBE parametro)
        {
            return _ProyectoNegocio.Login(parametro);
        }
    }
}
