using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace PowerPOS
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Parameter
        enum Screen { Sale, ReceiveProduct, Product, Customer, User, Brand, Category, Color, Report, ShopInfo, Config, Claim, Return, Stock };
        XtraUserControl _USER_CONTROL;
        UcSale _UC_SALE;
        UcReceiveProduct _UC_RECEIVE_PRODUCT;
        #endregion

        #region Initial
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _UC_SALE = new UcSale();
            _USER_CONTROL = _UC_SALE;
        }
        #endregion
        
        #region Ribbon Event

        private void btnSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddPanel(Screen.Sale);
        }

        private void btnReceiveroduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddPanel(Screen.ReceiveProduct);
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnCheckStock_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPurchaseHistory_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSaleReport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAddCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSaleReportByCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnWarranty_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnClaimStatus_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPermission_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnLicense_ItemClick(object sender, ItemClickEventArgs e)
        {
            FmLicense fm = new FmLicense();
            fm.ShowDialog(this);
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void skinRibbonGalleryBarItem1_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Console.WriteLine(e.Item.Caption);
        }
        #endregion

        #region Internal Method
        private void AddPanel(Screen screen)
        {
            switch (screen)
            {
                case Screen.Sale:
                    if (_UC_SALE == null) _UC_SALE = new UcSale();
                    _USER_CONTROL = _UC_SALE;
                    break;
                case Screen.ReceiveProduct:
                    if (_UC_RECEIVE_PRODUCT == null) _UC_RECEIVE_PRODUCT = new UcReceiveProduct();
                    _USER_CONTROL = _UC_RECEIVE_PRODUCT;
                    break;
            }

            if (!panelMain.Contains(_USER_CONTROL))
            {
                panelMain.Controls.Clear();
                _USER_CONTROL.Dock = DockStyle.Fill;
                panelMain.Controls.Add(_USER_CONTROL);
            }
        }
        #endregion
    }
}