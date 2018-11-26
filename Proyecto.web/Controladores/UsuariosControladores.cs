using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
	public class UsuariosControladores
    {


        public string CreateUsuariosController(Logica.Modelos.ClsUsuarios obClsClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.CreateUsuarios(obClsClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }


        public string updateUsuariosController(Logica.Modelos.ClsUsuarios obClsClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.updateUsuarios(obClsClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }


        public string EliminarUsuariosController(Logica.Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.deleteUsuarios(obClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsUsuarios> GetTodoslosUsuariosController()
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.getTodoslosUsuarios();
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsUsuarios> GetBuscarUnUsuarioController(Logica.Modelos.ClsUsuarios obClsClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.getBuscarUnUsuario(obClsClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }
        
    }
}