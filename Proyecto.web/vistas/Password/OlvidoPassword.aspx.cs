using System;
using System.Configuration;
using System.Data;

namespace Proyecto.web.vistas.Password
{
    public partial class OlvidoPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtCorreo.Text)) stMensaje += "Ingrese email,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Controladores.RecuperarContraceñaControladores obRecuperarContraceñaControladores = new Controladores.RecuperarContraceñaControladores();
                Logica.Modelos.ClsUsuarios obClsUsuarios = new Logica.Modelos.ClsUsuarios
                {
                    stLogin = txtCorreo.Text
                };

                DataSet dsConsulta = obRecuperarContraceñaControladores.getRecuperarContraceñaControladores(obClsUsuarios);

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    string[] stLogin = dsConsulta.Tables[0].Rows[0]["Login"].ToString().Split('@');

                    string stCuerpoHTML = "<!DOCTYPE html>";
                    stCuerpoHTML += "<html lang='es'>";
                    stCuerpoHTML += "<head>";
                    stCuerpoHTML += "<meta charset='utf - 8'>";
                    stCuerpoHTML += "<title>Recuperacion de correo</title>";
                    stCuerpoHTML += "</head>";
                    stCuerpoHTML += "<body style='background - color: black '>";
                    stCuerpoHTML += "<table style='max - width: 600px; padding: 10px; margin: 0 auto; border - collapse: collapse; '>	";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='padding: 0'>";
                    stCuerpoHTML += "<img style='padding: 0; display: block' src='cid:Fondo' width='100%' height='10%'>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='background - color: #ecf0f1'>";
                    stCuerpoHTML += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>";
                    stCuerpoHTML += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola " + stLogin[0] + "</h2>";
                    stCuerpoHTML += "<p style='margin: 2px; font - size: 15px'>";
                    stCuerpoHTML += "Hemos recibido una solicitud para restablecer el password de su cuenta asociada con ";
                    stCuerpoHTML += "esta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este ";
                    stCuerpoHTML += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "Su password es: " + dsConsulta.Tables[0].Rows[0]["Password"].ToString();
                    stCuerpoHTML += "</p>";
                    stCuerpoHTML += "<p style='color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0'>Copyright © CRM 2018</p>";
                    stCuerpoHTML += "</div>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "</table>";
                    stCuerpoHTML += "</body>";
                    stCuerpoHTML += "</html>";

                    Logica.Modelos.ClsCorreo obClsCorreo = new Logica.Modelos.ClsCorreo
                    {
                        stServidor = ConfigurationManager.AppSettings["stServidor"].ToString(),
                        stUsuario = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stContraceña = ConfigurationManager.AppSettings["stPassword"].ToString(),
                        stPuerto = ConfigurationManager.AppSettings["stPuerto"].ToString(),
                        blAutenticacion = true,
                        blConexionSegura = true,
                        inPioridad = 0,//prioridad normal
                        inTipo = 1,//html
                        stAsunto = "Recuperacion de password",
                        stForm = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stTo = txtCorreo.Text,
                        stImagen = Server.MapPath("~") + @"\Recursos\Imagenes\Fondo.jpg",
                        stIdImagen = "Fondo",
                        stMensaje = stCuerpoHTML
                    };

                    obRecuperarContraceñaControladores.setEmailControladores(obClsCorreo);
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', 'Se realizo proceso con exito!', 'success') </script>");
                }
                else
                    throw new Exception("No se encontro informacion asociada a esa direccion de correo");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}