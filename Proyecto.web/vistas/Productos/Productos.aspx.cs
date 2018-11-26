using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Productos
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Controladores.ProductosControladores ProductosControladores = new Controladores.ProductosControladores();
                    gvwProductos.DataSource = ProductosControladores.GetTodoslosProductosController();
                    gvwProductos.DataBind();
                }
                catch (Exception ex) { }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Controladores.ProductosControladores obProductosControladores = new Controladores.ProductosControladores();
                Logica.Modelos.ClsProductos obClsProductos = new Logica.Modelos.ClsProductos
                {
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

        protected void gvwProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Eliminar")
            {
                int codigoProducto = Convert.ToInt32(((Label)gvwProductos.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.ProductosControladores productosControladores = new Controladores.ProductosControladores();
                productosControladores.EliminarProductosController(new Logica.Modelos.ClsProductos
                {
                    inId_Producto = codigoProducto
                });

                gvwProductos.DataSource = productosControladores.GetTodoslosProductosController();
                gvwProductos.DataBind();
            }
        }
    }
}

