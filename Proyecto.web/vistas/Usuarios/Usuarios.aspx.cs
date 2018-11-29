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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            //crear un usuario
            try
            {
                Controladores.UsuariosControladores obUsuariosControladores = new Controladores.UsuariosControladores();
                Logica.Modelos.ClsUsuarios obClsUsuarios = new Logica.Modelos.ClsUsuarios
                {
                 
                    stLogin = txtCorreo.Text,
                    stPassword = txtPassword.Text,
                };

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obUsuariosControladores.CreateUsuariosController(obClsUsuarios) + "!', 'success') </script>");


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }


        //eliminar un usuario

        protected void gvwUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Eliminar")
            {
                int codigoUsuario = Convert.ToInt32(((Label)gvwUsuarios.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.UsuariosControladores productosControladores = new Controladores.UsuariosControladores();
                productosControladores.EliminarUsuariosController(new Logica.Modelos.ClsUsuarios
                {
                    inId = codigoUsuario
                });

                gvwUsuarios.DataSource = productosControladores.GetTodoslosUsuariosController();
                gvwUsuarios.DataBind();
            }

            //Editar un usuario


            if (e.CommandName == "Editar")
            {
                int codigoUsuario = Convert.ToInt32(((Label)gvwUsuarios.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.UsuariosControladores productosControladores = new Controladores.UsuariosControladores();
                productosControladores.updateUsuariosController(new Logica.Modelos.ClsUsuarios
                {
                    inId = codigoUsuario
                });

                gvwUsuarios.DataSource = productosControladores.GetTodoslosUsuariosController();
                gvwUsuarios.DataBind();
            }
        }
    }
}