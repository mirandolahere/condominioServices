using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
    public interface IPersonaRepositorio
    {
        IEnumerable<AvatarBE> InformacionPersona(UsuariosBE parametro);

        IEnumerable<AvatarBE> ActualizarInformacion(AvatarActualizar parametro); 

        IEnumerable<AvatarSwitch> InformacionSwitch(UsuariosBE parametro);

    }
}
