using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_BackUp
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\Servidor;Initial Catalog=SIGAV;Integrated Security=True");
        
        public void RealizarBackup(string ruta)
        {
            string database = connection.Database.ToString();
            string cmd = "BACKUP DATABASE [" + database +"] TO DISK= '" + ruta + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".bak'";
            using (SqlCommand command = new SqlCommand(cmd, connection))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
            }
        }

        public void RestaurarBackup(string ruta)
        {
            connection.Open();
            string database = connection.Database.ToString();
            try
            {
                string sqlstring =string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd = new SqlCommand(sqlstring,connection);
                cmd.ExecuteNonQuery();

                string sqlstring2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='"+ ruta +"' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sqlstring2, connection);
                cmd2.ExecuteNonQuery();

                string sqlstring3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sqlstring3, connection);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
