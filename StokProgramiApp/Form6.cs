
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokProgramiApp
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RIKU\RIKU;Initial Catalog=StokKontrolProgrami;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        SqlDataAdapter da;
        DataSet ds;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Product", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Product");
            con.Close();
            dataGridView1.DataSource = ds.Tables["Product"];
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            int numara = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ds = new DataSet();
            //da = new SqlDataAdapter("SELECT *FROM Hareket WHERE hogr=" + numara, con);
            da = new SqlDataAdapter("Select Product.name AS NAME,ograd AS AD,id_product_type AS PRODUCT_TYPE,serial_no AS SERIAL_NO,stock_amount AS STOCK_AMOUNT,FROM Product JOIN ProductType on Product.id_product_type=ProductType.name JOIN WHERE Product.id" + numara, con);
            con.Open();
            da.Fill(ds, "ProductType");
            dataGridView2.DataSource = ds.Tables["ProductType"];
            con.Close();
        }
    }
}