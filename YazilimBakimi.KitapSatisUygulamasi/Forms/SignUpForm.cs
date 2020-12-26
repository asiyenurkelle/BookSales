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
using System.Configuration;

namespace YazilimBakimi.KitapSatisUygulamasi
{
    public partial class SignUp : Form
    {

        SqlConnection connection = new SqlConnection("Server = . ; Database = KitapSatis; integrated security=true");
        public SignUp()
        {
            InitializeComponent();
        }


        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblLoginCustomer (UserName,Password,Answer) values ('" + textBoxNameSignUp.Text + "','" + Cryptology.MD5Sifrele(textBoxPasswordSignUp.Text) + "','" + txtBxAnswer.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarılı", "Program");
        }

        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginFormGecis = new LoginForm();
            loginFormGecis.Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
