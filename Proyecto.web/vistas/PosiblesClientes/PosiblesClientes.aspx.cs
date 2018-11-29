using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto.web.vistas.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Controladores.PosiblesClienteControladores obPosiblesClienteControladores = new Controladores.PosiblesClienteControladores();
                    gvwClientes.DataSource = obPosiblesClienteControladores.GetTodoslosPosiblesClientesController();
                    gvwClientes.DataBind();
                }
                catch (Exception ex) { }
            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            //Acturalizar un usuario
            try
            {
                Controladores.PosiblesClienteControladores obPosiblesClienteControladores = new Controladores.PosiblesClienteControladores();
                Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes = new Logica.Modelos.ClsPosiblesClientes
                {
                    stPrimerNombre = txtPrimer_Nombre.Text,
                    stSegundoNombre = txtSegundo_Nombre.Text,
                    stPrimerApellido = txtPrimer_Apellido.Text,
                    stSegundoApellido = txtSegundo_Apellido.Text,
                    stDireccion = txtDireccion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text,
                    stFecha_Nacimiento = txtFecha_Nacimiento.Text

                };

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obPosiblesClienteControladores.updatePosiblesClientesController(obClsPosiblesClientes) + "!', 'success') </script>");
                txtPrimer_Nombre.Text = string.Empty;
                txtSegundo_Nombre.Text = string.Empty;
                txtPrimer_Apellido.Text = string.Empty;
                txtSegundo_Apellido.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                txtFecha_Nacimiento.Text = string.Empty;

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }


        //eliminar un Cliente

        protected void gvwClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {


                int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Eliminar")
            {
                int codigoUsuario = Convert.ToInt32(((Label)gvwClientes.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.UsuariosControladores productosControladores = new Controladores.UsuariosControladores();
                productosControladores.EliminarUsuariosController(new Logica.Modelos.ClsUsuarios
                {
                    inId = codigoUsuario
                });

                gvwClientes.DataSource = productosControladores.GetTodoslosUsuariosController();
                gvwClientes.DataBind();
            }

            //Editar un Cliente

            if (e.CommandName == "Editar")
            {
                int codigoCliente = Convert.ToInt32(((Label)gvwClientes.Rows[indice].FindControl("lblCodigo")).Text);
                txtPrimer_Nombre.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[1].Text) ? string.Empty: gvwClientes.Rows[indice].Cells[1].Text; 
                txtSegundo_Nombre.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[2].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[2].Text;
                txtPrimer_Apellido.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[3].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[3].Text;
                txtSegundo_Apellido.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[4].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[4].Text;
                txtDireccion.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[5].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[5].Text;
                txtTelefono.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[6].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[6].Text;
                txtCorreo.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[7].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[7].Text;
                txtFecha_Nacimiento.Text = string.IsNullOrEmpty(gvwClientes.Rows[indice].Cells[8].Text) ? string.Empty : gvwClientes.Rows[indice].Cells[8].Text;

           }
        }
    }
}    

