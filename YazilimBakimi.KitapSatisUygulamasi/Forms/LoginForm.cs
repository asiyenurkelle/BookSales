using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using YazilimBakimi.KitapSatisUygulamasi.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms;

namespace YazilimBakimi.KitapSatisUygulamasi
{

    public partial class LoginForm : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        public LoginForm()
        {
            InitializeComponent();
        }

        bool isThere;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string password = Cryptology.MD5Sifrele(textBoxPassword.Text);
            

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblLoginCustomer", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (userName == reader["UserName"].ToString() && password == reader["Password"].ToString())
                {
                    isThere = true;
                    break;

                }
                else
                {
                    isThere = false;
                }
            }

            connection.Close();
            if (isThere)
            {
              
                this.Hide();
                CustomerForm CF = new CustomerForm();
                CF.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }



        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin loginGecis = new AdminLogin();
            loginGecis.Show();

        }

    }
}
