namespace UcakRezervasyonOtomasyon
{
    partial class ucKullanıcıYönetimi
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
            this.checkedListBoxControlKullanıcılar = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButtonKullanıcıSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlKullanıcılar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(562, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Yönetimi";
            // 
            // checkedListBoxControlKullanıcılar
            // 
            this.checkedListBoxControlKullanıcılar.Location = new System.Drawing.Point(198, 192);
            this.checkedListBoxControlKullanıcılar.Name = "checkedListBoxControlKullanıcılar";
            this.checkedListBoxControlKullanıcılar.Size = new System.Drawing.Size(941, 403);
            this.checkedListBoxControlKullanıcılar.TabIndex = 1;
            // 
            // simpleButtonKullanıcıSil
            // 
            this.simpleButtonKullanıcıSil.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonKullanıcıSil.Appearance.Options.UseFont = true;
            this.simpleButtonKullanıcıSil.Location = new System.Drawing.Point(625, 686);
            this.simpleButtonKullanıcıSil.Name = "simpleButtonKullanıcıSil";
            this.simpleButtonKullanıcıSil.Size = new System.Drawing.Size(173, 64);
            this.simpleButtonKullanıcıSil.TabIndex = 2;
            this.simpleButtonKullanıcıSil.Text = "Kullanıcı Sil";
            this.simpleButtonKullanıcıSil.Click += new System.EventHandler(this.simpleButtonKullanıcıSil_Click);
            // 
            // ucKullanıcıYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButtonKullanıcıSil);
            this.Controls.Add(this.checkedListBoxControlKullanıcılar);
            this.Controls.Add(this.label1);
            this.Name = "ucKullanıcıYönetimi";
            this.Size = new System.Drawing.Size(1350, 875);
            this.Load += new System.EventHandler(this.ucKullanıcıYönetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlKullanıcılar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlKullanıcılar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKullanıcıSil;
    }
}
