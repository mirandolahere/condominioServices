using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
    public interface IPersonaServicio
    {
        ResultadoBE<IEnumerable<AvatarBE>> InformacionPersona(UsuariosBE parametro);

        ResultadoBE<IEnumerable<AvatarBE>> ActualizarInformacion(AvatarActualizar parametro);

        ResultadoBE<IEnumerable<AvatarSwitch>> InformacionSwitch(UsuariosBE parametro);

    }
}
