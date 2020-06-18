using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Microsoft.AspNetCore.Mvc;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonaController : Controller , IPersonaServicio
    {
        IPersonaServicio _IPersonaServicio;
        public PersonaController(IPersonaServicio _IPersonaServicio)
        {
            this._IPersonaServicio = _IPersonaServicio;
        }

        [HttpPost]
        public ResultadoBE<IEnumerable<AvatarBE>> InformacionPersona(UsuariosBE parametro)
        {
            return _IPersonaServicio.InformacionPersona(parametro);
        }

        public ResultadoBE<IEnumerable<AvatarBE>> ActualizarInformacion(AvatarActualizar parametro)
        {
            return _IPersonaServicio.ActualizarInformacion(parametro);

        }

        public ResultadoBE<IEnumerable<AvatarSwitch>> InformacionSwitch(UsuariosBE parametro)
        {
            return _IPersonaServicio.InformacionSwitch(parametro);

        }

    }
}