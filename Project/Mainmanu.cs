using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Mainmanu : Form
    {
        public Mainmanu()
        {
            InitializeComponent();
        }

        private void สมครสมาชกToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            registerMember registerMember = new registerMember();
            registerMember.MdiParent= this;
            registerMember.Show();
        }

        private void จดการนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oil oil = new Oil();
            oil.MdiParent = this;
            oil.Show(); 
        }

        private void การขายนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilSale oilsale = new OilSale();
            oilsale.MdiParent = this;
            oilsale.Show();
        }

        private void จดการแทงคนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilTank oiltank = new OilTank();
            oiltank.MdiParent = this;
            oiltank.Show();
        }
    }
}
