namespace YazilimBakimi.KitapSatisUygulamasi
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lblPasswordSignUp = new System.Windows.Forms.Label();
            this.lblUserNameSignUp = new System.Windows.Forms.Label();
            this.btnLoginSignUp = new System.Windows.Forms.Button();
            this.textBoxPasswordSignUp = new System.Windows.Forms.TextBox();
            this.textBoxNameSignUp = new System.Windows.Forms.TextBox();
            this.pictureBoxBackSignUp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPasswordSignUp
            // 
            this.lblPasswordSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.lblPasswordSignUp.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordSignUp.Location = new System.Drawing.Point(36, 150);
            this.lblPasswordSignUp.Name = "lblPasswordSignUp";
            this.lblPasswordSignUp.Size = new System.Drawing.Size(109, 28);
            this.lblPasswordSignUp.TabIndex = 10;
            this.lblPasswordSignUp.Text = "Parola:";
            this.lblPasswordSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserNameSignUp
            // 
            this.lblUserNameSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserNameSignUp.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameSignUp.Location = new System.Drawing.Point(36, 100);
            this.lblUserNameSignUp.Name = "lblUserNameSignUp";
            this.lblUserNameSignUp.Size = new System.Drawing.Size(109, 28);
            this.lblUserNameSignUp.TabIndex = 9;
            this.lblUserNameSignUp.Text = "Kullanıcı Adı:";
            this.lblUserNameSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoginSignUp.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoginSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoginSignUp.Location = new System.Drawing.Point(163, 208);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(194, 36);
            this.btnLoginSignUp.TabIndex = 8;
            this.btnLoginSignUp.Text = "Sign Up";
            this.btnLoginSignUp.UseVisualStyleBackColor = false;
            this.btnLoginSignUp.Click += new System.EventHandler(this.btnLoginSignUp_Click);
            // 
            // textBoxPasswordSignUp
            // 
            this.textBoxPasswordSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPasswordSignUp.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPasswordSignUp.Location = new System.Drawing.Point(163, 149);
            this.textBoxPasswordSignUp.Name = "textBoxPasswordSignUp";
            this.textBoxPasswordSignUp.PasswordChar = '*';
            this.textBoxPasswordSignUp.Size = new System.Drawing.Size(194, 28);
            this.textBoxPasswordSignUp.TabIndex = 7;
            // 
            // textBoxNameSignUp
            // 
            this.textBoxNameSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNameSignUp.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNameSignUp.Location = new System.Drawing.Point(163, 99);
            this.textBoxNameSignUp.Name = "textBoxNameSignUp";
            this.textBoxNameSignUp.Size = new System.Drawing.Size(194, 28);
            this.textBoxNameSignUp.TabIndex = 6;
            // 
            // pictureBoxBackSignUp
            // 
            this.pictureBoxBackSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.BackgroundImage")));
            this.pictureBoxBackSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.Image")));
            this.pictureBoxBackSignUp.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxBackSignUp.Name = "pictureBoxBackSignUp";
            this.pictureBoxBackSignUp.Size = new System.Drawing.Size(41, 38);
            this.pictureBoxBackSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackSignUp.TabIndex = 17;
            this.pictureBoxBackSignUp.TabStop = false;
            this.pictureBoxBackSignUp.Click += new System.EventHandler(this.pictureBoxBackSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBoxBackSignUp);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 55);
            this.panel1.TabIndex = 18;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 288);
            this.Controls.Add(this.lblPasswordSignUp);
            this.Controls.Add(this.lblUserNameSignUp);
            this.Controls.Add(this.btnLoginSignUp);
            this.Controls.Add(this.textBoxPasswordSignUp);
            this.Controls.Add(this.textBoxNameSignUp);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPasswordSignUp;
        private System.Windows.Forms.Label lblUserNameSignUp;
        private System.Windows.Forms.Button btnLoginSignUp;
        private System.Windows.Forms.TextBox textBoxPasswordSignUp;
        private System.Windows.Forms.TextBox textBoxNameSignUp;
        private System.Windows.Forms.PictureBox pictureBoxBackSignUp;
        private System.Windows.Forms.Panel panel1;
    }
}