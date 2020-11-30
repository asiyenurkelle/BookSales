using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    public partial class WriterCreateForm : Form
    {
        public WriterCreateForm()
        {
            InitializeComponent();
        }

        private void btnCreateWriter_Click(object sender, EventArgs e)
        {
            if (!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


           bool CreationSuccessful= DbWriter.CreateWriter(new Writer()
           {
                FullName = txtFullName.Text,
                BirthDate= txtBirthDate.Text,
                Country = txtCountry.Text,
                Genre = txtGenre.Text,

           });


            if (CreationSuccessful)
                MessageBox.Show(this, "Yazar eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Yazar eklenirken bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private bool TextFieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text))
                return false;

            return true;
        }

        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriterCRUDForm writerCRUDForm = new WriterCRUDForm();
            writerCRUDForm.ShowDialog();
            this.Close();
        }
    }
}
