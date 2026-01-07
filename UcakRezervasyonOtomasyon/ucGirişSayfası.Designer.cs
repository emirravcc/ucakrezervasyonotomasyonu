namespace UcakRezervasyonOtomasyon
{
    partial class ucGirişSayfası
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textEditKullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.textEditParola = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.linkLabelHesapOluşturma = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(901, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş";
            // 
            // textEditKullanıcıAdı
            // 
            this.textEditKullanıcıAdı.EditValue = "";
            this.textEditKullanıcıAdı.Location = new System.Drawing.Point(839, 121);
            this.textEditKullanıcıAdı.Name = "textEditKullanıcıAdı";
            this.textEditKullanıcıAdı.Size = new System.Drawing.Size(206, 20);
            this.textEditKullanıcıAdı.TabIndex = 2;
            // 
            // textEditParola
            // 
            this.textEditParola.EditValue = "";
            this.textEditParola.Location = new System.Drawing.Point(839, 181);
            this.textEditParola.Name = "textEditParola";
            this.textEditParola.Properties.UseSystemPasswordChar = true;
            this.textEditParola.Size = new System.Drawing.Size(206, 20);
            this.textEditParola.TabIndex = 3;
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonLogin.Appearance.Options.UseFont = true;
            this.simpleButtonLogin.Location = new System.Drawing.Point(839, 257);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(206, 46);
            this.simpleButtonLogin.TabIndex = 4;
            this.simpleButtonLogin.Text = "Giriş Yap";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // linkLabelHesapOluşturma
            // 
            this.linkLabelHesapOluşturma.AutoSize = true;
            this.linkLabelHesapOluşturma.Location = new System.Drawing.Point(836, 331);
            this.linkLabelHesapOluşturma.Name = "linkLabelHesapOluşturma";
            this.linkLabelHesapOluşturma.Size = new System.Drawing.Size(133, 13);
            this.linkLabelHesapOluşturma.TabIndex = 5;
            this.linkLabelHesapOluşturma.TabStop = true;
            this.linkLabelHesapOluşturma.Text = "Hesap oluşturmak için tıkla";
            this.linkLabelHesapOluşturma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHesapOluşturma_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(695, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(696, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parola";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_password_30;
            this.pictureBox3.Location = new System.Drawing.Point(1064, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_username_30;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 409);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucGirişSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 370);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelHesapOluşturma);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.textEditParola);
            this.Controls.Add(this.textEditKullanıcıAdı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucGirişSayfası";
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditKullanıcıAdı;
        private DevExpress.XtraEditors.TextEdit textEditParola;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private System.Windows.Forms.LinkLabel linkLabelHesapOluşturma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
