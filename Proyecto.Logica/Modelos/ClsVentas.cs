using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsVentas
	{
		public int inId_Venta { get; set; }
		public ClsProductos obClsProductos { get; set; }
		public ClsProveedores obClsProveedores { get; set; }
		public ClsPromociones obClsPromociones { get; set; }
		public int inCantidad { get; set; }
		public double doIva { get; set; }
		public int inTotal { get; set; }
		public string stFecha { get; set; }
		public ClsTipoPago obClsTipoPago { get; set; }

	}
}
