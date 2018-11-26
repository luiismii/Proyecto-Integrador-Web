using System;

using System.Data;

namespace Proyecto.web.Controladores
{
	public class RecuperarContraceñaControladores
	{
        public DataSet getRecuperarContraceñaControladores(Logica.Modelos.ClsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.ClsRecuperarPassword obClsRecuperarPassword = new Logica.BL.ClsRecuperarPassword();
                return obClsRecuperarPassword.getConsultaPassword(obclsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }

        public void setEmailControladores(Logica.Modelos.ClsCorreo obClsCorreo)
        {
            try
            {
                Logica.BL.ClsGeneral obClsGeneral = new Logica.BL.ClsGeneral();
                obClsGeneral.setEmail(obClsCorreo);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}