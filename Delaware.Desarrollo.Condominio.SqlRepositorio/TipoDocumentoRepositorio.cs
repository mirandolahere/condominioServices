using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class TipoDocumentoRepositorio : ITipoDocumentoRepositorio
    {
        public IEnumerable<TipoDocumentoBE> ListarTipoDocumento()
        {
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))

            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                var coleccion = conexion.Query<TipoDocumentoBE>("dbo.Documentos_Listar", param: parametros, commandType: CommandType.StoredProcedure);


                return coleccion;
            }
        }
    }
}
