using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class Proveedores
    {
        public List<Modelos.ClsProveedores> GetProveedores()
        {
            using (var db = new Entidades.Entities())
            {
                var productos = (from _proveedor in db.PROVEEDORES
                                 select new Modelos.ClsProveedores
                                 {
                                     inId_Proveedores = _proveedor.Id_Proveedor,
                                     stPrimer_Nombre = _proveedor.Primer_Nombre,
                                     stSegundo_Nombre = _proveedor.Segundo_Nombre,
                                     stPrimer_Apellido = _proveedor.Primer_Apellido,
                                     stSegundo_Apellido = _proveedor.Segundo_Apellido,
                                     stEmpresa = _proveedor.Empresa,
                                     stDireccion = _proveedor.Direccion,
                                     stTelefono = _proveedor.Telefono,
                                     stCorreo = _proveedor.Correo,
                                     stFecha_Nacimiento = _proveedor.Fecha_Nacimiento,
                                     NombreCompleto = _proveedor.Primer_Nombre + " " + _proveedor.Segundo_Nombre + " " + _proveedor.Primer_Apellido + " " + _proveedor.Segundo_Apellido
                                 });

                var listProductos = productos.ToList();

                return listProductos;
            }
        }

    }
}
