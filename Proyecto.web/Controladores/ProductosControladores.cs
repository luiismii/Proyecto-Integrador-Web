using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controladores
{
	public class ProductosControladores
	{
        public string CreateProductosController(Logica.Modelos.ClsProductos obClsProductos)
        {
            try
            {
                Logica.BL.Productos obProductos = new Logica.BL.Productos();
                return obProductos.CreateProductos(obClsProductos);
            }
            catch (Exception ex) { throw ex; }
        }


        public string updateProductosController(Logica.Modelos.ClsProductos obClsProductos)
        {
            try
            {
                Logica.BL.Productos obProductos = new Logica.BL.Productos();
                return obProductos.updateProductos(obClsProductos);
            }
            catch (Exception ex) { throw ex; }
        }


        public string EliminarProductosController(Logica.Modelos.ClsProductos obClsProductos)
        {
            try
            {
                Logica.BL.Productos obProductos = new Logica.BL.Productos();
                return obProductos.deleteProductos(obClsProductos);
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsProductos> GetTodoslosProductosController()
        {
            try
            {
                Logica.BL.Productos Productos = new Logica.BL.Productos();
                return Productos.GetTodosLosProductos();
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Logica.Modelos.ClsProductos> GetBuscarUnProductoController(Logica.Modelos.ClsProductos obClsProductos)
        {
            try
            {
                Logica.BL.Productos Productos = new Logica.BL.Productos();
                return Productos.GetBuscarUnProducto(obClsProductos);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}