namespace PowerPOS
{
    partial class Main
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.tileNavItem1 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navSale = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.navProduct = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.navCustomer = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navConfig = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navExit = new DevExpress.XtraBars.Navigation.NavButton();
            this.navClaim = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navPurchase = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.navProductReport = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceSelected.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.navExit);
            this.tileNavPane1.ContinuousNavigation = true;
            // 
            // tileNavCategory1
            // 
            // 
            // tileNavItem1
            // 
            this.tileNavItem1.Caption = "สินค้า";
            this.tileNavItem1.Name = "tileNavItem1";
            this.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem1.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavItem1.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            // 
            // navSale
            // 
            this.navSale.Caption = "ขาย";
            this.navSale.Name = "navSale";
            this.navSale.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.navSale.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarItem5
            // 
            this.navSale.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navSale.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navSale.Tile.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.navSale.Tile.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.navSale.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "ขาย";
            this.navSale.Tile.Elements.Add(tileItemElement1);
            this.navSale.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navSale.Tile.Name = "tileBarItem5";
            // 
            // navProduct
            // 
            this.navProduct.Caption = "ข้อมูล";
            this.navProduct.Name = "navProduct";
            this.navProduct.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            // 
            // tileBarItem6
            // 
            this.navProduct.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navProduct.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navProduct.Tile.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.navProduct.Tile.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.navProduct.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "ข้อมูล";
            this.navProduct.Tile.Elements.Add(tileItemElement2);
            this.navProduct.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navProduct.Tile.Name = "tileBarItem6";
            this.tileNavItem1.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.navSale,
            this.navProduct,
            this.navPurchase,
            this.navProductReport});
            // 
            // tileBarItem1
            // 
            this.tileNavItem1.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavItem1.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "สินค้า";
            this.tileNavItem1.Tile.Elements.Add(tileItemElement5);
            this.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem1.Tile.Name = "tileBarItem1";
            this.tileNavItem1.Tile.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem1.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // navCustomer
            // 
            this.navCustomer.Caption = "ลูกค้า";
            this.navCustomer.Name = "navCustomer";
            this.navCustomer.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.navCustomer.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            // 
            // tileBarItem2
            // 
            this.navCustomer.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navCustomer.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navCustomer.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "ลูกค้า";
            this.navCustomer.Tile.Elements.Add(tileItemElement6);
            this.navCustomer.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navCustomer.Tile.Name = "tileBarItem2";
            this.navCustomer.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // navConfig
            // 
            this.navConfig.Caption = "การตั้งค่า";
            this.navConfig.Name = "navConfig";
            this.navConfig.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.navConfig.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            // 
            // tileBarItem4
            // 
            this.navConfig.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navConfig.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navConfig.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement8.Image")));
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement8.Text = "การตั้งค่า";
            this.navConfig.Tile.Elements.Add(tileItemElement8);
            this.navConfig.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navConfig.Tile.Name = "tileBarItem4";
            this.navConfig.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavPane1.DefaultCategory.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem1,
            this.navCustomer,
            this.navClaim,
            this.navConfig});
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(847, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            this.tileNavPane1.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tileNavPane1_TileClick);
            // 
            // navButton2
            // 
            this.navButton2.Caption = "เมนูหลัก";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // navExit
            // 
            this.navExit.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navExit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navExit.Caption = "ออกจากระบบ";
            this.navExit.Glyph = ((System.Drawing.Image)(resources.GetObject("navExit.Glyph")));
            this.navExit.Name = "navExit";
            this.navExit.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navExit_ElementClick);
            // 
            // navClaim
            // 
            this.navClaim.Caption = "เครม";
            this.navClaim.Name = "navClaim";
            this.navClaim.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.navClaim.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            // 
            // tileBarItem3
            // 
            this.navClaim.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navClaim.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navClaim.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement7.Image")));
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement7.Text = "เครม";
            this.navClaim.Tile.Elements.Add(tileItemElement7);
            this.navClaim.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navClaim.Tile.Name = "tileBarItem3";
            this.navClaim.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // navPurchase
            // 
            this.navPurchase.Caption = "สั่งซื้อ";
            this.navPurchase.Name = "navPurchase";
            this.navPurchase.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            // 
            // tileBarItem7
            // 
            this.navPurchase.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navPurchase.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navPurchase.Tile.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.navPurchase.Tile.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.navPurchase.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "สั่งซื้อ";
            this.navPurchase.Tile.Elements.Add(tileItemElement3);
            this.navPurchase.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navPurchase.Tile.Name = "tileBarItem7";
            // 
            // navProductReport
            // 
            this.navProductReport.Caption = "รายงาน";
            this.navProductReport.Name = "navProductReport";
            this.navProductReport.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            // 
            // tileBarItem8
            // 
            this.navProductReport.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.navProductReport.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.navProductReport.Tile.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.navProductReport.Tile.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.navProductReport.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "รายงาน";
            this.navProductReport.Tile.Elements.Add(tileItemElement4);
            this.navProductReport.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.navProductReport.Tile.Name = "tileBarItem8";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(847, 351);
            this.panelMain.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 391);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tileNavPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navExit;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem1;
        private DevExpress.XtraBars.Navigation.TileNavSubItem navPurchase;
        private DevExpress.XtraBars.Navigation.TileNavSubItem navProductReport;
        private DevExpress.XtraBars.Navigation.TileNavItem navClaim;
        private DevExpress.XtraBars.Navigation.TileNavItem navConfig;
        private DevExpress.XtraBars.Navigation.TileNavSubItem navProduct;
        private DevExpress.XtraBars.Navigation.TileNavSubItem navSale;
        private DevExpress.XtraBars.Navigation.TileNavItem navCustomer;
        private DevExpress.XtraEditors.PanelControl panelMain;
    }
}