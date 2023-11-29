using FormulariosParcialFinal.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosParcialFinal.Formularios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conexion = new SqlConnection("server = EDWARNOMINA\\SQLEXPRESS; database=DesarrolloWebParcial; Integrated Security=true;");
        protected void Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from CLIENTE where CORREO = '" + TextBox1.Text + "' and PASSWORD ='" + TextBox2.Text + "'";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
               DesarrolloWebParcialEntities db = new DesarrolloWebParcialEntities();
               Label3.Text = "Ingreso Exitoso";
            }
            else
            {
                Label3.Text = "Usuario/contraseña incorrecta";
            }
            conexion.Close();
        }
    }
}