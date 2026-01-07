namespace UcakRezervasyonOtomasyon
{
    partial class FormGiriş
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
            this.linkLabelHesapOluşturma = new System.Windows.Forms.LinkLabel();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.textEditParola = new DevExpress.XtraEditors.TextEdit();
            this.textEditKullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelHesapOluşturma);
            this.panel1.Controls.Add(this.simpleButtonLogin);
            this.panel1.Controls.Add(this.textEditParola);
            this.panel1.Controls.Add(this.textEditKullanıcıAdı);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 413);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelHesapOluşturma
            // 
            this.linkLabelHesapOluşturma.AutoSize = true;
            this.linkLabelHesapOluşturma.Location = new System.Drawing.Point(912, 340);
            this.linkLabelHesapOluşturma.Name = "linkLabelHesapOluşturma";
            this.linkLabelHesapOluşturma.Size = new System.Drawing.Size(133, 13);
            this.linkLabelHesapOluşturma.TabIndex = 11;
            this.linkLabelHesapOluşturma.TabStop = true;
            this.linkLabelHesapOluşturma.Text = "Hesap oluşturmak için tıkla";
            this.linkLabelHesapOluşturma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHesapOluşturma_LinkClicked);
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonLogin.Appearance.Options.UseFont = true;
            this.simpleButtonLogin.Location = new System.Drawing.Point(839, 260);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(206, 46);
            this.simpleButtonLogin.TabIndex = 10;
            this.simpleButtonLogin.Text = "Giriş Yap";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // textEditParola
            // 
            this.textEditParola.EditValue = "Parola";
            this.textEditParola.Location = new System.Drawing.Point(839, 184);
            this.textEditParola.Name = "textEditParola";
            this.textEditParola.Size = new System.Drawing.Size(206, 20);
            this.textEditParola.TabIndex = 9;
            // 
            // textEditKullanıcıAdı
            // 
            this.textEditKullanıcıAdı.EditValue = "Kullanıcı Adı & E-posta ";
            this.textEditKullanıcıAdı.Location = new System.Drawing.Point(839, 124);
            this.textEditKullanıcıAdı.Name = "textEditKullanıcıAdı";
            this.textEditKullanıcıAdı.Size = new System.Drawing.Size(206, 20);
            this.textEditKullanıcıAdı.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(907, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 409);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 411);
            this.Controls.Add(this.panel1);
            this.Name = "FormGiriş";
            this.Text = "FormGiriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelHesapOluşturma;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraEditors.TextEdit textEditParola;
        private DevExpress.XtraEditors.TextEdit textEditKullanıcıAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}