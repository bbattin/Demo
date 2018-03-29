using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180328_FirrstWinFormsApp
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblText.Text = "Clicked!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Location = new System.Drawing.Point(btnCancel.Location.X - btnCancel.Width, btnCancel.Location.Y - btnCancel.Height);
            MessageBox.Show("Test");
        }
    }
}
