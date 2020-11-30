using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Classes;
using YazilimBakimi.KitapSatisUygulamasi.EntityClasses;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class SalesCRUD : Form
    {
        ToolTip toolTip = new ToolTip();
        private List<Sale> Sales;

        private BindingSource bindingSource { get; set; } = new BindingSource();

        public SalesCRUD()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnSaleUpdate, "Update");
            toolTip.SetToolTip(btnSaleDelete, "Delete");
        }

        private void SalesCRUD_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapSatisDataSet6.tblSales' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSalesTableAdapter2.Fill(this.kitapSatisDataSet6.tblSales);
            // TODO: Bu kod satırı 'kitapSatisDataSet5.tblSales' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSalesTableAdapter1.Fill(this.kitapSatisDataSet5.tblSales);

            this.tblSalesTableAdapter.Fill(this.kitapSatisDataSet4.tblSales);
            Sales = DbSale.GetSales();
            bindingSource.DataSource = Sales;
            gridViewSale.DataSource = bindingSource;
        }

        private void backToSignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm("");
            homeForm.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSaleUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selecetedSale = gridViewSale.SelectedRows[0].DataBoundItem as Sale;

            }
            catch
            {
                MessageBox.Show(this, "Bir Satış Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SwitchPages(BookUpdateForm bookUpdateForm)
        {
            throw new NotImplementedException();
        }

        private void btnSaleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Sale selectedSale = gridViewSale.SelectedRows[0].DataBoundItem as Sale;
                if (selectedSale == null) throw new Exception();

                bool deleteSuccessful = DbSale.DeleteSale(selectedSale.TC);
                if (deleteSuccessful)
                {
                    MessageBox.Show(this, "Silme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewSale.Rows.RemoveAt(gridViewSale.SelectedRows[0].Index);
                }
                else
                    MessageBox.Show(this, "Silme işleminde bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show(this, "Bir satış seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
