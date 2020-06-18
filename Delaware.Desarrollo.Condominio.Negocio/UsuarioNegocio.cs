using Delaware.Desarrollo.Condominio.ContractoRepositorio.Usuario;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Negocio.Usuario
{
    public class UsuarioNegocio
    {
        IUsuarioRepositorio _UsuarioRepositorio = new UsuarioRepositorio();

       public  ResultadoBE<IEnumerable<LoginDato>> Login(UsuariosBE parametro)
        {
	    // Comentario de prueba para Merge del SVN
            ResultadoBE<IEnumerable<LoginDato>> resultado = new ResultadoBE<IEnumerable<LoginDato>>();
            resultado.Data = _UsuarioRepositorio.Login(parametro);
            return resultado;

        }
    }
}
