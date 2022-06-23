using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Calculator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            funLogin();
        }

        private void funLogin()
        {
            string sUname = "batman";
            string sPwd = "alpine";
            string Uname = txtUname.Text.ToString();
            string UPwd = txtPwd.Text.ToString();

            if((string.Compare(Uname, sUname) == 0)&&(string.Compare(UPwd, sPwd) == 0))
            {
                this.Hide();
                frmMenu frmHmenu = new frmMenu();
                frmHmenu.Show();
            }
        }

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPwd.Focus();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            funLogin();
        }
    }
}
