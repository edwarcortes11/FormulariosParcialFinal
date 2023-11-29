using FormulariosParcialFinal.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosParcialFinal.Formularios
{
    public partial class ConsultaFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");
            var request = httpClient.GetAsync("api/FACTURA/" + TextBox1.Text).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Factura>(resultString);

                if (listado != null)
                {
                    TextBox2.Text = (listado.ID_CLIENTE).ToString();
                    TextBox3.Text = (listado.ID_PRODUCTO).ToString();
                    TextBox4.Text = (listado.CANTIDAD).ToString();
                    TextBox5.Text = (listado.SUBTOTAL).ToString();
                    TextBox6.Text = (listado.IVA).ToString();
                    TextBox7.Text = (listado.TOTAL).ToString();

                }
                else
                {
                    Label8.Text = "No se pudo consultar la factura";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Label8.Text = "";
        }
    }
}