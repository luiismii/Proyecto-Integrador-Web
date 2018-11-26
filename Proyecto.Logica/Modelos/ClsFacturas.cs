using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsFacturas
	{
		public int inId_Factura { get; set; }
		public ClsVentas obClsVentas { get; set; }
		public string stFecha { get; set; }
		public string stDireccion { get; set; }
		public string stRazonSocial { get; set; }
		public ClsPosiblesClientes obClsPosiblesClientes { get; set; }
	}
}

