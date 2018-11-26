using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.BL
{
    public class ClsClientes
    {
        public string CreateCliente(Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    obEntities.CLIENTES.Add(new Entidades.CLIENTES
                    {
                        Id_Cliente = obClsPosiblesClientes.inId_Cliente,
                        Usuario_Id = obClsPosiblesClientes.ClsUsuarios.inId,
                        Primer_Nombre = obClsPosiblesClientes.stPrimerNombre,
                        Segundo_Nombre = obClsPosiblesClientes.stSegundoNombre,
                        Primer_Apellido = obClsPosiblesClientes.stPrimerApellido,
                        Segundo_Apellido = obClsPosiblesClientes.stSegundoApellido,
                        Direccion = obClsPosiblesClientes.stDireccion,
                        Telefono = obClsPosiblesClientes.stTelefono,
                        Correo = obClsPosiblesClientes.stCorreo,
                        Fecha_Nacimiento = obClsPosiblesClientes.stFecha_Nacimiento
                    });

                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public string updateClientes(Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.CLIENTES obCLIENTES = (from Q in obEntities.CLIENTES
                                                     where Q.Id_Cliente == obClsPosiblesClientes.inId_Cliente
                                                     select Q).FirstOrDefault();
                    obCLIENTES.Primer_Nombre = obClsPosiblesClientes.stPrimerNombre;
                    obCLIENTES.Segundo_Nombre = obClsPosiblesClientes.stSegundoNombre;
                    obCLIENTES.Primer_Apellido = obClsPosiblesClientes.stPrimerApellido;
                    obCLIENTES.Segundo_Apellido = obClsPosiblesClientes.stSegundoApellido;
                    obCLIENTES.Direccion = obClsPosiblesClientes.stDireccion;
                    obCLIENTES.Telefono = obClsPosiblesClientes.stTelefono;
                    obCLIENTES.Correo = obClsPosiblesClientes.stCorreo;
                    obCLIENTES.Fecha_Nacimiento = obClsPosiblesClientes.stFecha_Nacimiento;

                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string deleteClientes(Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.CLIENTES obCLIENTES = (from Q in obEntities.CLIENTES
                                                     where Q.Id_Cliente == obClsPosiblesClientes.inId_Cliente
                                                     select Q).FirstOrDefault();


                    obEntities.CLIENTES.Remove(obCLIENTES);
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsPosiblesClientes> getTodoslosClientes()
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.CLIENTES
                            select new Modelos.ClsPosiblesClientes
                            {
                                inId_Cliente = Q.Id_Cliente,
                                stPrimerNombre = Q.Primer_Nombre,
                                stSegundoNombre = Q.Segundo_Nombre,
                                stPrimerApellido = Q.Primer_Apellido,
                                stSegundoApellido = Q.Segundo_Apellido,
                                stDireccion = Q.Direccion,
                                stTelefono = Q.Telefono,
                                stCorreo = Q.Correo,
                                stFecha_Nacimiento = Q.Fecha_Nacimiento,
                             }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsPosiblesClientes> getBuscarUnClientes(Modelos.ClsPosiblesClientes obClsPosiblesClientes)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.CLIENTES
                            where Q.Id_Cliente == obClsPosiblesClientes.inId_Cliente
                            select new Modelos.ClsPosiblesClientes
                            {
                                inId_Cliente = Q.Id_Cliente,
                                stPrimerNombre = Q.Primer_Nombre,
                                stSegundoNombre = Q.Segundo_Nombre,
                                stPrimerApellido = Q.Primer_Apellido,
                                stSegundoApellido = Q.Segundo_Apellido,
                                stDireccion = Q.Direccion,
                                stTelefono = Q.Telefono,
                                stCorreo = Q.Correo,
                                stFecha_Nacimiento = Q.Fecha_Nacimiento,
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
 
