namespace UcakRezervasyonOtomasyon
{
    partial class ÖdemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖdemeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEditKartNumarası = new DevExpress.XtraEditors.TextEdit();
            this.textEditSonKullanmaTarihi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditCVC2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButtonÖdemeYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKartNumarası.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSonKullanmaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCVC2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(391, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart Numarası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 321);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textEditKartNumarası
            // 
            this.textEditKartNumarası.Location = new System.Drawing.Point(396, 407);
            this.textEditKartNumarası.Name = "textEditKartNumarası";
            this.textEditKartNumarası.Size = new System.Drawing.Size(383, 20);
            this.textEditKartNumarası.TabIndex = 5;
            // 
            // textEditSonKullanmaTarihi
            // 
            this.textEditSonKullanmaTarihi.Location = new System.Drawing.Point(396, 518);
            this.textEditSonKullanmaTarihi.Name = "textEditSonKullanmaTarihi";
            this.textEditSonKullanmaTarihi.Size = new System.Drawing.Size(163, 20);
            this.textEditSonKullanmaTarihi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(391, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Son Kullanma Tarihi";
            // 
            // textEditCVC2
            // 
            this.textEditCVC2.Location = new System.Drawing.Point(616, 518);
            this.textEditCVC2.Name = "textEditCVC2";
            this.textEditCVC2.Size = new System.Drawing.Size(163, 20);
            this.textEditCVC2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(611, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CVC2";
            // 
            // simpleButtonÖdemeYap
            // 
            this.simpleButtonÖdemeYap.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonÖdemeYap.Appearance.Options.UseFont = true;
            this.simpleButtonÖdemeYap.Location = new System.Drawing.Point(443, 598);
            this.simpleButtonÖdemeYap.Name = "simpleButtonÖdemeYap";
            this.simpleButtonÖdemeYap.Size = new System.Drawing.Size(283, 80);
            this.simpleButtonÖdemeYap.TabIndex = 10;
            this.simpleButtonÖdemeYap.Text = "Ödeme Yap (750 TL)";
            this.simpleButtonÖdemeYap.Click += new System.EventHandler(this.simpleButtonÖdemeYap_Click);
            // 
            // ÖdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1172, 753);
            this.Controls.Add(this.simpleButtonÖdemeYap);
            this.Controls.Add(this.textEditCVC2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditSonKullanmaTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditKartNumarası);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ÖdemeForm";
            this.Text = "ÖdemeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKartNumarası.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSonKullanmaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCVC2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit textEditKartNumarası;
        private DevExpress.XtraEditors.TextEdit textEditSonKullanmaTarihi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditCVC2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonÖdemeYap;
    }
}