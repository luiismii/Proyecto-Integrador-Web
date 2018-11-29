using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
    public class LoginControladores
    {
        public List<Logica.Modelos.ClsUsuarios> GetBuscarUnUsuarioController(Logica.Modelos.ClsUsuarios obClsClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.getBuscarUnUsuario(obClsClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }


        public bool GetValidarUsuarioController(Logica.Modelos.ClsUsuarios obClsClsUsuarios)
        {
            try
            {
                Logica.BL.ClsUsuarios obUsuarios = new Logica.BL.ClsUsuarios();
                return obUsuarios.GetValidarUsuario(obClsClsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }
    }
    }