using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class PersonaServicio : IPersonaServicio
    {
        private PersonaNegocio _PersonaNegocio = new PersonaNegocio();
        public ResultadoBE<IEnumerable<AvatarBE>> InformacionPersona(UsuariosBE parametro)
        {
            return _PersonaNegocio.InformacionPersona(parametro);
        }

        public ResultadoBE<IEnumerable<AvatarBE>> ActualizarInformacion(AvatarActualizar parametro)
        {
            return _PersonaNegocio.ActualizarInformacion(parametro);

        }
        public ResultadoBE<IEnumerable<AvatarSwitch>> InformacionSwitch(UsuariosBE parametro)
        {
            return _PersonaNegocio.InformacionSwitch(parametro);

        }

    }
}
