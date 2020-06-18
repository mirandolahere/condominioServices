using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        public IEnumerable<AvatarBE> InformacionPersona(UsuariosBE parametro)
        {
             using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idPersona", parametro.idPersona);
                var coleccion = conexion.Query<AvatarBE>("dbo.Avatar_Informacion_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<AvatarBE> ActualizarInformacion(AvatarActualizar parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@idPersona", parametro.idPersona);
                parametros.Add("@telefono", parametro.telefono);

                var coleccion = conexion.Query<AvatarBE>("dbo.Avatar_ActualizarDatos", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<AvatarSwitch> InformacionSwitch(UsuariosBE parametro)
        {
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))

            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@idPersona", parametro.idPersona);

                var coleccion = conexion.Query<AvatarSwitch>("dbo.Avatar_Switch", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

    }
}
