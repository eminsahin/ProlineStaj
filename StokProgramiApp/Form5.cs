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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                string searching = textBox1.Text.Trim().ToUpper();
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == searching)
                                {
                                    cell.Style.BackColor = Color.DarkTurquoise;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54012/");
            HttpResponseMessage response = client.GetAsync("api/Products").Result;
            var pro = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            dataGridView1.DataSource = pro;

        }
    }
}
