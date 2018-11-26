using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
    public class VentasControladores
    {
        public List<Logica.Modelos.ClsProveedores> GetProveedoresController()
        {
            try
            {
                Logica.BL.Proveedores proveedores = new Logica.BL.Proveedores();
                return proveedores.GetProveedores();
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Logica.Modelos.ClsProveedor_Producto> GetProveedorProductosController(int proveedorId)
        {
            try
            {
                Logica.BL.Productos productos = new Logica.BL.Productos();
                return productos.GetProductos(proveedorId);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}