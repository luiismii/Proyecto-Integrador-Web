using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;   
namespace Proyecto.web.Controladores
{
    public class PosiblesClienteControladores
    {

        public DataSet getConsultarPosiblesClientesControladores()
        {
            try
            {
                Logica.BL.ClsPosiblesClientes obClsPosiblesClientes = new Logica.BL.ClsPosiblesClientes();
                return obClsPosiblesClientes.getConsultarPosiblesClientes() ;
            }
            catch (Exception ex) { throw ex; }
           
        }
      
    }
}
