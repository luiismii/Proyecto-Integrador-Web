using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.BL
{
    public class Devoluciones
    {

        public string CreateDevoluciones(Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    var id = 0;
                    if (obEntities.DEVOLUCIONES.Select(x => x.Id_Devoluciones).Any())
                        id = obEntities.DEVOLUCIONES.Select(x => x.Id_Devoluciones).Max();

                    id += 1;
                    obClsDevoluciones.inId_Devoluciones = id;

                    obEntities.DEVOLUCIONES.Add(new Entidades.DEVOLUCIONES
                    {
                         Id_Devoluciones= obClsDevoluciones.inId_Devoluciones,
                        Cantidad = obClsDevoluciones.inCantidad,
                         Fecha= obClsDevoluciones.stFecha,
                         Cambio= obClsDevoluciones.stCambio,
                         Id_Factura= obClsDevoluciones.obClsFacturas.inId_Factura,
                          Observacion= obClsDevoluciones.stObservacio,
                        Id_Producto = obClsDevoluciones.obClsProductos.inId_Producto

                    });

                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public string updateDevoluciones(Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.DEVOLUCIONES obDEVOLUCIONES = (from Q in obEntities.DEVOLUCIONES
                                                         where Q.Id_Devoluciones == obClsDevoluciones.inId_Devoluciones
                                                     select Q).FirstOrDefault();
                    obDEVOLUCIONES.Id_Devoluciones = obClsDevoluciones.inId_Devoluciones;
                    obDEVOLUCIONES.Cantidad = obClsDevoluciones.inCantidad;
                    obDEVOLUCIONES.Fecha = obClsDevoluciones.stFecha;
                    obDEVOLUCIONES.Cambio = obClsDevoluciones.stCambio;
                    obDEVOLUCIONES.Id_Factura = obClsDevoluciones.obClsFacturas.inId_Factura;
                    obDEVOLUCIONES.Observacion = obClsDevoluciones.stObservacio;
                    obDEVOLUCIONES.Id_Producto = obClsDevoluciones.obClsProductos.inId_Producto;
               
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string deleteDevoluciones(Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {

                    Entidades.DEVOLUCIONES obDEVOLUCIONES = (from Q in obEntities.DEVOLUCIONES
                                                             where Q.Id_Devoluciones == obClsDevoluciones.inId_Devoluciones
                                                     select Q).FirstOrDefault();

                    obEntities.DEVOLUCIONES.Remove(obDEVOLUCIONES);
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Modelos.ClsDevoluciones> GetTodaslasDevoluciones()
        {
            using (var db = new Entidades.Entities())
            {
                var listDevoluciones = (from Q in db.DEVOLUCIONES
                                        select new Modelos.ClsDevoluciones
                                        {
                                            inId_Devoluciones = Q.Id_Devoluciones,
                                            inCantidad = (int)Q.Cantidad,
                                            stFecha = Q.Fecha,
                                            stCambio = Q.Cambio,
                                            //obClsFacturas =  _devoluciones.Id_Factura,
                                            stObservacio = Q.Observacion,
                                            //obClsProductos = _devoluciones.Id_Producto

                                        }).ToList();

                return listDevoluciones;
            }
        }

        public List<Modelos.ClsDevoluciones> GetBuscarUnaDevolucion(Modelos.ClsDevoluciones obClsDevoluciones)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.DEVOLUCIONES
                            where Q.Id_Devoluciones == obClsDevoluciones.inId_Devoluciones
                            select new Modelos.ClsDevoluciones
                            {
                                inId_Devoluciones = Q.Id_Devoluciones,
                                inCantidad = (int)Q.Cantidad,
                                stFecha = Q.Fecha,
                                //obClsFacturas = Q.Id_Factura,
                                stObservacio = Q.Observacion,
                                //obClsProductos = Q.Id_Producto,
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        
    }
}
