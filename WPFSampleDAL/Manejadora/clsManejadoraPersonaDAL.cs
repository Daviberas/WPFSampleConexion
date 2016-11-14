using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSampleEntities;
using WPFSample_DAL;

namespace WPFSampleDAL.Manejadora
{
    public class clsManejadoraPersonaDAL
    {
        private clsMyConnection miConexion;

        public clsManejadoraPersonaDAL()
        {
            miConexion = new clsMyConnection();
        }

        public int insertarPersonaDAL(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            //Añadimos los datos al comando
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;

            try
            {
                conexion = miConexion.getConnection();

                miComando.CommandText = "insert into PERSONAS(nombre,apellidos,fechaNac,telefono,direccion) VALUES (@nombre,@apellidos,@fechaNac,@telefono,@direccion)";
                miComando.Connection = conexion;
                resultado = miComando.ExecuteNonQuery();
                
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }
        }

        public int actualizarPersonaDAL(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            //Añadimos los datos al comando
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = persona.Id;
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;

            try
            {
                conexion = miConexion.getConnection();

                miComando.CommandText = "update PERSONAS set nombre = @nombre, apellidos = @apellidos, fechaNac = @fechaNac, telefono = @telefono, direccion = @direccion where IDPersona = @id";
                miComando.Connection = conexion;
                resultado = miComando.ExecuteNonQuery();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }
        }
    }
}
