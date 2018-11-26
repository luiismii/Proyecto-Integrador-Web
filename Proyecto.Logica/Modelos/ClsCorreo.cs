using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Modelos
{
	public class ClsCorreo
	{
		public string stServidor { get; set; }
		public string stUsuario { get; set; }
		public string stContraceña { get; set; }
		public bool blConexionSegura { get; set; }
		public bool blAutenticacion { get; set; }
		public string stForm { get; set; }
		public string stTo { get; set; }
		public string stAsunto { get; set; }
		public string stMensaje { get; set; }
		public int inTipo { get; set; }
		public int inPioridad { get; set; }
		public string stPuerto { get; set; }
		public string stImagen { get; set; }
		public string stIdImagen { get; set; }


	}
}
