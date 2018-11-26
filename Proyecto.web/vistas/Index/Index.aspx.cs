using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.vistas.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stEmail = string.Empty;
            if (!IsPostBack)
            {
                if (Request.QueryString["stCorreo"] != null)
                    stEmail = Request.QueryString["stCorreo"].ToString();

                //ALT + 126
               // iCuenta.ImageUrl = "~/Recursos/Imagenes/" + Session["SessionEmail"].ToString() + ".jpg";
            }
        }
    }
}