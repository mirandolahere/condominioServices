using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Negocio
{
    public class PersonaNegocio
    {
        private IPersonaRepositorio _IPersonaRepositorio = new PersonaRepositorio();

        public ResultadoBE<IEnumerable<AvatarBE>> InformacionPersona(UsuariosBE parametro)
        {
            ResultadoBE<IEnumerable<AvatarBE>> resultado = new ResultadoBE<IEnumerable<AvatarBE>>();
            resultado.Data = _IPersonaRepositorio.InformacionPersona(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<AvatarBE>> ActualizarInformacion(AvatarActualizar parametro)
        {
            ResultadoBE<IEnumerable<AvatarBE>> resultado = new ResultadoBE<IEnumerable<AvatarBE>>();
            resultado.Data = _IPersonaRepositorio.ActualizarInformacion(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<AvatarSwitch>> InformacionSwitch(UsuariosBE parametro)
        {
            ResultadoBE<IEnumerable<AvatarSwitch>> resultado = new ResultadoBE<IEnumerable<AvatarSwitch>>();
            resultado.Data = _IPersonaRepositorio.InformacionSwitch(parametro);
            return resultado;
        }

    }
}
