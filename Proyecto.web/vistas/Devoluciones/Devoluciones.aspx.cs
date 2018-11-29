using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Devoluciones
{
    public partial class Devoluciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Controladores.DevolucionesControladores DevolucionesControladores = new Controladores.DevolucionesControladores();
                    gvwDevoluciones.DataSource = DevolucionesControladores.GetTodaslasDevolucionesController();
                    ddlDevoluciones.DataValueField = "inId_Devoluciones";
                    ddlId_Producto.DataValueField = "obClsProductos";
                    ddlId_Factura.DataValueField = "obClsFacturas";
                    gvwDevoluciones.DataBind();
                }
                catch (Exception ex) { }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Controladores.DevolucionesControladores obDevolucionesControladores = new Controladores.DevolucionesControladores();
                Logica.Modelos.ClsDevoluciones obClsDevoluciones = new Logica.Modelos.ClsDevoluciones
                {
                    inId_Devoluciones = Convert.ToInt32(ddlDevoluciones.Text),
                    inCantidad = Convert.ToInt32(txtCantidad.Text),
                    stFecha = txtFecha.Text,
                    stCambio = txtCambio.Text,
                    stObservacio = txtObservacion.Text,
                    obClsFacturas = new Logica.Modelos.ClsFacturas { inId_Factura = Convert.ToInt32(ddlId_Factura) },
                    obClsProductos = new Logica.Modelos.ClsProductos { inId_Producto = Convert.ToInt32(ddlId_Producto) }


                };

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obDevolucionesControladores.CreateDevolucionesController(obClsDevoluciones) + "!', 'success') </script>");


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
                int codigoProducto = Convert.ToInt32(((Label)gvwDevoluciones.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.DevolucionesControladores obDevolucionesControladores = new Controladores.DevolucionesControladores();
                obDevolucionesControladores.EliminarDevolucionesController(new Logica.Modelos.ClsDevoluciones
                {
                    inId_Devoluciones = codigoProducto
                });

                gvwDevoluciones.DataSource = obDevolucionesControladores.GetTodaslasDevolucionesController();
                gvwDevoluciones.DataBind();
            }

            if (e.CommandName == "Editar")
            {
                int codigoCliente = Convert.ToInt32(((Label)gvwDevoluciones.Rows[indice].FindControl("lblCodigo")).Text);
                ddlDevoluciones.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[0].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[0].Text;
                ddlId_Producto.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[1].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[1].Text;
                ddlId_Factura.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[2].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[2].Text;
                txtFecha.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[3].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[3].Text;
                txtCantidad.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[4].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[4].Text;
                txtCambio.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[5].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[5].Text;
                txtObservacion.Text = string.IsNullOrEmpty(gvwDevoluciones.Rows[indice].Cells[6].Text) ? string.Empty : gvwDevoluciones.Rows[indice].Cells[6].Text;

            }
        }
    }
}