using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsPosiblesClientes
	{
		public int inId_Cliente { get; set; }
        public ClsUsuarios obClsUsuarios { get; set; }
		public string stPrimerNombre { get; set; }
		public string stSegundoNombre { get; set; }
		public string stPrimerApellido { get; set; }
		public string stSegundoApellido { get; set; }
		public string stDireccion { get; set; }
		public string stTelefono { get; set; }
		public string stCorreo { get; set; }
		public string stFecha_Nacimiento { get; set; }


	}
}
