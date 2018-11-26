using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class ClsPosiblesClientes
    {
        SqlConnection _SqlConnection = null;
        SqlCommand _SqlCommand = null;
        SqlDataAdapter _SqlDataAdapter = null;
        string stconexion = string.Empty;
        SqlParameter _SqlParameter = null;
        public ClsPosiblesClientes()
        {
            ClsConexion obclsConexion = new ClsConexion();
            stconexion = obclsConexion.getConexion();
        }
        public DataSet getConsultarPosiblesClientes()
        {
            try
            {
                DataSet dsConsulta = new DataSet();
                _SqlConnection = new SqlConnection(stconexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("ConsultarClientes", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.ExecuteNonQuery();
                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);
                return dsConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
