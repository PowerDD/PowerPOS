using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PowerPOS
{
    public partial class UcSale : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSale()
        {
            InitializeComponent();
        }

        private void SetActiveButton(CheckButton button)
        {
            button.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            //button.Checked = true;
        }

        private void SetDefaultButton(CheckButton button)
        {
            button.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            button.Checked = false;
        }

        private void btnAge_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckButton)sender).Checked)
            {
                SetDefaultButton(btnAge1);
                SetDefaultButton(btnAge2);
                SetDefaultButton(btnAge3);
                SetDefaultButton(btnAge4);
                SetDefaultButton(btnAge5);
                SetDefaultButton(btnAge6);
            }
            SetActiveButton((CheckButton)sender);
        }

        private void btnGender_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckButton)sender).Checked)
            {
                SetDefaultButton(btnMan);
                SetDefaultButton(btnWoman);
            }
            SetActiveButton((CheckButton)sender);
        }
    }
}
