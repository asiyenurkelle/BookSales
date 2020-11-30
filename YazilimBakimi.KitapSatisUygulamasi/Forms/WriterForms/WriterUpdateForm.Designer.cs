namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class WriterUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterUpdateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBackSignUp = new System.Windows.Forms.PictureBox();
            this.pcHome = new System.Windows.Forms.PictureBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnUpdateWriter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxBackSignUp);
            this.panel1.Controls.Add(this.pcHome);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 45);
            this.panel1.TabIndex = 9;
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
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(14, 91);
            this.txtFullName.MaxLength = 200;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(277, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(14, 151);
            this.txtBirthDate.MaxLength = 20;
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(277, 20);
            this.txtBirthDate.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(14, 199);
            this.txtCountry.MaxLength = 150;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(277, 20);
            this.txtCountry.TabIndex = 3;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(14, 260);
            this.txtGenre.MaxLength = 200;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(277, 20);
            this.txtGenre.TabIndex = 4;
            // 
            // btnUpdateWriter
            // 
            this.btnUpdateWriter.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateWriter.Image")));
            this.btnUpdateWriter.Location = new System.Drawing.Point(14, 308);
            this.btnUpdateWriter.Name = "btnUpdateWriter";
            this.btnUpdateWriter.Size = new System.Drawing.Size(277, 81);
            this.btnUpdateWriter.TabIndex = 5;
            this.btnUpdateWriter.UseVisualStyleBackColor = true;
            this.btnUpdateWriter.Click += new System.EventHandler(this.btnUpdateWriter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tam İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doğum tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Milliyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tür";
            // 
            // WriterUpdateForm
            // 
            this.AcceptButton = this.btnUpdateWriter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateWriter);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel1);
            this.Name = "WriterUpdateForm";
            this.Text = "WriterUpdateForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcHome;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnUpdateWriter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxBackSignUp;
    }
}