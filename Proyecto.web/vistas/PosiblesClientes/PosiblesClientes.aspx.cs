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

		  //crear un usuario
           try
            {
                Controladores.PosiblesClienteControladores obPosiblesClienteControladores = new Controladores.PosiblesClienteControladores();
        Logica.Modelos.ClsPosiblesClientes obClsProductos = new Logica.Modelos.ClsPosiblesClientes
        {
            inId_Cliente = txtNombre_Productos.Text,
            obClsUsuarios = new Logica.Modelos.ClsUsuarios {inId = txtNombre_Productos.Text,
            inId_Cliente = txtNombre_Productos.Text,
            inId_Cliente = txtNombre_Productos.Text,
            inId_Cliente = txtNombre_Productos.Text,
            stNombre_Producto = txtNombre_Productos.Text,
            inPrecio = Convert.ToInt32(txtPrecio.Text),
            stDescripcion = txtDescripcion.Text

        };

        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obProductosControladores.CreateProductosController(obClsProductos) + "!', 'success') </script>");


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
