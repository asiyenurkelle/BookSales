using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class CustomerForm : Form
    {
        
        public CustomerForm()
        {
            InitializeComponent();
        }


        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Lütfen alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            buttonListele.Enabled = true;

            bool TextFieldsAreValid()
            {
                if (string.IsNullOrWhiteSpace(textboxName.Text) ||
                    string.IsNullOrWhiteSpace(textboxTC.Text) ||
                    string.IsNullOrWhiteSpace(textboxPhone.Text) ||
                    string.IsNullOrWhiteSpace(textboxAdress.Text))
                    return false;

                return true;
            }
        }

        private bool TextFieldsAreValid()
        {
            throw new NotImplementedException();
        }



        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textboxTC.Text = "";
            textboxName.Text = "";
            textboxAdress.Text = "";
            textboxPhone.Text = "";
        }

        private void groupBoxKisiselBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            buttonListele.Enabled = false;
        }

        SalesForm sf = new SalesForm();

        private void buttonListele_Click(object sender, EventArgs e)
        {
            sf.textboxName.Items.Add(textboxName.Text);
            sf.textboxTC.Items.Add(textboxTC.Text);
            sf.textboxPhone.Items.Add(textboxPhone.Text);
            sf.textboxAdress.Items.Add(textboxAdress.Text);

            this.Hide();
            sf.ShowDialog();


        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm cikis = new LoginForm();
            cikis.ShowDialog();
        }
    }
}
