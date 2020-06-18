using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
    public interface ITipoDocumentoRepositorio
    {
        IEnumerable<TipoDocumentoBE> ListarTipoDocumento();

    }
}
