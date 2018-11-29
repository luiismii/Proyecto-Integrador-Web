using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class ClsUsuarios
    {

        
        public string CreateUsuarios(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    var id = 0;
                    if (obEntities.USUARIOS.Select(x => x.Id).Any())
                        id = obEntities.USUARIOS.Select(x => x.Id).Max();

                    id += 1;
                    obClsUsuarios.inId = id;

                    obEntities.USUARIOS.Add(new Entidades.USUARIOS
                    {
                        Id = obClsUsuarios.inId,
                        Login = obClsUsuarios.stLogin,
                        Password = obClsUsuarios.stPassword,
                        Perfil_Id = obClsUsuarios.obClsPerfiles.inId,
                         Imagen = obClsUsuarios.stImagen

                    });

                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public string updateUsuarios(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    Entidades.USUARIOS obUSUARIOS = (from Q in obEntities.USUARIOS
                                                      where Q.Id == obClsUsuarios.inId
                                                       select Q).FirstOrDefault();
                    obUSUARIOS.Login = obClsUsuarios.stLogin;
                    obUSUARIOS.Password = obClsUsuarios.stPassword;
                    obUSUARIOS.Perfil_Id = obClsUsuarios.obClsPerfiles.inId;
                    obUSUARIOS.Imagen = obClsUsuarios.stImagen;


                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string deleteUsuarios(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    if ((from q in obEntities.CLIENTES
                         where q.Usuario_Id == obClsUsuarios.inId
                         select q).Any())
                        throw new Exception("El Usuario esta asociado a un Cliente");

                    Entidades.USUARIOS obUSUARIOS = (from Q in obEntities.USUARIOS
                                                     where Q.Id == obClsUsuarios.inId
                                                       select Q).FirstOrDefault();

                    obEntities.USUARIOS.Remove(obUSUARIOS);
                    obEntities.SaveChanges();

                    return "Se Realizo el Proceso Con Exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsUsuarios> getTodoslosUsuarios()
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.USUARIOS
                            select new Modelos.ClsUsuarios
                            {
                                inId = Q.Id,
                                stLogin = Q.Login,
                                stPassword = Q.Password,
                                obClsPerfiles =new Modelos.ClsPerfiles { inId = (int)Q.Perfil_Id },
                                stImagen = Q.Imagen
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsUsuarios> getBuscarUnUsuario(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.USUARIOS
                            where Q.Id == obClsUsuarios.inId
                            select new Modelos.ClsUsuarios
                            {
                                inId = Q.Id,
                                stLogin = Q.Login,
                                stPassword = Q.Password,
                                obClsPerfiles = new Modelos.ClsPerfiles { inId = (int)Q.Perfil_Id },
                                stImagen = Q.Imagen
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public bool GetValidarUsuario(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    if ((from Q in obEntities.USUARIOS
                         where Q.Login == obClsUsuarios.stLogin && Q.Password == obClsUsuarios.stPassword
                         select Q).Any())
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
