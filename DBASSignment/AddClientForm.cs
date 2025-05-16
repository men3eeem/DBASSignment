using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBASSignment
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                if (name == "" || phone == "" || email == "")
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                try
                {
                    using (SqlConnection con = new SqlConnection("server=MEN3EEEM; database=DB_Assignment; integrated security=true"))
                    {
                        con.Open();
                        string query = "INSERT INTO Client (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Phone", phone);
                            cmd.Parameters.AddWithValue("@Email", email);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Client added successfully.");
                            this.Close(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the AddClientForm and returns to the previous form
        }
    }
}
