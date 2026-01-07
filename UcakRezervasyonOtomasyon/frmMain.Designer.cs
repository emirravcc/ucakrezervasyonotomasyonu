namespace UcakRezervasyonOtomasyon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.containeryeni = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementAnaSayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementUçuşDeneyimi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.y = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.H = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementKişiselBilgiler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementBiletlerim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementUçuşYönetimi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementDeneyimRaporları = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl2 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // containeryeni
            // 
            resources.ApplyResources(this.containeryeni, "containeryeni");
            this.containeryeni.Name = "containeryeni";
            this.containeryeni.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // accordionControl2
            // 
            resources.ApplyResources(this.accordionControl2, "accordionControl2");
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementAnaSayfa,
            this.H,
            this.accordionControlElement7});
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.OptionsMinimizing.NormalWidth = 120;
            this.accordionControl2.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl2.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementAnaSayfa
            // 
            this.accordionControlElementAnaSayfa.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.y,
            this.accordionControlElement6,
            this.accordionControlElementUçuşDeneyimi});
            this.accordionControlElementAnaSayfa.Expanded = true;
            this.accordionControlElementAnaSayfa.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElementAnaSayfa.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.anasayfayeni;
            this.accordionControlElementAnaSayfa.Name = "accordionControlElementAnaSayfa";
            resources.ApplyResources(this.accordionControlElementAnaSayfa, "accordionControlElementAnaSayfa");
            this.accordionControlElementAnaSayfa.Click += new System.EventHandler(this.accordionControlElementAnaSayfa_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_info_30;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement6, "accordionControlElement6");
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // accordionControlElementUçuşDeneyimi
            // 
            this.accordionControlElementUçuşDeneyimi.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_pencil_30;
            this.accordionControlElementUçuşDeneyimi.Name = "accordionControlElementUçuşDeneyimi";
            this.accordionControlElementUçuşDeneyimi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElementUçuşDeneyimi, "accordionControlElementUçuşDeneyimi");
            this.accordionControlElementUçuşDeneyimi.Click += new System.EventHandler(this.accordionControlElementUçuşDeneyimi_Click);
            // 
            // y
            // 
            this.y.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.y.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_money_30;
            this.y.Name = "y";
            this.y.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.y, "y");
            this.y.Click += new System.EventHandler(this.y_Click);
            // 
            // H
            // 
            this.H.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementKişiselBilgiler,
            this.accordionControlElementBiletlerim});
            this.H.Expanded = true;
            this.H.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.hesap;
            this.H.Name = "H";
            resources.ApplyResources(this.H, "H");
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // accordionControlElementKişiselBilgiler
            // 
            this.accordionControlElementKişiselBilgiler.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_information_30;
            this.accordionControlElementKişiselBilgiler.Name = "accordionControlElementKişiselBilgiler";
            this.accordionControlElementKişiselBilgiler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElementKişiselBilgiler, "accordionControlElementKişiselBilgiler");
            this.accordionControlElementKişiselBilgiler.Click += new System.EventHandler(this.accordionControlElementKişiselBilgiler_Click);
            // 
            // accordionControlElementBiletlerim
            // 
            this.accordionControlElementBiletlerim.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_ticket_30;
            this.accordionControlElementBiletlerim.Name = "accordionControlElementBiletlerim";
            this.accordionControlElementBiletlerim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElementBiletlerim, "accordionControlElementBiletlerim");
            this.accordionControlElementBiletlerim.Click += new System.EventHandler(this.accordionControlElementBiletlerim_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementUçuşYönetimi,
            this.accordionControlElement8,
            this.accordionControlElementDeneyimRaporları});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.admin;
            this.accordionControlElement7.Name = "accordionControlElement7";
            resources.ApplyResources(this.accordionControlElement7, "accordionControlElement7");
            // 
            // accordionControlElementUçuşYönetimi
            // 
            this.accordionControlElementUçuşYönetimi.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_plane_30;
            this.accordionControlElementUçuşYönetimi.Name = "accordionControlElementUçuşYönetimi";
            this.accordionControlElementUçuşYönetimi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElementUçuşYönetimi, "accordionControlElementUçuşYönetimi");
            this.accordionControlElementUçuşYönetimi.Click += new System.EventHandler(this.accordionControlElementUçuşYönetimi_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_user_settings_30;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement8, "accordionControlElement8");
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElementDeneyimRaporları
            // 
            this.accordionControlElementDeneyimRaporları.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_report_30;
            this.accordionControlElementDeneyimRaporları.Name = "accordionControlElementDeneyimRaporları";
            this.accordionControlElementDeneyimRaporları.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElementDeneyimRaporları, "accordionControlElementDeneyimRaporları");
            this.accordionControlElementDeneyimRaporları.Click += new System.EventHandler(this.accordionControlElementDeneyimRaporları_Click);
            // 
            // fluentDesignFormControl2
            // 
            resources.ApplyResources(this.fluentDesignFormControl2, "fluentDesignFormControl2");
            this.fluentDesignFormControl2.FluentDesignForm = this;
            this.fluentDesignFormControl2.Name = "fluentDesignFormControl2";
            this.fluentDesignFormControl2.TabStop = false;
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement5, "accordionControlElement5");
            this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement9.ImageOptions.Image = global::UcakRezervasyonOtomasyon.Properties.Resources.icons8_report_30;
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement9, "accordionControlElement9");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.ControlContainer = this.containeryeni;
            this.Controls.Add(this.containeryeni);
            this.Controls.Add(this.accordionControl2);
            this.Controls.Add(this.fluentDesignFormControl2);
            this.FluentDesignFormControl = this.fluentDesignFormControl2;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl2;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceBiletSatınAl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSeheyatBilgilendirme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSeheyatDeneyim;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBilgiGüncelleme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer containeryeni;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAnaSayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementUçuşDeneyimi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement H;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementKişiselBilgiler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementUçuşYönetimi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBiletlerim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDeneyimRaporları;
        private DevExpress.XtraBars.Navigation.AccordionControlElement y;
    }
}