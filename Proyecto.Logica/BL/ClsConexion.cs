using System.Configuration;    
namespace Proyecto.Logica.BL
{
    public class ClsConexion
    {
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
