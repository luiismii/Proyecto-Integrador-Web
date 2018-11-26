using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsInventarios
	{
		public int inId_Inventario { get; set; }
		public ClsProductos obClsProductos { get; set; }
		public string stFecha { get; set; }
		public ClsProveedores obClsProveedores { get; set; }
		public int inCantidad { get; set; }

	}
}
