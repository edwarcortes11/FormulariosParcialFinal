using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormulariosParcialFinal.Clases;
using System.Reflection.Emit;
using System.Text;

namespace FormulariosParcialFinal.Formularios
{
    public partial class CRUDCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");
            var request = httpClient.GetAsync("api/CLIENTE/" + TextBox1.Text).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                if (listado != null)
                {
                    TextBox2.Text = listado.NOMBRES;
                    TextBox3.Text = listado.APELLIDOS;
                    TextBox4.Text = listado.CORREO;
                    TextBox5.Text = listado.DIRECCION;
                    TextBox6.Text = listado.TELEFONO;
                    TextBox7.Text = listado.PASSWORD;

                }
                else
                {
                    Label8.Text = "No se pudo consultar el cliente";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var cliente = new
            {
                IDCLIENTE = int.Parse(TextBox1.Text),
                NOMBRES = TextBox2.Text,
                APELLIDOS = TextBox3.Text,
                CORREO = TextBox4.Text,
                DIRECCION = TextBox5.Text,
                TELEFONO = TextBox6.Text,
                PASSWORD = TextBox7.Text,

            };

            string productoJson = JsonConvert.SerializeObject(cliente);
            HttpContent content = new StringContent(productoJson, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("api/CLIENTE", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                Label8.Text = "Cliente creado satisfactoriamente";
            }
            else
            {
                Label8.Text = "No se pudo crear el cliente";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var cliente = new
            {
                IDCLIENTE = int.Parse(TextBox1.Text),
                NOMBRES = TextBox2.Text,
                APELLIDOS = TextBox3.Text,
                CORREO = TextBox4.Text,
                DIRECCION = TextBox5.Text,
                TELEFONO = TextBox6.Text,
                PASSWORD = TextBox7.Text,
            };

            string productoJson = JsonConvert.SerializeObject(cliente);
            HttpContent content = new StringContent(productoJson, Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("api/CLIENTE/" + TextBox1.Text, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                Label8.Text = "Cliente actualizado satisfactoriamente";
            }
            else
            {
                Label8.Text = "No se pudo actualizar el cliente";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var response = httpClient.DeleteAsync("api/CLIENTE/" + TextBox1.Text).Result; ;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Cliente>(resultString);

                Label8.Text = "Cliente eliminado satisfactoriamente";
            }
            else
            {
                Label8.Text = "No se pudo eliminar el cliente";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
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