using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Http;
using System.Net;
using System.Data.SqlClient;

namespace StokProgramiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=RIKU\RIKU;Initial Catalog=StokKontrolProgrami;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from [User] where username = '" + textBox1.Text + "' and password='" + Password.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Invalid username or password");


            }
            else
            {
                this.Hide();
                new Form2().Show();
            }
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
         




        }


            private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Passwor_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult select = MessageBox.Show("Are You Sure Want to Exit? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (select == DialogResult.No)
            {
                
                return ;
            }
            Application.Exit();
        }
    }
}
