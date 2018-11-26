using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsDevoluciones
	{
		public int inId_Devoluciones { get; set; }
		public int inCantidad { get; set; }
		public string stFecha { get; set; }
		public string stCambio { get; set; }
		public ClsFacturas obClsFacturas { get; set; }
		public string stObservacio { get; set; }
		public ClsProductos obClsProductos { get; set; }
	}
}
