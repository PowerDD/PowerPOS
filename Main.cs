using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPOS
{
    public partial class Main : Form
    {
        #region Parameter
        enum Screen { Sale, ReceiveProduct, Product, Customer, User, Brand, Category, Color, Report, ShopInfo, Config, Claim, Return, Stock };
        XtraUserControl _USER_CONTROL;
        UcSale _UC_SALE;
        UcStock _UC_STOCK;
        UcReceiveProduct _UC_RECEIVE_PRODUCT;
        #endregion

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            AddPanel(Screen.Sale);
        }

        #region Menu Click Event
        private void navExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Dispose();
        }

        private void tileNavPane1_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (e.Element.Name == "navSale")
            {
                AddPanel(Screen.Sale);
            }
            else if (e.Element.Name == "navProduct")
            {
                AddPanel(Screen.Stock);
            }
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
                case Screen.Stock:
                    if (_UC_STOCK == null) _UC_STOCK = new UcStock();
                    _USER_CONTROL = _UC_STOCK;
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
