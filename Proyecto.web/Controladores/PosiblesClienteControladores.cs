using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;   
namespace Proyecto.web.Controladores
{
    public class PosiblesClienteControladores
    {

        public string CreatePosiblesClientesController(Logica.Modelos.ClsUsuarios Usuarios, Logica.Modelos.ClsPosiblesClientes Clientes)
        {
            try
            {
                Logica.BL.ClsClientes obClientes = new Logica.BL.ClsClientes();
                return obClientes.CreateCliente(Usuarios, Clientes);
            }
            catch (Exception ex) { throw ex; }
        }


        public string updatePosiblesClientesController(Logica.Modelos.ClsPosiblesClientes Clientes)
        {
            try
            {
                Logica.BL.ClsClientes obProductos = new Logica.BL.ClsClientes();
                return obProductos.updateClientes(Clientes);
            }
            catch (Exception ex) { throw ex; }
        }


        public string EliminarPosiblesClientesController(Logica.Modelos.ClsPosiblesClientes Clientes)
        {
            try
            {
                Logica.BL.ClsClientes obClientes = new Logica.BL.ClsClientes();
                return obClientes.deleteClientes(Clientes);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsPosiblesClientes> GetTodoslosPosiblesClientesController()
        {
            try
            {
                Logica.BL.ClsClientes obClientes = new Logica.BL.ClsClientes();
                return obClientes.getTodoslosClientes();
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsPosiblesClientes> GetBuscarUnPosiblesClientesController(Logica.Modelos.ClsPosiblesClientes Clientes)
        {
            try
            {
                Logica.BL.ClsClientes obClientes = new Logica.BL.ClsClientes();
                return obClientes.getBuscarUnClientes(Clientes);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
