using System;
using System.IO;

namespace Proyecto.web.vistas.Registrar
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Controladores.RegistrarControladores obClsRegistrarControladores = new Controladores.RegistrarControladores();

                //VALIDAMOS LA SELECCION DE UNA IMAGEN
                if (FuImagen.HasFile)
                {
                    if (!Path.GetExtension(FuImagen.FileName).Equals(".jpg"))
                        throw new Exception("Solo se admiten formatos .JPG");

                    string stRuta = Server.MapPath(@"~\tmp\") + FuImagen.FileName;//RUTA TEMPORAL
                    FuImagen.PostedFile.SaveAs(stRuta);//GUARDANDO EL ARCHIVO DENTRO DEL PROYECTO

                    string stRutaDestino = Server.MapPath(@"~\Recursos\Imagenes\") + txtCorreo.Text + Path.GetExtension(FuImagen.FileName);//RUTA DESTINO

                    if (File.Exists(stRutaDestino))
                    {
                        File.SetAttributes(stRutaDestino, FileAttributes.Normal);
                        File.Delete(stRutaDestino);
                    }

                    File.Copy(stRuta, stRutaDestino);
                    File.SetAttributes(stRuta, FileAttributes.Normal);
                    File.Delete(stRuta);

                    Logica.Modelos.ClsUsuarios obClsUsuarios = new Logica.Modelos.ClsUsuarios
                    {
                        stLogin = txtCorreo.Text,
                        stPassword = txtContraceña.Text,                        
                        obClsPerfiles = new Logica.Modelos.ClsPerfiles {
                            inId = 2
                        },
                        stImagen = stRutaDestino
                    };

                    Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes = new Logica.Modelos.ClsPosiblesClientes
                    {
                        inId_Cliente = Convert.ToInt32(txtCedula.Text),
                        stPrimerNombre = txtPrimerNombre.Text,
                        stSegundoNombre = txtSegundoNombre.Text,
                        stPrimerApellido = txtPrimerApellido.Text,
                        stSegundoApellido = txtSegundoApellido.Text,
                        stDireccion = txtDireccion.Text,
                        stTelefono = txtTelefono.Text,                        
                        stCorreo = txtCorreo.Text,
                        stFecha_Nacimiento = txtFechaNacimiento.Text
                    };

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obClsRegistrarControladores.CreateClienteController(obClsUsuarios, obClsPosiblesClientes) + "!', 'success') </script>");
                   
                }
                Response.Redirect("../Login/Login.aspx");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}