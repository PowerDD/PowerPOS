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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSale = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveroduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaleReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGallery = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaleReportByCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurchaseHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnWarranty = new DevExpress.XtraBars.BarButtonItem();
            this.btnClaimStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnPermission = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLicense = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::PowerPOS.Properties.Resources.logo;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSale,
            this.btnReceiveroduct,
            this.btnSaleReport,
            this.btnCustomer,
            this.skinRibbonGallery,
            this.btnPurchase,
            this.btnAddCustomer,
            this.btnSaleReportByCustomer,
            this.btnPurchaseHistory,
            this.btnProduct,
            this.btnCheckStock,
            this.btnWarranty,
            this.btnClaimStatus,
            this.barStaticItem1,
            this.btnPermission,
            this.btnAbout,
            this.btnLicense});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage3,
            this.ribbonPage2,
            this.ribbonPage5});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(806, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnSale
            // 
            this.btnSale.Caption = "ขายสินค้า";
            this.btnSale.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSale.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSale.Glyph")));
            this.btnSale.Id = 4;
            this.btnSale.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSale.LargeGlyph")));
            this.btnSale.Name = "btnSale";
            this.btnSale.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSale_ItemClick);
            // 
            // btnReceiveroduct
            // 
            this.btnReceiveroduct.Caption = "รับสินค้า";
            this.btnReceiveroduct.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnReceiveroduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReceiveroduct.Glyph")));
            this.btnReceiveroduct.Id = 7;
            this.btnReceiveroduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReceiveroduct.LargeGlyph")));
            this.btnReceiveroduct.Name = "btnReceiveroduct";
            this.btnReceiveroduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReceiveroduct_ItemClick);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.Caption = "ยอดขาย";
            this.btnSaleReport.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSaleReport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaleReport.Glyph")));
            this.btnSaleReport.Id = 8;
            this.btnSaleReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaleReport.LargeGlyph")));
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaleReport_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "ข้อมูลลูกค้า";
            this.btnCustomer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Glyph")));
            this.btnCustomer.Id = 9;
            this.btnCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.LargeGlyph")));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // skinRibbonGallery
            // 
            this.skinRibbonGallery.Caption = "skinRibbonGallery";
            this.skinRibbonGallery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            // 
            // 
            // 
            this.skinRibbonGallery.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinRibbonGalleryBarItem1_Gallery_ItemClick);
            this.skinRibbonGallery.Id = 2;
            this.skinRibbonGallery.Name = "skinRibbonGallery";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Caption = "สั่งซื้อ";
            this.btnPurchase.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Glyph")));
            this.btnPurchase.Id = 3;
            this.btnPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.LargeGlyph")));
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPurchase_ItemClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Caption = "เพิ่มข้อมูล";
            this.btnAddCustomer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAddCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Glyph")));
            this.btnAddCustomer.Id = 4;
            this.btnAddCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.LargeGlyph")));
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCustomer_ItemClick);
            // 
            // btnSaleReportByCustomer
            // 
            this.btnSaleReportByCustomer.Caption = "ยอดขาย";
            this.btnSaleReportByCustomer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSaleReportByCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaleReportByCustomer.Glyph")));
            this.btnSaleReportByCustomer.Id = 7;
            this.btnSaleReportByCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaleReportByCustomer.LargeGlyph")));
            this.btnSaleReportByCustomer.Name = "btnSaleReportByCustomer";
            this.btnSaleReportByCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaleReportByCustomer_ItemClick);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.Caption = "ประวัติ";
            this.btnPurchaseHistory.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPurchaseHistory.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPurchaseHistory.Glyph")));
            this.btnPurchaseHistory.Id = 8;
            this.btnPurchaseHistory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPurchaseHistory.LargeGlyph")));
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPurchaseHistory_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "ข้อมูลสินค้า";
            this.btnProduct.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProduct.Glyph")));
            this.btnProduct.Id = 9;
            this.btnProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProduct.LargeGlyph")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Caption = "เช็คสต๊อก";
            this.btnCheckStock.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCheckStock.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCheckStock.Glyph")));
            this.btnCheckStock.Id = 10;
            this.btnCheckStock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCheckStock.LargeGlyph")));
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheckStock_ItemClick);
            // 
            // btnWarranty
            // 
            this.btnWarranty.Caption = "ประกัน";
            this.btnWarranty.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnWarranty.Glyph = ((System.Drawing.Image)(resources.GetObject("btnWarranty.Glyph")));
            this.btnWarranty.Id = 12;
            this.btnWarranty.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnWarranty.LargeGlyph")));
            this.btnWarranty.Name = "btnWarranty";
            this.btnWarranty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWarranty_ItemClick);
            // 
            // btnClaimStatus
            // 
            this.btnClaimStatus.Caption = "สถานะ";
            this.btnClaimStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnClaimStatus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClaimStatus.Glyph")));
            this.btnClaimStatus.Id = 13;
            this.btnClaimStatus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClaimStatus.LargeGlyph")));
            this.btnClaimStatus.Name = "btnClaimStatus";
            this.btnClaimStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClaimStatus_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "กำลัง Sync ข้อมูลเข้าระบบ Cloud";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.Id = 14;
            this.barStaticItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.LargeGlyph")));
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnPermission
            // 
            this.btnPermission.Caption = "สิทธิ์การใช้งาน";
            this.btnPermission.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPermission.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPermission.Glyph")));
            this.btnPermission.Id = 16;
            this.btnPermission.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPermission.LargeGlyph")));
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPermission_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "สินค้า";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSale);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReceiveroduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCheckStock);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "ข้อมูล";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPurchase);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPurchaseHistory);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "การสั่งซื้อ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaleReport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "รายงาน";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup7});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ลูกค้า";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAddCustomer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "ข้อมูล";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSaleReportByCustomer);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "รายงาน";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "งานเครม";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnWarranty);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClaimStatus);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "ตรวจสอบข้อมูล";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "การเงิน";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup8});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "การตั้งค่า";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPermission);
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGallery);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "หน้าจอ";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 583);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(806, 31);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "สิทธิ์การใช้งาน";
            this.barButtonItem12.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 143);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(806, 440);
            this.panelMain.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "ข้อมูลระบบ";
            this.btnAbout.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAbout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.Glyph")));
            this.btnAbout.Id = 17;
            this.btnAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.LargeGlyph")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnLicense);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "เกี่ยวกับระบบ";
            // 
            // btnLicense
            // 
            this.btnLicense.Caption = "ใบอนุญาต";
            this.btnLicense.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLicense.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLicense.Glyph")));
            this.btnLicense.Id = 18;
            this.btnLicense.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLicense.LargeGlyph")));
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLicense_ItemClick);
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 614);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Power POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSale;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnReceiveroduct;
        private DevExpress.XtraBars.BarButtonItem btnSaleReport;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGallery;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnPurchase;
        private DevExpress.XtraBars.BarButtonItem btnAddCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSaleReportByCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnPurchaseHistory;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnCheckStock;
        private DevExpress.XtraBars.BarButtonItem btnWarranty;
        private DevExpress.XtraBars.BarButtonItem btnClaimStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btnPermission;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.BarButtonItem btnLicense;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}