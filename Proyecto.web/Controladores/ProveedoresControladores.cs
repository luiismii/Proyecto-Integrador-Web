using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
	public class ProveedoresControladores
	{
        public List<Logica.Modelos.ClsProveedores> GetProveedoresController()
        {
            try
            {
                Logica.BL.Proveedores Proveedores = new Logica.BL.Proveedores();
                return Proveedores.GetProveedores();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}