using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            priceClick();
        }

        public void priceClick()
        {
            panelDisplay.Controls.Clear();
            AddPrice adprice = new AddPrice();
            panelDisplay.Controls.Add(adprice);
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            RegisterStaff registerStaff = new RegisterStaff();
            panelDisplay.Controls.Add(registerStaff);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginPage = new Form2();
            loginPage.Show();
            this.Close();
        }
    }
}
