using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
	public class DevolucionesControladores
	{

        public string CreateDevolucionesController(Logica.Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                Logica.BL.Devoluciones obDevoluciones = new Logica.BL.Devoluciones();
                return obDevoluciones.CreateDevoluciones(obClsDevoluciones);
            }
            catch (Exception ex) { throw ex; }
        }

        public string EliminarDevolucionesController(Logica.Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                Logica.BL.Devoluciones obDevoluciones = new Logica.BL.Devoluciones();
                return obDevoluciones.deleteDevoluciones(obClsDevoluciones);
            }
            catch (Exception ex) { throw ex; }
        }
        public string UpdateDevolucionesController(Logica.Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                Logica.BL.Devoluciones obDevoluciones = new Logica.BL.Devoluciones();
                return obDevoluciones.updateDevoluciones(obClsDevoluciones);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsDevoluciones> GetTodaslasDevolucionesController()
        {
            try
            {
                Logica.BL.Devoluciones Devoluciones = new Logica.BL.Devoluciones();
                return Devoluciones.GetTodaslasDevoluciones();
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsDevoluciones> GetBuscarUnaDevolucionController(Logica.Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                Logica.BL.Devoluciones obDevoluciones = new Logica.BL.Devoluciones();
                return obDevoluciones.GetBuscarUnaDevolucion(obClsDevoluciones);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}