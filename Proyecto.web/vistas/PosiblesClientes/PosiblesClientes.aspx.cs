using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto.web.vistas.PosiblesClientes
{
	public partial class PosiblesClientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				try
				{
					Controladores.PosiblesClienteControladores obPosiblesClientesControladores = new Controladores.PosiblesClienteControladores();
					DataSet dsConsulta = obPosiblesClientesControladores.getConsultarPosiblesClientesControladores();

					if (dsConsulta.Tables[0].Rows.Count > 0)
					{
						gvwDatos.DataSource = dsConsulta;
					}
					else
					{
						gvwDatos.DataSource = null;

					}
					gvwDatos.DataBind();
				}
				catch (Exception ex)
				{
					ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error', '" + ex.Message + "', 'error')</script>");
				}
			}
		}

		protected void btnGuardar_Click(object sender, EventArgs e)
		{
			
		}
	}
}
