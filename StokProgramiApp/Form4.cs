using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace StokProgramiApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


          //  using (var client = new HttpClient())
          //  {
              //  var objProduct = new Product();
              //  objProduct.Name = "textBox1";
              //  objProduct.serial_no = "textBox2";
              //  string json = JsonConvert.SerializeObject(objProduct);
              //  var content = new StringContent(json);
              //  var result = await client.PostAsync("http://localhost:54012/api/Products/", content);
              //  var responseAsString = await result.Content.ReadAsStringAsync();
          //  }
            // public async Task<Product> SaveProduct(Product product)
            // {
            //    using (var client = new HttpClient())
            //     {
            //         client.BaseAddress = new Uri("http://localhost:54012/");
            //         client.DefaultRequestHeaders.Accept.Clear();
            //         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //
            //         StringContent content = new StringContent(JsonConvert.SerializeObject(product));
            //         // HTTP POST
            //         HttpResponseMessage response = await client.PostAsync("api/Products/", content);
            //         if (response.IsSuccessStatusCode)
            //         {
            //             string data = await response.Content.ReadAsStringAsync();
            //             product = JsonConvert.DeserializeObject<Product>(data);
            //         }
            //     }
            //     return product;
            //  using (var client = new HttpClient())
            //  {
            //      Product p = new Product { Name = "textBox1_TextChanged", id_product_type = Convert.ToInt32(textBox2.Text), serial_no = "textBox3_TextChanged", product_stock= Convert.ToInt32(textBox4.Text) };
            //      client.BaseAddress = new Uri("http://localhost:54012/");
            //      var response = client.PostAsJsonAsync("api/Products/s", p).Result;
            //    if (response.IsSuccessStatusCode)
            //     {
            //         MessageBox.Show("Success");
            //     }
            //     else
            //         MessageBox.Show("Fail");
            //  }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             HttpResponseMessage ClientDeleteRequest(string RequestURI)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:54012/");
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = client.DeleteAsync(RequestURI).Result;
                return response;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
