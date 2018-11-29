using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.TipoPago
{
    public partial class TipoPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Controladores.TipoPagoControladores obTipoPagoControladores = new Controladores.TipoPagoControladores();
                ddlId_TipoPago.DataSource = obTipoPagoControladores.GetTodoslosTipoPagoController();
                ddlId_TipoPago.DataTextField = "inId_TipoPago";
                txtDescripcion.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Controladores.TipoPagoControladores obTipoPagoControladores = new Controladores.TipoPagoControladores();
                Logica.Modelos.ClsTipoPago obClsTipoPago = new Logica.Modelos.ClsTipoPago
                {
                    inId_Tipopago = Convert.ToInt32(ddlId_TipoPago.Text),
                    stDescripcion = txtDescripcion.Text

                };

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obTipoPagoControladores.CreateTipoPagoController(obClsTipoPago) + "!', 'success') </script>");


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }

        protected void gvw_TipopagoRowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Eliminar")
            {
                int codigoProducto = Convert.ToInt32(((Label)gvwTipopago.Rows[indice].FindControl("lblCodigo")).Text);

                Controladores.TipoPagoControladores obTipoPagoControladores = new Controladores.TipoPagoControladores();
                obTipoPagoControladores.EliminarTipoPagoController(new Logica.Modelos.ClsTipoPago
                {
                    inId_Tipopago = codigoProducto
                });

                gvwTipopago.DataSource = obTipoPagoControladores.GetTodoslosTipoPagoController();
                gvwTipopago.DataBind();
            }

            if (e.CommandName == "Editar")
            {
                int codigoCliente = Convert.ToInt32(((Label)gvwTipopago.Rows[indice].FindControl("lblCodigo")).Text);
                ddlId_TipoPago.Text = string.IsNullOrEmpty(gvwTipopago.Rows[indice].Cells[0].Text) ? string.Empty : gvwTipopago.Rows[indice].Cells[0].Text;
                txtDescripcion.Text = string.IsNullOrEmpty(gvwTipopago.Rows[indice].Cells[1].Text) ? string.Empty : gvwTipopago.Rows[indice].Cells[1].Text;

            }
        }
}