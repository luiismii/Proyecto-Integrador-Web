using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
namespace Proyecto.Logica.BL
{
    public class ClsGeneral
    {
        public void setEmail(Modelos.ClsCorreo obClsCorreo)
        {
            try
            {
                //objeto de correo
                MailMessage Mail = new MailMessage();

                Mail.From = new MailAddress(obClsCorreo.stForm);
                Mail.To.Add(obClsCorreo.stTo);
                Mail.Subject = obClsCorreo.stAsunto;
                Mail.Body = obClsCorreo.stMensaje;

                if (obClsCorreo.inTipo == 0) Mail.IsBodyHtml = false;
                else if (obClsCorreo.inTipo == 1) Mail.IsBodyHtml = true;

                if (obClsCorreo.inPioridad == 2) Mail.Priority = MailPriority.High;
                else if (obClsCorreo.inPioridad == 1) Mail.Priority = MailPriority.Low;
                else if (obClsCorreo.inPioridad == 0) Mail.Priority = MailPriority.Normal;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(obClsCorreo.stMensaje,
                    Encoding.UTF8,
                    MediaTypeNames.Text.Html);

                //incrustando una imagen
                LinkedResource img = new LinkedResource(obClsCorreo.stImagen, MediaTypeNames.Image.Gif);
                img.ContentId = obClsCorreo.stIdImagen;
                htmlView.LinkedResources.Add(img);

                Mail.AlternateViews.Add(htmlView);

                //cliente de servidor de correo
                SmtpClient smtp = new SmtpClient();
                smtp.Host = obClsCorreo.stServidor;

                if (obClsCorreo.blAutenticacion) smtp.Credentials = new System.Net.NetworkCredential(obClsCorreo.stUsuario, obClsCorreo.stContraceña);
                if (obClsCorreo.stPuerto.Length > 0) smtp.Port = Convert.ToInt32(obClsCorreo.stPuerto);

                smtp.EnableSsl = obClsCorreo.blConexionSegura;
                smtp.Send(Mail);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
