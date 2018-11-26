using System;
using System.Web;

namespace Proyecto.web.vistas.Login
{
	public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{
				if (Request.Cookies["cookieEmail"] != null)
					txtEmail.Text = Request.Cookies["cookieEmail"].Value.ToString();
			}
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
			try
			{
				string stmensaje = string.Empty;
				if (string.IsNullOrEmpty(txtEmail.Text)) stmensaje += ("Ingrese Email, ");
				if (string.IsNullOrEmpty(txtPassword.Text)) stmensaje += ("Ingrese Password, ");
				if (!string.IsNullOrEmpty(stmensaje)) throw new Exception(stmensaje.TrimEnd(','));

				Logica.Modelos.ClsUsuarios obClsUsuarios = new Logica.Modelos.ClsUsuarios
				{
					stLogin = txtEmail.Text,
					stPassword = txtPassword.Text,

				};
				Controladores.LoginControladores ObloginControladores = new Controladores.LoginControladores();
                //bool BlBandera =
                ObloginControladores.GetValidarUsuarioController(obClsUsuarios);
                
				//if (BlBandera)
				//{
					//Session["SessionEmail"] = txtEmail.Text;
					//if (chkRecordar.Checked)
					//{
						//HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
						//cookie.Expires = DateTime.Now.AddDays(2);
					//	Response.Cookies.Add(cookie);
					//}
					//else
					//{
						//HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
						//cookie.Expires = DateTime.Now.AddDays(-1);
						//Response.Cookies.Add(cookie);
					//}

					Response.Redirect("../Index/Index.aspx");
			//} else throw new Exception("Usuario o Contraceña Incorrectos");

            }
            catch (Exception we)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error', '" + we.Message + "', 'error')</script>");
            }

        }
    }
}