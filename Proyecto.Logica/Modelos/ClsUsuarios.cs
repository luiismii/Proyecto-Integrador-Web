namespace Proyecto.Logica.Modelos
{
   public class ClsUsuarios
    {
        public int inId { get; set; }
		public string stLogin { get; set; }
		public string stPassword { get; set; }
		public ClsPerfiles obClsPerfiles { get; set; }
        public string stImagen { get; set; }

    }
}
