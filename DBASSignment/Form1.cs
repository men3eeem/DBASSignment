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

namespace DBASSignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=MEN3EEEM ; database=DB_Assignment;integrated security = true";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected successfully!");

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoverPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            hoverPanel.BackColor = Color.FromArgb(100, 0, 0, 0); // أسود شفاف يغطي الصورة
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            hoverPanel.BackColor = Color.Transparent;
        }

    }

}
