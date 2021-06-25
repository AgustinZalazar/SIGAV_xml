using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_Acceso
{
    public class DAL
    {

        private string CadenaC = @"Data Source=DESKTOP-21VAQP0\SQLEXPRESS;Initial Catalog=SIGAV;Integrated Security=True";

        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-21VAQP0\SQLEXPRESS;Initial Catalog=SIGAV;Integrated Security=True");
        private SqlTransaction Trans;
        private SqlCommand cmd;


        public DataSet Leer(string consulta, Hashtable hdatos)
        {
            
            DataSet ds = new DataSet();
            cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.StoredProcedure;
            if (hdatos != null)
            {
                foreach (string NombreParametro in hdatos.Keys)
                {
                    cmd.Parameters.AddWithValue(NombreParametro, hdatos[NombreParametro]);
                }
            }

            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(ds);
            return ds;
        }

        private SqlCommand CrearComando(string nombre, List<SqlParameter> pars)
        {

            SqlCommand cmd = new SqlCommand(nombre, connection);
            if (Trans != null)
            {

                cmd.Transaction = Trans;
            }

            if (pars != null && pars.Count > 0)
            {

                cmd.Parameters.AddRange(pars.ToArray());
            }

            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
        public bool OpenCnn()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = CadenaC;
                connection.Open();              
            }
            return true;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {

            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.String;
            return parametro;
        }

        public bool Escribir(string consulta, Hashtable hdatos)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = CadenaC;
                connection.Open();
            }

            try
            {
                Trans = connection.BeginTransaction();
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = consulta;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = Trans;


                if (hdatos != null)
                {
                    foreach (string NombreParametro in hdatos.Keys)
                    {
                        cmd.Parameters.AddWithValue(NombreParametro, hdatos[NombreParametro]);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                Trans.Commit();
                return true;

            }
            catch (Exception)
            {
                Trans.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable LeerTabla(string consulta, Hashtable hdatos)
        {

            DataTable Dt = new DataTable();
            cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.StoredProcedure;


            if ((hdatos != null))
            {
                foreach (string dato in hdatos.Keys)
                {
                    cmd.Parameters.AddWithValue(dato, hdatos.Values);
                }
            }

            SqlDataAdapter Adaptador = new SqlDataAdapter(cmd);
            Adaptador.Fill(Dt);
            return Dt;


        }

        public DataSet Leer2(string Consulta_SQL)
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(Consulta_SQL, connection);
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            { 
                throw ex; 
            }
            catch (Exception ex)
            { 
                throw ex; 
            }
            finally
            { 
                connection.Close();
            }
            return Ds;
        }
    }
}
