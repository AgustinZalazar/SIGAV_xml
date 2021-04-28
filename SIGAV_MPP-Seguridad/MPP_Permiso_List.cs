using Servicios.Composite;
using SIGAV_Acceso;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP_Seguridad
{
    public class MPP_Permiso_List
    {
        DAL Dal_ = new DAL();

        public IList<Permiso> GetAll(string familia)
        {
            var where = "is NULL";

            if (!String.IsNullOrEmpty(familia))
            {
                where = "=" + familia;
            }

            Dal_.OpenCnn();
            
            var cmd = new SqlCommand();
            cmd.Connection = Dal_.connection;

            var sql = $@"with recursivo as (
                        select sp2.id_permiso_padre, sp2.id_permiso_hijo  from Permisos_Permisos SP2
                        where sp2.id_permiso_padre {where}
                        UNION ALL 
                        select sp.id_permiso_padre, sp.id_permiso_hijo from Permisos_Permisos sp 
                        inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
                        )
                        select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.es_patente
                        from recursivo r 
                        inner join permiso p on r.id_permiso_hijo = p.id 
						
                        ";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<Permiso>();

            while (reader.Read())
            {
                int id_padre = 0;
                if (reader["id_permiso_padre"] != DBNull.Value)
                {
                    id_padre = reader.GetInt32(reader.GetOrdinal("id_permiso_padre"));
                }

                var id = reader.GetInt32(reader.GetOrdinal("id"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));
                var patente = reader.GetBoolean(reader.GetOrdinal("es_patente"));


                Permiso c;

                if (!patente)
                    c = new Familia();
                else
                    c = new Patente();

                c.ID = id;
                c.Nombre = nombre;

                var padre = GetComponent(id_padre, lista);

                if (padre == null)
                {
                    lista.Add(c);
                }
                else
                {
                    padre.agregarHijo(c);
                }

            }
            reader.Close();
            Dal_.connection.Close();


            return lista;
        }


        public bool IsInRole(int id)
        {
            var lista = GetAll(string.Empty);

            var c = GetComponent(id, lista);

            return c != null;
        }


        private Permiso GetComponent(int id, IList<Permiso> lista)
        {

            Permiso component = lista != null ? lista.Where(i => i.ID.Equals(id)).FirstOrDefault() : null;

            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = GetComponent(id, c.ObtenerHijo);
                    if (l != null && l.ID == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.ObtenerHijo);

                }
            }
            return component;
        }
    }
}
