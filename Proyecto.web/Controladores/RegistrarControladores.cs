using System;
using System.Collections.Generic;

namespace Proyecto.web.Controladores
{
    public class RegistrarControladores
    {

        public string CreateClienteController(Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                Logica.BL.ClsClientes obClsClientes = new Logica.BL.ClsClientes();
                return obClsClientes.CreateCliente(obClsPosiblesClientes);
            }
            catch (Exception ex) { throw ex; }
        }

        public string EliminarClienteController(Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                Logica.BL.ClsClientes obClsClientes = new Logica.BL.ClsClientes();
                return obClsClientes.deleteClientes(obClsPosiblesClientes);
            }
            catch (Exception ex) { throw ex; }
        }
        public string UpdateClienteController(Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                Logica.BL.ClsClientes obClsClientes = new Logica.BL.ClsClientes();
                return obClsClientes.updateClientes(obClsPosiblesClientes);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsPosiblesClientes> GetPosiblesClientesController()
        {
            try
            {
                Logica.BL.ClsClientes obClsClientes = new Logica.BL.ClsClientes();
                return obClsClientes.getTodoslosClientes();
            }
            catch (Exception ex) { throw ex; }
        }

    }
}