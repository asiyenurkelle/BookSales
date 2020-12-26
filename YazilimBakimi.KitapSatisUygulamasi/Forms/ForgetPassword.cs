using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    public partial class ForgetPassword : Form
    {
        SqlConnection connection = new SqlConnection("Server = . ; Database = KitapSatis; integrated security=true");
        public ForgetPassword()
        {
            InitializeComponent();
        }



        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        public void Sifre(TextBox txtBxAnswer, TextBox txtBxPassword, TextBox txtBxKullaniciAd)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TblLoginCustomer WHERE UserName='" + txtBxKullaniciAd.Text + "'", connection);
            SqlDataReader read = komut.ExecuteReader();
            if (txtBxPassword.Text == txtBxNewPasswordAgain.Text)
            {
                if (read.Read())
                {
                    //cevap doğruysa
                    if (txtBxAnswer.Text == read["Answer"].ToString())
                    {
                        connection.Close();
                        connection.Open();
                        komut = new SqlCommand("UPDATE TblLoginCustomer SET Password='" + Cryptology.MD5Sifrele(txtBxPassword.Text) + "' WHERE UserName='" + txtBxKullaniciAd.Text + "'", connection);
                        komut.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("İslem Basarili");

                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgilerinizi kontrol edin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen yeni şifreniz ile tekrarını kontrol ediniz");
            }
            //kullanıcıadı doğruysa

            connection.Close();
        }
       

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxBackForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm cikis = new LoginForm();
            cikis.ShowDialog();
        }

        private void btnForgotPassword_Click_1(object sender, EventArgs e)
        {
            Sifre(txtBxAnswer, txtBxPassword, txtBxKullaniciAd);
        }

        private void BtnForgotPasswordExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm cikis = new LoginForm();
            cikis.ShowDialog();
        }

        private void pictureBoxBackForgotPassword_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm cikis = new LoginForm();
            cikis.ShowDialog();
        }
    }
}
