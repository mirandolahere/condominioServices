using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
    public interface IUsuarioServicio
    {

        ResultadoBE<IEnumerable<LoginDato>> Login(UsuariosBE parametro  );
    }
}
