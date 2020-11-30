
namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class BookCreateForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateBack = new System.Windows.Forms.Button();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxWriterName = new System.Windows.Forms.TextBox();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnSendBookCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCreateBack);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(199, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateBack
            // 
            this.btnCreateBack.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.btnCreateBack.Location = new System.Drawing.Point(11, 11);
            this.btnCreateBack.Name = "btnCreateBack";
            this.btnCreateBack.Size = new System.Drawing.Size(34, 33);
            this.btnCreateBack.TabIndex = 0;
            this.btnCreateBack.UseVisualStyleBackColor = true;
            this.btnCreateBack.Click += new System.EventHandler(this.btnCreateBack_Click);
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterName.Location = new System.Drawing.Point(9, 79);
            this.lblWriterName.Name = "lblWriterName";
            this.lblWriterName.Size = new System.Drawing.Size(66, 17);
            this.lblWriterName.TabIndex = 1;
            this.lblWriterName.Text = "Yazar Adı";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(9, 141);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(64, 17);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenre.Location = new System.Drawing.Point(9, 199);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(29, 17);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Tür";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(9, 254);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Fiyat";
            // 
            // txtBoxWriterName
            // 
            this.txtBoxWriterName.Location = new System.Drawing.Point(12, 161);
            this.txtBoxWriterName.Name = "txtBoxWriterName";
            this.txtBoxWriterName.Size = new System.Drawing.Size(279, 20);
            this.txtBoxWriterName.TabIndex = 6;
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Location = new System.Drawing.Point(12, 219);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(279, 20);
            this.txtBoxBookName.TabIndex = 7;
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(12, 274);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(279, 20);
            this.txtBoxGenre.TabIndex = 8;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.Location = new System.Drawing.Point(12, 99);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxPrice.Size = new System.Drawing.Size(279, 20);
            this.txtBoxPrice.TabIndex = 9;
            // 
            // btnSendBookCreate
            // 
            this.btnSendBookCreate.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.btnSendBookCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendBookCreate.Location = new System.Drawing.Point(12, 314);
            this.btnSendBookCreate.Name = "btnSendBookCreate";
            this.btnSendBookCreate.Size = new System.Drawing.Size(279, 75);
            this.btnSendBookCreate.TabIndex = 5;
            this.btnSendBookCreate.UseVisualStyleBackColor = true;
            this.btnSendBookCreate.Click += new System.EventHandler(this.btnSendBookCreate_Click);
            // 
            // BookCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxGenre);
            this.Controls.Add(this.txtBoxBookName);
            this.Controls.Add(this.txtBoxWriterName);
            this.Controls.Add(this.btnSendBookCreate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.panel1);
            this.Name = "BookCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCreateForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateBack;
        private System.Windows.Forms.Label lblWriterName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSendBookCreate;
        private System.Windows.Forms.TextBox txtBoxWriterName;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}