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
    public partial class CRUDProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");
            var request = httpClient.GetAsync("api/PRODUCTO/" + TextBox1.Text).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Producto>(resultString);

                if (listado != null)
                {
                    TextBox2.Text = listado.NOMBRE;
                    TextBox3.Text = listado.DESCRIPCION;
                    TextBox4.Text = (listado.PRECIO).ToString();
                }
                else
                {
                    Label5.Text = "No se pudo consultar el producto";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var producto = new
            {
                IDPRODUCTO = int.Parse(TextBox1.Text),
                NOMBRE = TextBox2.Text,
                DESCRIPCION = TextBox3.Text,
                PRECIO = decimal.Parse(TextBox4.Text),
            };

            string productoJson = JsonConvert.SerializeObject(producto);
            HttpContent content = new StringContent(productoJson, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("api/PRODUCTO", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Producto>(resultString);

                Label5.Text = "Producto creado satisfactoriamente";
            }
            else
            {
                Label5.Text = "No se pudo crear el producto";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var producto = new
            {
                IDPRODUCTO = int.Parse(TextBox1.Text),
                NOMBRE = TextBox2.Text,
                DESCRIPCION = TextBox3.Text,
                PRECIO = decimal.Parse(TextBox4.Text),
            };

            string productoJson = JsonConvert.SerializeObject(producto);
            HttpContent content = new StringContent(productoJson, Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("api/PRODUCTO/" + TextBox1.Text, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Producto>(resultString);

                Label5.Text = "Producto actualizado satisfactoriamente";
            }
            else
            {
                Label5.Text = "No se pudo actualizar el producto";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44356/");

            var response = httpClient.DeleteAsync("api/PRODUCTO/" + TextBox1.Text).Result; ;

            if (response.IsSuccessStatusCode)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<Producto>(resultString);

                Label5.Text = "Producto eliminado satisfactoriamente";
            }
            else
            {
                Label5.Text = "No se pudo eliminar el producto";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label5.Text = "";
        }
    }
}