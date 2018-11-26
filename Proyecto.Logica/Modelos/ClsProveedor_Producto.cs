using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsProveedor_Producto
	{
		public ClsProductos obClsProductos { get; set; }
		public ClsProveedores obClsProveedores { get; set; }
		public int inCantidad { get; set; }
		public int inValor { get; set; }

	}
}
