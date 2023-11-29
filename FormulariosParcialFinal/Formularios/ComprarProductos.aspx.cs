using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosParcialFinal.Formularios
{
    public partial class ComprarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string server = "server = EDWARNOMINA\\SQLEXPRESS; database=DesarrolloWebParcial; Integrated Security=true;";
        SqlConnection conexion = new SqlConnection();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int cliente = Convert.ToInt32(DropDownList1.Text);
            int producto = Convert.ToInt32(DropDownList2.Text);
            int cant = Convert.ToInt32(TextBox1.Text);

            conexion.ConnectionString = server;
            conexion.Open();
            SqlCommand comando = new SqlCommand("CrearFactura", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_CLIENTE", cliente);
            comando.Parameters.AddWithValue("@ID_PRODUCTO", producto);
            comando.Parameters.AddWithValue("@CANTIDAD", cant);

            try
            {
                comando.ExecuteNonQuery();
                Label4.Text = "Compra realizada con Exito";
            }
            catch(SqlException EX)
            {
                Label4.Text = EX.Message;
                throw;
            }

            conexion.Close();
        }
    }
}