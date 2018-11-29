using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.BL
{
    public class ClsPago
    {

        public string updateTipoPago(Modelos.ClsTipoPago obClsTipoPago)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.TIPOPAGO obTIPOPAGO = (from Q in obEntities.TIPOPAGO
                                                     where Q.Id_Pago == obClsTipoPago.inId_Tipopago
                                                       select Q).FirstOrDefault();

                    obTIPOPAGO.Descripcion = obClsTipoPago.stDescripcion;


                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string deleteTipoPago(Modelos.ClsTipoPago obClsTipoPago)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {

                    Entidades.TIPOPAGO obTIPOPAGO = (from Q in obEntities.TIPOPAGO
                                                      where Q.Id_Pago == obClsTipoPago.inId_Tipopago
                                                       select Q).FirstOrDefault();

                    obEntities.TIPOPAGO.Remove(obTIPOPAGO);
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Modelos.ClsTipoPago> GetBuscarUnTipoPago(Modelos.ClsTipoPago obClsProductos)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.TIPOPAGO
                            where Q.Id_Pago == obClsProductos.inId_Tipopago
                            select new Modelos.ClsTipoPago
                            {
                                inId_Tipopago = Q.Id_Pago,
                                stDescripcion = Q.Descripcion,
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

