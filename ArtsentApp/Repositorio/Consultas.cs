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


        private const string connectionLocal = @"Server=localhost;Database=Artsent_S_A;Trusted_Connection=True;";
        private const string connectionArtsent = @"Server=SERV-NUEVO\AXSQLEXPRESS;Database=Artsent_S_A;User Id=sa;Password=Axoft1988;";

        public static List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionArtsent))
            {
                conn.Open();

                string query = "SELECT DISTINCT STA11.ID_STA11 AS ID , STA11.Cod_Articu AS [Codigo], Sta11.Descripcio + ' ' + Sta11.DESC_ADIC AS [Descripcion] , " +
                                " STA11.Cod_Articu COLLATE Latin1_General_BIN + ' ' + Sta11.Descripcio + ' ' + Sta11.DESC_ADIC AS[CodigoDescripcion], " +
                                " Sta11.Descripcio + ' ' + Sta11.DESC_ADIC + ' ' + ' - ' + ' ' + STA11.Cod_Articu COLLATE Latin1_General_BIN AS[DescripcionCodigo] " +
                                " FROM STA11 " +
                                " INNER JOIN STA19 ON STA11.COD_ARTICU = STA19.COD_ARTICU " +
                                " INNER JOIN STA22 ON STA19.COD_DEPOSI = STA22.COD_SUCURS";
                SqlCommand _comando = new SqlCommand(query, conn);
                _comando.CommandTimeout = 60;
                SqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Id = _reader.GetInt32(0);
                    prod.Codigo = _reader.GetString(1);
                    prod.Descripcion = _reader.GetString(2);
                    prod.CodigoDescripcion = _reader.GetString(3);
                    prod.DescripcionCodigo = _reader.GetString(4);

                    productos.Add(prod);
                }

                conn.Close();
            }

            return productos;
        }

        public static DataTable GetGrilla(string cod)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionArtsent))
            {
                conn.Open();

                string query = @"SET NOCOUNT ON
                                 Declare @codigo as Varchar(50)
                                    set @codigo = '" + cod +  "' DECLARE @TT_ARTSSENT TABLE(CODIGO VARCHAR(25), DESCRIPCION VARCHAR(60), COD_DEPOSITO INT, DEPOSITO VARCHAR(60), STOCK DECIMAL(10, 2), EMPRESA VARCHAR(15)) " +
                                    " DECLARE @DESC_COD AS VARCHAR(50) " +
                                    " SET @DESC_COD =(SELECT TOP 1 COD_ARTICU FROM STA11 WHERE COD_ARTICU = @codigo OR Descripcio +' ' + DESC_ADIC = @codigo) " +
                                    " INSERT INTO @TT_ARTSSENT " +
                                    " SELECT STA11.Cod_Articu AS[Código], Sta11.Descripcio + ' ' + Sta11.DESC_ADIC AS[Descripción], " +
                                    " STA22.COD_SUCURS AS[Cod.Depósito], STA22.NOMBRE_SUC AS[Depósito], " +
                                    " SUM(CASE WHEN STA11.ID_MEDIDA_CONTROL_STOCK = STA11.ID_MEDIDA_STOCK_2 THEN CANT_STOCK_2 ELSE CANT_STOCK END) AS[Stock], " +
                                    " 'ARTSENT' AS[Empresa] " +
                                    " FROM STA11 " +
                                    " INNER JOIN STA19 ON STA11.COD_ARTICU = STA19.COD_ARTICU " +
                                    " INNER JOIN STA22 ON STA19.COD_DEPOSI = STA22.COD_SUCURS " +
                                    " WHERE STA11.Stock = 1 " +
                                    " GROUP BY STA11.Cod_Articu, Sta11.Descripcio, STA22.COD_SUCURS, STA22.NOMBRE_SUC, STA11.DESC_ADIC " +
                                    "  " +
                                    " DECLARE @TT_COPIA TABLE(CODIGO VARCHAR(25), DESCRIPCION VARCHAR(60), COD_DEPOSITO INT, DEPOSITO VARCHAR(60), STOCK DECIMAL(10,2), EMPRESA VARCHAR(15)) " +
                                    
                                    " INSERT INTO @TT_COPIA " +
                                    " SELECT STA11.Cod_Articu, Sta11.Descripcio + ' ' + Sta11.DESC_ADIC, STA22.COD_SUCURS, STA22.NOMBRE_SUC,  " +
                                    " SUM(CASE WHEN STA11.ID_MEDIDA_CONTROL_STOCK = STA11.ID_MEDIDA_STOCK_2 THEN CANT_STOCK_2 ELSE CANT_STOCK END), " +
                                    " 'COPIA' " +
                                    " FROM[COPIA_SEGURIDAD].[dbo].STA11 " +
                                    " INNER JOIN[COPIA_SEGURIDAD].[dbo].STA19 ON[COPIA_SEGURIDAD].[dbo].STA11.COD_ARTICU = [COPIA_SEGURIDAD].[dbo].STA19.COD_ARTICU " +
                                    " INNER JOIN[COPIA_SEGURIDAD].[dbo].STA22 ON[COPIA_SEGURIDAD].[dbo].STA19.COD_DEPOSI = [COPIA_SEGURIDAD].[dbo].STA22.COD_SUCURS " +
                                    " WHERE[COPIA_SEGURIDAD].[dbo].STA11.Stock = 1 " +
                                    " GROUP BY[COPIA_SEGURIDAD].[dbo].STA11.Cod_Articu, [COPIA_SEGURIDAD].[dbo].Sta11.Descripcio,  " +
                                    " [COPIA_SEGURIDAD].[dbo].STA22.COD_SUCURS, [COPIA_SEGURIDAD].[dbo].STA22.NOMBRE_SUC, [COPIA_SEGURIDAD].[dbo].STA11.DESC_ADIC " +
                                    "  " +
                                    " DECLARE @TT_PRECIO TABLE (CODIGO VARCHAR(25), PRECIO DECIMAL(10,2), FECHA_MODI DATETIME) " +
                                    " INSERT INTO @TT_PRECIO " +
                                    " SELECT TOP 1 COD_ARTICU, PRECIO, MAX(FECHA_MODI) " +
                                    " FROM GVA17 " +
                                    " WHERE COD_ARTICU = @DESC_COD " +
                                    " GROUP BY COD_ARTICU, PRECIO, FECHA_MODI " +
                                    " ORDER BY FECHA_MODI DESC  " +
                                    " SELECT ART.CODIGO, ART.DESCRIPCION, ART.COD_DEPOSITO, ART.DEPOSITO,  " +
                                    " ISNULL((CASE WHEN ART.COD_DEPOSITO = 5 AND COP.COD_DEPOSITO = 5 AND SUM(ART.STOCK) < 0 THEN SUM(ART.STOCK) + SUM(COP.STOCK) " +
                                    " WHEN ART.COD_DEPOSITO = 5 AND COP.COD_DEPOSITO = 5 AND SUM(COP.STOCK) < 0 THEN SUM(COP.STOCK) + SUM(ART.STOCK) " +
                                    " WHEN ART.COD_DEPOSITO = 6 THEN SUM(ART.STOCK) END),'0.00') AS STOCK, PRE.PRECIO " +
                                    " FROM @TT_ARTSSENT ART " +
                                    " LEFT JOIN @TT_COPIA COP ON ART.CODIGO = COP.CODIGO AND ART.COD_DEPOSITO = COP.COD_DEPOSITO " +
                                    " LEFT JOIN @TT_PRECIO PRE ON ART.CODIGO COLLATE Latin1_General_BIN=PRE.CODIGO " +
                                    " WHERE ART.COD_DEPOSITO in (5, 6) " +
                                    " AND " +
                                    " (ART.CODIGO = CASE WHEN @codigo = '' THEN ART.CODIGO ELSE @codigo END " +
                                    " OR " +
                                    " ART.DESCRIPCION = CASE WHEN @codigo = '' THEN ART.DESCRIPCION ELSE @codigo END) " +
                                    " GROUP BY ART.CODIGO, ART.DESCRIPCION, ART.CODIGO, ART.DEPOSITO, ART.COD_DEPOSITO, COP.COD_DEPOSITO,PRE.PRECIO ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }

            return dt;
        }
    }
}
