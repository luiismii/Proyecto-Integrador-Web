﻿using System;
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
                                //obClsPerfiles = Q.Perfil_Id,
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
                                //obClsUsuarios.obClsPerfiles.Id = Q.Perfil_Id,
                                stImagen = Q.Imagen
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Modelos.ClsUsuarios> GetValidarUsuario(Modelos.ClsUsuarios obClsUsuarios)
        {
            try
            {
                using (Entidades.Entities obEntities = new Entidades.Entities())
                {
                    return (from Q in obEntities.USUARIOS
                            where Q.Login == obClsUsuarios.stLogin 
                            select new Modelos.ClsUsuarios { }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}