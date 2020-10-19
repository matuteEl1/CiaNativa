using ArtsentApp.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsentApp.Repositorio
{
    public class Consultas
    {
        private const string connection = "";

        public static List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string query = "select lalalalal";
                SqlCommand _comando = new SqlCommand(query, conn);
                SqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    Producto prod = new Producto();

                    prod.Codigo = _reader.GetString(1);
                    prod.Descripcion = _reader.GetString(1);

                    productos.Add(prod);
                }

                conn.Close();
            }

            return productos;
        }

        public static DataTable GetGrilla()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string query = "select id, desc from <tabla>";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }

            return dt;
        }
    }
}
