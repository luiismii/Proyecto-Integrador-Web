using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Usuarios
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Controladores.UsuariosControladores ProductosControladores = new Controladores.UsuariosControladores();
                    gvwUsuarios.DataSource = ProductosControladores.GetTodoslosUsuariosController();
                    gvwUsuarios.DataBind();
                }
                catch (Exception ex) { }
            }
        }
    }
}