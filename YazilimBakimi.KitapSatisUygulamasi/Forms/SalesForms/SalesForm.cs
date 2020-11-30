using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class SalesForm : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        private List<Book> Books { get; set; }
        private BindingSource BindingSource { get; set; } = new BindingSource();
        public bool CreationSuccessful { get; private set; }
        ToolTip toolTip = new ToolTip();


        public SalesForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(buttonSiparisAl, "Add Order");
            toolTip.SetToolTip(buttonSil, "Delete Order");
            toolTip.SetToolTip(buttonTamamla, "Done Order");
            toolTip.SetToolTip(buttonGeri, "Back");
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Books = DbBook.GetBooks();
            BindingSource.DataSource = Books;
            gridViewBook.DataSource = BindingSource;
        }

        private void buttonSiparisAl_Click(object sender, EventArgs e)
        {
            string Siparisler = "";
            int toplamTutar = 0;
            int tutar = 0;

            Siparisler = Siparisler + gridViewBook.CurrentRow.Cells[0].Value;
            toplamTutar = toplamTutar + Convert.ToInt32(gridViewBook.CurrentRow.Cells[3].Value);
            tutar = tutar + Convert.ToInt32(gridViewBook.CurrentRow.Cells[3].Value);
            textboxOrder.Items.Add(Siparisler);

            labelTutar.Text = Convert.ToString(tutar) + " TL";
            labelTutar2.Text = Convert.ToString(toplamTutar);


        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            this.tblBookTableAdapter.Fill(this.kitapSatisDataSet3.TblBook);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            textboxOrder.Items.Remove(textboxOrder.SelectedItem);
        }

        private void buttonTamamla_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblSales (TC, customerName, customerPhone, customerAdress, Price, [Order], Date) VALUES (@TC, @customerName, @customerPhone, @customerAdress, @Price, @Order, @Date)");
            cmd.Connection = connection;

            string order;

            cmd.Parameters.AddWithValue("@TC", "");
            cmd.Parameters.AddWithValue("@customerName", "");
            cmd.Parameters.AddWithValue("@customerPhone", "");
            cmd.Parameters.AddWithValue("@customerAdress", "");
            cmd.Parameters.Add("@Order", SqlDbType.NVarChar, 200);
            cmd.Parameters.AddWithValue("@Price", labelTutar2.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

            for (int i = 0; i < textboxTC.Items.Count; i++)
            {
                cmd.Parameters["@TC"].Value = textboxTC.Items[i].ToString();
            }

            for (int i = 0; i < textboxName.Items.Count; i++)
            {
                cmd.Parameters["@customerName"].Value = textboxName.Items[i].ToString();
            }

            for (int i = 0; i < textboxPhone.Items.Count; i++)
            {
                cmd.Parameters["@customerPhone"].Value = textboxPhone.Items[i].ToString();
            }

            for (int i = 0; i < textboxAdress.Items.Count; i++)
            {
                cmd.Parameters["@customerAdress"].Value = textboxAdress.Items[i].ToString();
            }

            order = textboxOrder.Items.Cast<string>().Aggregate("| ", (q, x) => x + " | " + q.ToString());
            cmd.Parameters["@Order"].Value = order.ToString();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Siparişiniz Başarıyla Tamamlandı.");

            CustomerForm cf = new CustomerForm();
            this.Hide();
            cf.ShowDialog();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            this.Hide();
            cf.ShowDialog();
        }
    }
}
