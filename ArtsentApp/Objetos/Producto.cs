using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsentApp.Objetos
{
    public class Producto
    {
        /// <summary>
        /// Id del producto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Codigo del producto
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Descripcion del producto
        /// </summary>
        public string Descripcion { get; set; }
    }
}
