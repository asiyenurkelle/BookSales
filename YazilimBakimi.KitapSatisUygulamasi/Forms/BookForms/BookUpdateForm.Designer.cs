
namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class BookUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_BookUpdate = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxWriterName = new System.Windows.Forms.TextBox();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pb_BookUpdate);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 61);
            this.panel1.TabIndex = 0;
            // 
            // pb_BookUpdate
            // 
            this.pb_BookUpdate.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.pb_BookUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_BookUpdate.Location = new System.Drawing.Point(200, 8);
            this.pb_BookUpdate.Name = "pb_BookUpdate";
            this.pb_BookUpdate.Size = new System.Drawing.Size(100, 50);
            this.pb_BookUpdate.TabIndex = 1;
            this.pb_BookUpdate.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(9, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterName.Location = new System.Drawing.Point(9, 85);
            this.lblWriterName.Name = "lblWriterName";
            this.lblWriterName.Size = new System.Drawing.Size(66, 17);
            this.lblWriterName.TabIndex = 1;
            this.lblWriterName.Text = "Yazar Adı";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(7, 141);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(64, 17);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenre.Location = new System.Drawing.Point(9, 200);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(29, 17);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Tür";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(9, 255);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Fiyat";
            // 
            // txtBoxWriterName
            // 
            this.txtBoxWriterName.Location = new System.Drawing.Point(10, 105);
            this.txtBoxWriterName.Name = "txtBoxWriterName";
            this.txtBoxWriterName.Size = new System.Drawing.Size(281, 20);
            this.txtBoxWriterName.TabIndex = 5;
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Location = new System.Drawing.Point(10, 161);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(281, 20);
            this.txtBoxBookName.TabIndex = 6;
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(10, 220);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(281, 20);
            this.txtBoxGenre.TabIndex = 7;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(10, 275);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(281, 20);
            this.txtBoxPrice.TabIndex = 8;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.btnUpdateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateBook.Location = new System.Drawing.Point(10, 321);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(281, 68);
            this.btnUpdateBook.TabIndex = 9;
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // BookUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxGenre);
            this.Controls.Add(this.txtBoxBookName);
            this.Controls.Add(this.txtBoxWriterName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.panel1);
            this.Name = "BookUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookUpdateForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWriterName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxWriterName;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.PictureBox pb_BookUpdate;
    }
}