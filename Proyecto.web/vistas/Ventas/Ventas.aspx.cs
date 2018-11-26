using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Ventas
{
    public partial class Ventas : System.Web.UI.Page
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

        protected void gvwProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Agregar")
            {
                List<Logica.Modelos.ClsProveedor_Producto> listClsProveedor_Producto = new List<Logica.Modelos.ClsProveedor_Producto>();

                if (Session["carrito"] != null)
                {
                    listClsProveedor_Producto = (List<Logica.Modelos.ClsProveedor_Producto>)Session["carrito"];
                }

                int codigoProducto = Convert.ToInt32(((Label)gvwProductos.Rows[indice].FindControl("lblCodigo")).Text);
                string nombreProducto = ((Label)gvwProductos.Rows[indice].FindControl("lblNombre")).Text;
                int valorProducto = Convert.ToInt32(((Label)gvwProductos.Rows[indice].FindControl("lblPrecio")).Text);
                int cantidadProducto = Convert.ToInt32(((Label)gvwProductos.Rows[indice].FindControl("lblCantidad")).Text);

                if (!listClsProveedor_Producto.Where(x => x.obClsProductos.inId_Producto == codigoProducto).Any())
                {
                    listClsProveedor_Producto.Add(new Logica.Modelos.ClsProveedor_Producto
                    {
                        obClsProductos = new Logica.Modelos.ClsProductos
                        {
                            inId_Producto = codigoProducto,
                            stNombre_Producto = nombreProducto
                        },
                        inCantidad = 1,
                        inValor = valorProducto
                    });
                }
                else
                {
                    foreach (var item in listClsProveedor_Producto)
                    {
                        if (item.obClsProductos.inId_Producto == codigoProducto)
                        {
                            if (!(item.inCantidad + 1 > cantidadProducto))
                                item.inCantidad += 1;
                        }
                    }
                }

                Session["carrito"] = listClsProveedor_Producto;
                gvwProductosAgregados.DataSource = listClsProveedor_Producto;
                gvwProductosAgregados.DataBind();
            }
        }

        protected void gvwProductosAgregados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Eliminar")
            {
                List<Logica.Modelos.ClsProveedor_Producto> listClsProveedor_Producto = new List<Logica.Modelos.ClsProveedor_Producto>();

                if (Session["carrito"] != null)
                {
                    listClsProveedor_Producto = (List<Logica.Modelos.ClsProveedor_Producto>)Session["carrito"];
                }

                int codigoProducto = Convert.ToInt32(((Label)gvwProductosAgregados.Rows[indice].FindControl("lblCodigo")).Text);

                for (int i = 0; i < listClsProveedor_Producto.Count; i++)
                {
                    if (listClsProveedor_Producto[i].obClsProductos.inId_Producto == codigoProducto)
                    {
                        var producto = (from _productosAgregados in listClsProveedor_Producto
                                        where _productosAgregados.obClsProductos.inId_Producto == codigoProducto
                                        select _productosAgregados).FirstOrDefault();

                        if (producto.inCantidad - 1 == 0)
                            listClsProveedor_Producto.Remove(producto);
                        else
                            listClsProveedor_Producto[i].inCantidad -= 1;
                    }
                }

                Session["carrito"] = listClsProveedor_Producto;
                gvwProductosAgregados.DataSource = listClsProveedor_Producto;
                gvwProductosAgregados.DataBind();
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

        protected void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            Session.Remove("carrito");
            gvwProductosAgregados.DataSource = null;
            gvwProductosAgregados.DataBind();
        }
    }
}