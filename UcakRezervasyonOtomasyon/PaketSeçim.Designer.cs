namespace UcakRezervasyonOtomasyon
{
    partial class PaketSeçim
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaketSeçim));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.süperEko = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.avantaj = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.comfortflex = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Location = new System.Drawing.Point(35, 29);
            this.tileControl1.MaxId = 7;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(927, 272);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.süperEko);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // süperEko
            // 
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement4.Text = "";
            this.süperEko.Elements.Add(tileItemElement4);
            this.süperEko.Id = 2;
            this.süperEko.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.süperEko.Name = "süperEko";
            this.süperEko.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.süperEko_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.avantaj);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // avantaj
            // 
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement5.Text = "";
            this.avantaj.Elements.Add(tileItemElement5);
            this.avantaj.Id = 5;
            this.avantaj.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.avantaj.Name = "avantaj";
            this.avantaj.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.avantaj_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.comfortflex);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // comfortflex
            // 
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement6.Text = "";
            this.comfortflex.Elements.Add(tileItemElement6);
            this.comfortflex.Id = 6;
            this.comfortflex.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.comfortflex.Name = "comfortflex";
            this.comfortflex.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.comfortflex_ItemClick);
            // 
            // PaketSeçim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 336);
            this.Controls.Add(this.tileControl1);
            this.Name = "PaketSeçim";
            this.Text = "PaketSeçim";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem süperEko;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem avantaj;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem comfortflex;
    }
}