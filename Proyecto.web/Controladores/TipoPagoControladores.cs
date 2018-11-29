using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
	public class TipoPagoControladores
	{

        public string CreateTipoPagoController(Logica.Modelos.ClsTipoPago obClsTipoPago)
        {
            try
            {
                Logica.BL.ClsPago obClsPago = new Logica.BL.ClsPago();
                return obClsPago.CreateTipoPago(obClsTipoPago);
            }
            catch (Exception ex) { throw ex; }
        }


        public string updateTipoPagoController(Logica.Modelos.ClsTipoPago obClsTipoPago)
        {
            try
            {
                Logica.BL.ClsPago obClsPago = new Logica.BL.ClsPago();
                return obClsPago.updateTipoPago(obClsTipoPago);
            }
            catch (Exception ex) { throw ex; }
        }


        public string EliminarTipoPagoController(Logica.Modelos.ClsTipoPago obClsTipoPago)
        {
            try
            {
                Logica.BL.ClsPago obClsPago = new Logica.BL.ClsPago();
                return obClsPago.deleteTipoPago(obClsTipoPago);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsTipoPago> GetTodoslosTipoPagoController()
        {
            try
            {
                Logica.BL.ClsPago obClsPago = new Logica.BL.ClsPago();
                return obClsPago.GetTodosLosTipoPago();
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsTipoPago> GetBuscarUnTipoPagosController(Logica.Modelos.ClsTipoPago obClsTipoPago) { 
            try
            {
                Logica.BL.ClsPago obClsPago = new Logica.BL.ClsPago();
                return obClsPago.GetBuscarUnTipoPago(obClsTipoPago);
            }catch (Exception ex) { throw ex; }
        }
    }
}