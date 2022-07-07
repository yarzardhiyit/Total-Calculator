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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void funCalc()
        {
            double dRadius;
            double dArea;
            string sRadius = txtInputRadius.Text;
            /*
            * convert string to double using double.Parse function
            * txtRadius - textbox radius,.Text.Tostring() - user input as string
            */
            const double PI = 3.14159; //const <data_type> <constant_name> = value;
            dRadius = double.Parse(sRadius); //string to double
            dArea = PI * dRadius * dRadius; //PI * r * r
            txtArea.Text = dArea.ToString(); //double to string
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            funCalc(); //recall funCalc function
        }

        private void txtInputRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
                funCalc();
        }
    }
}
