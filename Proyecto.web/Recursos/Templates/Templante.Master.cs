using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.Recursos.Templates
{
    public partial class Templante : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		if (!IsPostBack)
			{
				string[] stLogin = null;
				if (Session["SessionEmail"] != null)
				{

					stLogin = Session["SessionEmail"].ToString().Split('@');
					lblUsuario.Text = stLogin[0];
				}
				else
					Response.Redirect("../Login/Login.aspx");

			}
        }

		protected void Salir_Click(object sender, EventArgs e)
		{
			Session.RemoveAll();
			Response.Redirect("../Login/Login.aspx");
		}
	}
}