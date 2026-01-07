namespace UcakRezervasyonOtomasyon
{
    partial class ucSeferEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonGidiş = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateEditSeferGidiş = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDönüş = new DevExpress.XtraEditors.DateEdit();
            this.buttonSeferEkle = new System.Windows.Forms.Button();
            this.checkedListBoxControlSeferListesi = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSeferSil = new System.Windows.Forms.Button();
            this.comboBoxEditSeferNereden = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditSeferNereye = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSeferGidiş.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSeferGidiş.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDönüş.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDönüş.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlSeferListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeferNereden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeferNereye.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(494, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Düzenleyicisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(342, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(706, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nereye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(342, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sefer Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(342, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sefer Zamanı";
            // 
            // radioButtonGidiş
            // 
            this.radioButtonGidiş.AutoSize = true;
            this.radioButtonGidiş.Checked = true;
            this.radioButtonGidiş.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonGidiş.Location = new System.Drawing.Point(482, 139);
            this.radioButtonGidiş.Name = "radioButtonGidiş";
            this.radioButtonGidiş.Size = new System.Drawing.Size(76, 27);
            this.radioButtonGidiş.TabIndex = 7;
            this.radioButtonGidiş.TabStop = true;
            this.radioButtonGidiş.Text = "Gidiş";
            this.radioButtonGidiş.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(589, 139);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 27);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Gidiş / Dönüş";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateEditSeferGidiş
            // 
            this.dateEditSeferGidiş.EditValue = null;
            this.dateEditSeferGidiş.Location = new System.Drawing.Point(482, 264);
            this.dateEditSeferGidiş.Name = "dateEditSeferGidiş";
            this.dateEditSeferGidiş.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSeferGidiş.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSeferGidiş.Size = new System.Drawing.Size(115, 20);
            this.dateEditSeferGidiş.TabIndex = 9;
            // 
            // dateEditDönüş
            // 
            this.dateEditDönüş.EditValue = null;
            this.dateEditDönüş.Location = new System.Drawing.Point(679, 264);
            this.dateEditDönüş.Name = "dateEditDönüş";
            this.dateEditDönüş.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDönüş.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDönüş.Size = new System.Drawing.Size(115, 20);
            this.dateEditDönüş.TabIndex = 10;
            // 
            // buttonSeferEkle
            // 
            this.buttonSeferEkle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferEkle.Location = new System.Drawing.Point(383, 756);
            this.buttonSeferEkle.Name = "buttonSeferEkle";
            this.buttonSeferEkle.Size = new System.Drawing.Size(214, 42);
            this.buttonSeferEkle.TabIndex = 11;
            this.buttonSeferEkle.Text = "Sefer Ekle";
            this.buttonSeferEkle.UseVisualStyleBackColor = true;
            this.buttonSeferEkle.Click += new System.EventHandler(this.buttonSeferEkle_Click);
            // 
            // checkedListBoxControlSeferListesi
            // 
            this.checkedListBoxControlSeferListesi.Location = new System.Drawing.Point(97, 316);
            this.checkedListBoxControlSeferListesi.Name = "checkedListBoxControlSeferListesi";
            this.checkedListBoxControlSeferListesi.Size = new System.Drawing.Size(1125, 386);
            this.checkedListBoxControlSeferListesi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(479, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gidiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(676, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dönüş Tarihi";
            // 
            // buttonSeferSil
            // 
            this.buttonSeferSil.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferSil.Location = new System.Drawing.Point(765, 756);
            this.buttonSeferSil.Name = "buttonSeferSil";
            this.buttonSeferSil.Size = new System.Drawing.Size(214, 42);
            this.buttonSeferSil.TabIndex = 17;
            this.buttonSeferSil.Text = "Sefer Sil";
            this.buttonSeferSil.UseVisualStyleBackColor = true;
            this.buttonSeferSil.Click += new System.EventHandler(this.buttonSeferSil_Click);
            // 
            // comboBoxEditSeferNereden
            // 
            this.comboBoxEditSeferNereden.Location = new System.Drawing.Point(482, 97);
            this.comboBoxEditSeferNereden.Name = "comboBoxEditSeferNereden";
            this.comboBoxEditSeferNereden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSeferNereden.Size = new System.Drawing.Size(143, 20);
            this.comboBoxEditSeferNereden.TabIndex = 18;
            // 
            // comboBoxEditSeferNereye
            // 
            this.comboBoxEditSeferNereye.Location = new System.Drawing.Point(836, 99);
            this.comboBoxEditSeferNereye.Name = "comboBoxEditSeferNereye";
            this.comboBoxEditSeferNereye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSeferNereye.Size = new System.Drawing.Size(143, 20);
            this.comboBoxEditSeferNereye.TabIndex = 19;
            // 
            // ucSeferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxEditSeferNereye);
            this.Controls.Add(this.comboBoxEditSeferNereden);
            this.Controls.Add(this.buttonSeferSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBoxControlSeferListesi);
            this.Controls.Add(this.buttonSeferEkle);
            this.Controls.Add(this.dateEditDönüş);
            this.Controls.Add(this.dateEditSeferGidiş);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButtonGidiş);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucSeferEkle";
            this.Size = new System.Drawing.Size(1300, 885);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSeferGidiş.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSeferGidiş.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDönüş.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDönüş.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlSeferListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeferNereden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeferNereye.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonGidiş;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.DateEdit dateEditSeferGidiş;
        private DevExpress.XtraEditors.DateEdit dateEditDönüş;
        private System.Windows.Forms.Button buttonSeferEkle;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlSeferListesi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSeferSil;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSeferNereden;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSeferNereye;
    }
}
