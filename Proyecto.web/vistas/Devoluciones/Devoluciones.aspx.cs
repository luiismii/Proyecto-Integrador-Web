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
    }
}