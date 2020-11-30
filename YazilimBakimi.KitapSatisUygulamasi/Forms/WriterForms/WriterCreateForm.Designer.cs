namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class WriterCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterCreateForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateWriter = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBackSignUp = new System.Windows.Forms.PictureBox();
            this.pcHome = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Milliyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Doğum tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tam İsim";
            // 
            // btnCreateWriter
            // 
            this.btnCreateWriter.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateWriter.Image")));
            this.btnCreateWriter.Location = new System.Drawing.Point(13, 314);
            this.btnCreateWriter.Name = "btnCreateWriter";
            this.btnCreateWriter.Size = new System.Drawing.Size(277, 81);
            this.btnCreateWriter.TabIndex = 23;
            this.btnCreateWriter.UseVisualStyleBackColor = true;
            this.btnCreateWriter.Click += new System.EventHandler(this.btnCreateWriter_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(13, 266);
            this.txtGenre.MaxLength = 200;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(277, 20);
            this.txtGenre.TabIndex = 22;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(13, 205);
            this.txtCountry.MaxLength = 150;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(277, 20);
            this.txtCountry.TabIndex = 21;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(13, 157);
            this.txtBirthDate.MaxLength = 20;
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(277, 20);
            this.txtBirthDate.TabIndex = 20;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(13, 97);
            this.txtFullName.MaxLength = 200;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(277, 20);
            this.txtFullName.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxBackSignUp);
            this.panel1.Controls.Add(this.pcHome);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 45);
            this.panel1.TabIndex = 24;
            // 
            // pictureBoxBackSignUp
            // 
            this.pictureBoxBackSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.BackgroundImage")));
            this.pictureBoxBackSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.Image")));
            this.pictureBoxBackSignUp.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxBackSignUp.Name = "pictureBoxBackSignUp";
            this.pictureBoxBackSignUp.Size = new System.Drawing.Size(34, 33);
            this.pictureBoxBackSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackSignUp.TabIndex = 19;
            this.pictureBoxBackSignUp.TabStop = false;
            this.pictureBoxBackSignUp.Click += new System.EventHandler(this.pictureBoxBackSignUp_Click);
            // 
            // pcHome
            // 
            this.pcHome.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.writerBig;
            this.pcHome.Location = new System.Drawing.Point(143, 4);
            this.pcHome.Name = "pcHome";
            this.pcHome.Size = new System.Drawing.Size(156, 38);
            this.pcHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHome.TabIndex = 2;
            this.pcHome.TabStop = false;
            // 
            // WriterCreateForm
            // 
            this.AcceptButton = this.btnCreateWriter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateWriter);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel1);
            this.Name = "WriterCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriterCreateForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateWriter;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBackSignUp;
        private System.Windows.Forms.PictureBox pcHome;
    }
}