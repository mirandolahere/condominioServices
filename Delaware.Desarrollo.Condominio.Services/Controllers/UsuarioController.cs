using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using Delaware.Desarrollo.Condominio.Implementacion;
using Microsoft.AspNetCore.Mvc;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase , IUsuarioServicio
    {

        IUsuarioServicio _IUsuarioServicio;

        public UsuarioController(IUsuarioServicio _IUsuarioServicio)
        {  
            this._IUsuarioServicio = _IUsuarioServicio;

        }

        [HttpPost]
        public string mensaje()
        {
            return "assaas";
        }
        [HttpPost]
        public ResultadoBE<IEnumerable<LoginDato>> Login(UsuariosBE parametro)
        {
            return _IUsuarioServicio.Login(parametro);
        }
    }
}