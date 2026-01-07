namespace UcakRezervasyonOtomasyon
{
    partial class ucBiletSatınAl
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBiletSatınAl));
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.radioTekYon = new System.Windows.Forms.RadioButton();
            this.radioGidisDonus = new System.Windows.Forms.RadioButton();
            this.labelNereden = new System.Windows.Forms.Label();
            this.comboNereden = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboNereye = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelNereye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDönüşTarihi = new System.Windows.Forms.Label();
            this.simpleButtonSeferKontrol = new DevExpress.XtraEditors.SimpleButton();
            this.labelAktifSeferler = new System.Windows.Forms.Label();
            this.checkedListAktifSeferler = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.dateGidiş = new DevExpress.XtraEditors.DateEdit();
            this.dateDönüş = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.Ankara = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.Elazığ = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboNereden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNereye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListAktifSeferler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGidiş.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGidiş.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDönüş.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDönüş.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioTekYon
            // 
            this.radioTekYon.AutoSize = true;
            this.radioTekYon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTekYon.Location = new System.Drawing.Point(168, 268);
            this.radioTekYon.Name = "radioTekYon";
            this.radioTekYon.Size = new System.Drawing.Size(86, 23);
            this.radioTekYon.TabIndex = 0;
            this.radioTekYon.TabStop = true;
            this.radioTekYon.Text = "Tek Yön";
            this.radioTekYon.UseVisualStyleBackColor = true;
            this.radioTekYon.CheckedChanged += new System.EventHandler(this.radioTekYon_CheckedChanged);
            // 
            // radioGidisDonus
            // 
            this.radioGidisDonus.AutoSize = true;
            this.radioGidisDonus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioGidisDonus.Location = new System.Drawing.Point(168, 308);
            this.radioGidisDonus.Name = "radioGidisDonus";
            this.radioGidisDonus.Size = new System.Drawing.Size(123, 23);
            this.radioGidisDonus.TabIndex = 1;
            this.radioGidisDonus.TabStop = true;
            this.radioGidisDonus.Text = "Gidiş - Dönüş";
            this.radioGidisDonus.UseVisualStyleBackColor = true;
            this.radioGidisDonus.CheckedChanged += new System.EventHandler(this.radioGidisDonus_CheckedChanged);
            // 
            // labelNereden
            // 
            this.labelNereden.AutoSize = true;
            this.labelNereden.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNereden.ForeColor = System.Drawing.Color.DimGray;
            this.labelNereden.Location = new System.Drawing.Point(333, 264);
            this.labelNereden.Name = "labelNereden";
            this.labelNereden.Size = new System.Drawing.Size(85, 25);
            this.labelNereden.TabIndex = 2;
            this.labelNereden.Text = "Nereden";
            // 
            // comboNereden
            // 
            this.comboNereden.EditValue = "İstanbul";
            this.comboNereden.Location = new System.Drawing.Point(337, 308);
            this.comboNereden.Name = "comboNereden";
            this.comboNereden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboNereden.Properties.Sorted = true;
            this.comboNereden.Size = new System.Drawing.Size(109, 20);
            this.comboNereden.TabIndex = 3;
            // 
            // comboNereye
            // 
            this.comboNereye.EditValue = "Ankara";
            this.comboNereye.Location = new System.Drawing.Point(484, 308);
            this.comboNereye.Name = "comboNereye";
            this.comboNereye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboNereye.Properties.Sorted = true;
            this.comboNereye.Size = new System.Drawing.Size(109, 20);
            this.comboNereye.TabIndex = 5;
            // 
            // labelNereye
            // 
            this.labelNereye.AutoSize = true;
            this.labelNereye.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNereye.ForeColor = System.Drawing.Color.DimGray;
            this.labelNereye.Location = new System.Drawing.Point(480, 264);
            this.labelNereye.Name = "labelNereye";
            this.labelNereye.Size = new System.Drawing.Size(72, 25);
            this.labelNereye.TabIndex = 4;
            this.labelNereye.Text = "Nereye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(644, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gidiş Tarihi";
            // 
            // labelDönüşTarihi
            // 
            this.labelDönüşTarihi.AutoSize = true;
            this.labelDönüşTarihi.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDönüşTarihi.ForeColor = System.Drawing.Color.DimGray;
            this.labelDönüşTarihi.Location = new System.Drawing.Point(791, 264);
            this.labelDönüşTarihi.Name = "labelDönüşTarihi";
            this.labelDönüşTarihi.Size = new System.Drawing.Size(120, 25);
            this.labelDönüşTarihi.TabIndex = 9;
            this.labelDönüşTarihi.Text = "Dönüş Tarihi";
            // 
            // simpleButtonSeferKontrol
            // 
            this.simpleButtonSeferKontrol.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonSeferKontrol.Appearance.Options.UseFont = true;
            this.simpleButtonSeferKontrol.Location = new System.Drawing.Point(941, 281);
            this.simpleButtonSeferKontrol.Name = "simpleButtonSeferKontrol";
            this.simpleButtonSeferKontrol.Size = new System.Drawing.Size(132, 46);
            this.simpleButtonSeferKontrol.TabIndex = 10;
            this.simpleButtonSeferKontrol.Text = "Sefer Kontrol";
            this.simpleButtonSeferKontrol.Click += new System.EventHandler(this.simpleButtonSeferKontrol_Click);
            // 
            // labelAktifSeferler
            // 
            this.labelAktifSeferler.AutoSize = true;
            this.labelAktifSeferler.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktifSeferler.ForeColor = System.Drawing.Color.DimGray;
            this.labelAktifSeferler.Location = new System.Drawing.Point(544, 369);
            this.labelAktifSeferler.Name = "labelAktifSeferler";
            this.labelAktifSeferler.Size = new System.Drawing.Size(142, 28);
            this.labelAktifSeferler.TabIndex = 12;
            this.labelAktifSeferler.Text = "Aktif Seferler";
            // 
            // checkedListAktifSeferler
            // 
            this.checkedListAktifSeferler.HorizontalScrollbar = true;
            this.checkedListAktifSeferler.Location = new System.Drawing.Point(168, 359);
            this.checkedListAktifSeferler.Name = "checkedListAktifSeferler";
            this.checkedListAktifSeferler.Size = new System.Drawing.Size(905, 320);
            this.checkedListAktifSeferler.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.checkedListAktifSeferler.TabIndex = 13;
            // 
            // dateGidiş
            // 
            this.dateGidiş.EditValue = null;
            this.dateGidiş.Location = new System.Drawing.Point(648, 307);
            this.dateGidiş.Name = "dateGidiş";
            this.dateGidiş.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGidiş.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGidiş.Size = new System.Drawing.Size(109, 20);
            this.dateGidiş.TabIndex = 14;
            // 
            // dateDönüş
            // 
            this.dateDönüş.EditValue = null;
            this.dateDönüş.Location = new System.Drawing.Point(795, 307);
            this.dateDönüş.Name = "dateDönüş";
            this.dateDönüş.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDönüş.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDönüş.Size = new System.Drawing.Size(109, 20);
            this.dateDönüş.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(549, 751);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 64);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Devam Et";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemPadding = new System.Windows.Forms.Padding(12, 8, 12, 6);
            this.tileBar1.ItemSize = 200;
            this.tileBar1.Location = new System.Drawing.Point(84, 3);
            this.tileBar1.Margin = new System.Windows.Forms.Padding(0, 3, 100, 3);
            this.tileBar1.MaxId = 11;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 7);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1193, 229);
            this.tileBar1.TabIndex = 17;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.WideTileWidth = 150;
            this.tileBar1.Click += new System.EventHandler(this.tileBar1_Click);
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem5);
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.Ankara);
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Items.Add(this.tileBarItem3);
            this.tileBarGroup2.Items.Add(this.Elazığ);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.istanbul;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "İstanbul";
            this.tileBarItem5.Elements.Add(tileItemElement1);
            this.tileBarItem5.Id = 5;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem5.Name = "tileBarItem5";
            this.tileBarItem5.Padding = new System.Windows.Forms.Padding(0);
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "İzmir";
            this.tileBarItem1.Elements.Add(tileItemElement2);
            this.tileBarItem1.Id = 6;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem1.Name = "tileBarItem1";
            this.tileBarItem1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // Ankara
            // 
            this.Ankara.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement3.Text = "Ankara";
            this.Ankara.Elements.Add(tileItemElement3);
            this.Ankara.Id = 8;
            this.Ankara.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.Ankara.Name = "Ankara";
            this.Ankara.Padding = new System.Windows.Forms.Padding(0);
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement4.Text = "İskenderun";
            this.tileBarItem2.Elements.Add(tileItemElement4);
            this.tileBarItem2.Id = 1;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem2.Name = "tileBarItem2";
            this.tileBarItem2.Padding = new System.Windows.Forms.Padding(0);
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None;
            tileItemElement5.Text = "Gaziantep";
            this.tileBarItem3.Elements.Add(tileItemElement5);
            this.tileBarItem3.Id = 2;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tileBarItem3.Name = "tileBarItem3";
            this.tileBarItem3.Padding = new System.Windows.Forms.Padding(0);
            // 
            // Elazığ
            // 
            this.Elazığ.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement6.Text = "Elazığ";
            this.Elazığ.Elements.Add(tileItemElement6);
            this.Elazığ.Id = 9;
            this.Elazığ.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.Elazığ.Name = "Elazığ";
            this.Elazığ.Padding = new System.Windows.Forms.Padding(0);
            // 
            // ucBiletSatınAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dateDönüş);
            this.Controls.Add(this.dateGidiş);
            this.Controls.Add(this.checkedListAktifSeferler);
            this.Controls.Add(this.labelAktifSeferler);
            this.Controls.Add(this.simpleButtonSeferKontrol);
            this.Controls.Add(this.labelDönüşTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNereye);
            this.Controls.Add(this.labelNereye);
            this.Controls.Add(this.comboNereden);
            this.Controls.Add(this.labelNereden);
            this.Controls.Add(this.radioGidisDonus);
            this.Controls.Add(this.radioTekYon);
            this.Name = "ucBiletSatınAl";
            this.Size = new System.Drawing.Size(1350, 885);
            this.Load += new System.EventHandler(this.ucBiletSatınAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboNereden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNereye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListAktifSeferler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGidiş.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGidiş.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDönüş.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDönüş.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTekYon;
        private System.Windows.Forms.RadioButton radioGidisDonus;
        private System.Windows.Forms.Label labelNereden;
        private DevExpress.XtraEditors.ComboBoxEdit comboNereden;
        private DevExpress.XtraEditors.ComboBoxEdit comboNereye;
        private System.Windows.Forms.Label labelNereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDönüşTarihi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSeferKontrol;
        private System.Windows.Forms.Label labelAktifSeferler;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListAktifSeferler;
        private DevExpress.XtraEditors.DateEdit dateGidiş;
        private DevExpress.XtraEditors.DateEdit dateDönüş;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem5;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem Ankara;
        private DevExpress.XtraBars.Navigation.TileBarItem Elazığ;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
