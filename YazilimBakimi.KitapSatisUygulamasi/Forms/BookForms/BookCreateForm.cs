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
    public partial class BookCreateForm : Form
    {
        public BookCreateForm()
        {
            InitializeComponent();
        }


        private void btnSendBookCreate_Click(object sender, EventArgs e)
        {
            if (!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Lütfen alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool CreationSuccessful = DbBook.CreateBook(new Book()
            {
                Genre = txtBoxGenre.Text,
                BookName = txtBoxBookName.Text,
                WriterFullName = txtBoxWriterName.Text,
                Price = txtBoxPrice.Text,
                
            });


            if (CreationSuccessful)
                MessageBox.Show(this, "Kitap eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Kitap eklenirken bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private bool TextFieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtBoxWriterName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBookName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(txtBoxGenre.Text))
                return false;

            return true;
        }

        private void btnCreateBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCRUDForm bookCRUDForm = new BookCRUDForm();
            bookCRUDForm.ShowDialog();
            this.Close();
        }

    }
    }
