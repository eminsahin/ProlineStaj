using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Windows.Forms;
using System.Web.Http;

namespace StokProgramiApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54012/");
            HttpResponseMessage response = client.GetAsync("api/Products").Result;
            var pro = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            dataGridView1.DataSource = pro;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54012/");
            HttpResponseMessage response = client.GetAsync("api/Stocks").Result;
            var sto = response.Content.ReadAsAsync<IEnumerable<Stock>>().Result;
            dataGridView2.DataSource = sto;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
