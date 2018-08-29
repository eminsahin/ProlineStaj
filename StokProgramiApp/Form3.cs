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

using System.Net;
using System.Data.SqlClient;

namespace StokProgramiApp
{
    public partial class Form3 : Form
    {
        SqlCommand command;
        public Form3()
        {
            InitializeComponent();
        }
        void DeleteProduct(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RIKU\RIKU;Initial Catalog=StokKontrolProgrami;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            string sql = "DELETE FROM Product WHERE id=@id";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@id", id);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
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
            //dataGridView2.DataSource = sto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows) 
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    DeleteProduct(id);
                }
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:54012/");
                HttpResponseMessage response = client.GetAsync("api/Products").Result;
                var pro = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                dataGridView1.DataSource = pro;
            }

        }
    }
}
