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
                Controladores.FacturasControladores obFacturasControladores = new Controladores.FacturasControladores();
                ddlProveedor.DataSource = ventasControladores.GetProveedoresController();
                ddlProveedor.DataTextField = "NombreCompleto";
                ddlProveedor.DataValueField = "inId_Proveedores";
                ddlProveedor.DataBind();
            }
        }
    }
}