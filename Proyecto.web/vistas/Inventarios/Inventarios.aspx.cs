using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Inventarios
{
    public partial class Inventarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Controladores.VentasControladores ventasControladores = new Controladores.VentasControladores();
                ddlProveedor.DataSource = ventasControladores.GetProveedoresController();
                ddlProveedor.DataTextField = "NombreCompleto";
                ddlProveedor.DataValueField = "inId_Proveedores";
                ddlProveedor.DataBind();
            }
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Controladores.VentasControladores ventasControladores = new Controladores.VentasControladores();
                gvwProductos.DataSource = ventasControladores.GetProveedorProductosController(Convert.ToInt32(ddlProveedor.SelectedValue));
                gvwProductos.DataBind();
            }
            catch (Exception ex) { }
        }

    }
}