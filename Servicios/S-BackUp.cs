using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_BackUp
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        public void RealizarBackup(string ruta)
        {
            string pathDestino_carpeta = ruta +"\\" + "backup-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
            System.IO.Directory.CreateDirectory(pathDestino_carpeta);
            if (System.IO.Directory.Exists(basePath))
            {
                string[] files = System.IO.Directory.GetFiles(basePath);

                foreach (string s in files)
                {
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(pathDestino_carpeta, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
        }

        public void RestaurarBackup(string ruta)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(basePath);
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
                if (System.IO.Directory.Exists(ruta))
                {
                    string[] filesToCopy = System.IO.Directory.GetFiles(ruta);

                    foreach (string s in filesToCopy)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        string destFile = System.IO.Path.Combine(basePath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region BACKUP Base de datos

        //SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\Servidor;Initial Catalog=SIGAV;Integrated Security=True");

        //public void RealizarBackup(string ruta)
        //{
        //    string database = connection.Database.ToString();
        //    string cmd = "BACKUP DATABASE [" + database +"] TO DISK= '" + ruta + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".bak'";
        //    using (SqlCommand command = new SqlCommand(cmd, connection))
        //    {
        //        if (connection.State != ConnectionState.Open)
        //        {
        //            connection.Open();
        //        }
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void RestaurarBackup(string ruta)
        //{
        //    connection.Open();
        //    string database = connection.Database.ToString();
        //    try
        //    {
        //        string sqlstring =string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        //        SqlCommand cmd = new SqlCommand(sqlstring,connection);
        //        cmd.ExecuteNonQuery();

        //        string sqlstring2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='"+ ruta +"' WITH REPLACE;");
        //        SqlCommand cmd2 = new SqlCommand(sqlstring2, connection);
        //        cmd2.ExecuteNonQuery();

        //        string sqlstring3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
        //        SqlCommand cmd3 = new SqlCommand(sqlstring3, connection);
        //        cmd3.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion
    }
}
