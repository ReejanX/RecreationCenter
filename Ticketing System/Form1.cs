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
    public partial class staffPanel : Form
    {
        public staffPanel()
        {           
            InitializeComponent();
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AddVisitors adVisitor = new AddVisitors();
            panelDisplay.Controls.Add(adVisitor);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AddPrice adprice = new AddPrice();
            panelDisplay.Controls.Add(adprice);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            Report report = new Report();
            panelDisplay.Controls.Add(report);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            Exit_Visitor exit = new Exit_Visitor();
            panelDisplay.Controls.Add(exit);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Login staff_Login = new Staff_Login();
            staff_Login.ShowDialog();

        }
    }
}
