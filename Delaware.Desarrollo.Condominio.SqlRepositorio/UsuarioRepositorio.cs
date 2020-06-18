using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio.Usuario;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Persona;
using Delaware.Desarrollo.Condominio.Dominio.Usuario;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public IEnumerable<LoginDato> Login(UsuariosBE parametro)
        {
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))

           using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_correo", parametro.correo);
                parametros.Add("@p_contrasenia", parametro.contrasenia);
                var coleccion = conexion.Query<LoginDato>("dbo.Login_Dato", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }
    }
}
