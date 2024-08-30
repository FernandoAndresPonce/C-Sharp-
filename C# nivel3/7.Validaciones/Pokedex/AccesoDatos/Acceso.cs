using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Acceso
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public Acceso()
        {
            this.conexion = new SqlConnection("server= .\\SQLEXPRESS; database= POKEDEX_DB; integrated security= true");
            this.comando = new SqlCommand();
        }

        public SqlDataReader Lector { get { return lector; } }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        // 2. [Listar con Stored ProcedurePágina]
        public void setearProcedimientoAlmacenado(string storedProcedures)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = storedProcedures;

        }
        public void setearParametros(string dato, object pokemon)
        {
            comando.Parameters.AddWithValue(dato, pokemon);
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejectuarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //<% -- [3.Registro Trainee - output SQL - MailTrap]-- %>
        public int ejectuarAccionScalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (lector != null)
                    lector.Close();

                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
