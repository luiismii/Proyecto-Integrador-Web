using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class Productos
    {
        public List<Modelos.ClsProveedor_Producto> GetProductos(int proveedorId)
        {
            using (var db = new Entidades.Entities())
            {
                var listProductos = (from _proveedorProductos in db.PROVEEDOR_PRODUCTO
                                     join _productos in db.PRODUCTOS on _proveedorProductos.Id_Producto equals _productos.Id_Producto
                                     where _proveedorProductos.Id_Proveedor == proveedorId
                                     select new Modelos.ClsProveedor_Producto
                                     {
                                         obClsProductos = new Modelos.ClsProductos
                                         {
                                             inId_Producto = _productos.Id_Producto,
                                             stNombre_Producto = _productos.Nombre_Producto,
                                             stDescripcion = _productos.Descripcion
                                         },
                                         inCantidad = (int)_proveedorProductos.Cantidad,
                                         inValor = (int)_proveedorProductos.Valor
                                     }).ToList();

                return listProductos;
            }
        }

        public List<Modelos.ClsProductos> GetProductos()
        {
            using (var db = new Entidades.Entities())
            {
                var listProductos = (from _productos in db.PRODUCTOS
                                     select new Modelos.ClsProductos
                                     {
                                         inId_Producto = _productos.Id_Producto,
                                         stNombre_Producto = _productos.Nombre_Producto,
                                         stDescripcion = _productos.Descripcion,
                                         inPrecio = (int)_productos.Precio
                                     }).ToList();

                return listProductos;
            }
        }



        public string CreateProductos(Modelos.ClsProductos obClsClsProductos)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    var id = 0;
                    if (obEntities.PRODUCTOS.Select(x => x.Id_Producto).Any())
                        id = obEntities.PRODUCTOS.Select(x => x.Id_Producto).Max();

                    id += 1;
                    obClsClsProductos.inId_Producto = id;

                    obEntities.PRODUCTOS.Add(new Entidades.PRODUCTOS
                    {
                        Id_Producto = obClsClsProductos.inId_Producto,
                        Nombre_Producto = obClsClsProductos.stNombre_Producto,
                        Precio = obClsClsProductos.inPrecio,
                        Descripcion = obClsClsProductos.stDescripcion

                    });

                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public string updateProductos(Modelos.ClsProductos obClsProductos)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.PRODUCTOS obPRODUCTOS = (from Q in obEntities.PRODUCTOS
                                                       where Q.Id_Producto == obClsProductos.inId_Producto
                                                       select Q).FirstOrDefault();
                    obPRODUCTOS.Nombre_Producto = obClsProductos.stNombre_Producto;
                    obPRODUCTOS.Precio = obClsProductos.inPrecio;
                    obPRODUCTOS.Descripcion = obClsProductos.stDescripcion;


                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string deleteProductos(Modelos.ClsProductos obClsProductos)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    //Linq

                    if ((from q in obEntities.PROVEEDOR_PRODUCTO
                         where q.Id_Producto == obClsProductos.inId_Producto
                         select q).Any())
                        throw new Exception("El producto esta asociado a un proveedor");

                    Entidades.PRODUCTOS obPRODUCTOS = (from Q in obEntities.PRODUCTOS
                                                       where Q.Id_Producto == obClsProductos.inId_Producto
                                                       select Q).FirstOrDefault();

                    obEntities.PRODUCTOS.Remove(obPRODUCTOS);
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }


        public List<Modelos.ClsProductos> GetTodosLosProductos()
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.PRODUCTOS
                            select new Modelos.ClsProductos
                            {
                                inId_Producto = Q.Id_Producto,
                                stNombre_Producto = Q.Nombre_Producto,
                                inPrecio = (int)Q.Precio,
                                stDescripcion = Q.Descripcion,
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsProductos> GetBuscarUnProducto(Modelos.ClsProductos obClsProductos)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.PRODUCTOS
                            where Q.Id_Producto == obClsProductos.inId_Producto
                            select new Modelos.ClsProductos
                            {
                                inId_Producto = Q.Id_Producto,
                                stNombre_Producto = Q.Nombre_Producto,
                                inPrecio = (int)Q.Precio,
                                stDescripcion = Q.Descripcion,
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }


}

