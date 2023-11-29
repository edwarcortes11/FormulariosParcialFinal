using FormulariosParcialFinal.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosParcialFinal.Formularios
{
    public partial class ActualizarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var cliente = new
            {
                IDCLIENTE = int.Parse(TextBox3.Text),
                NOMBRES = TextBox4.Text,
                APELLIDOS = TextBox5.Text,
                CORREO = TextBox1.Text,
                DIRECCION = TextBox6.Text,
                TELEFONO = TextBox7.Text,
                PASSWORD = TextBox2.Text,
            };

            string productoJson = JsonConvert.SerializeObject(cliente);
            HttpContent content = new StringContent(productoJson, Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("api/CLIENTE/" + TextBox3.Text, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                Label3.Text = "Contraseña actualizada satisfactoriamente";
            }
            else
            {
                Label3.Text = "No se pudo actualizar la contraseña";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");
            var request = httpClient.GetAsync("api/CLIENTE/" + TextBox3.Text).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                if (listado != null)
                {
                    TextBox4.Text = listado.NOMBRES;
                    TextBox5.Text = listado.APELLIDOS;
                    TextBox1.Text = listado.CORREO;
                    TextBox6.Text = listado.DIRECCION;
                    TextBox7.Text = listado.TELEFONO;
                    TextBox2.Text = listado.PASSWORD;
                }
                else
                {
                    Label3.Text = "No se pudo consultar el cliente";
                }
            }
        }
    }
}