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
            registerMember.WindowState = FormWindowState.Maximized;
            registerMember.Show();
          
        }

        private void จดการนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oil oil = new Oil();
            oil.MdiParent = this;
            oil.WindowState= FormWindowState.Maximized;
            oil.Show(); 
        }

        private void การขายนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilSale oilsale = new OilSale();
            oilsale.MdiParent = this;
            oilsale.WindowState = FormWindowState.Maximized;
            oilsale.Show();
        }

        private void จดการแทงคนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilTank oiltank = new OilTank();
            oiltank.MdiParent = this;
            oiltank.WindowState = FormWindowState.Maximized;
            oiltank.Show();
        }

        private void จดการพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilFiler oilFiler = new OilFiler();
            oilFiler.MdiParent = this;
            oilFiler.WindowState = FormWindowState.Maximized;
            oilFiler.Show();
        }

        private void การซอนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilPurchase oilPurchase = new OilPurchase();
            oilPurchase.MdiParent = this;
            oilPurchase.WindowState = FormWindowState.Maximized;
            oilPurchase.Show();
        }

        private void จดการหวจายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispenser oilPurchase = new Dispenser();
            oilPurchase.MdiParent = this;
            oilPurchase.WindowState = FormWindowState.Maximized;
            oilPurchase.Show();
        }

<<<<<<< HEAD
       
=======
        private void รายงานการขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            การขายน้ำมัน Oil = new การขายน้ำมัน();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }

        private void รายงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void รายงานการขายนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report Oil = new Report();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }

        private void รายงานสมาชกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberRpt Oil = new MemberRpt();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }

        private void รายงานพนงงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillerRpt Oil = new FillerRpt();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }

        private void รายงานนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilRpt Oil = new OilRpt();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }

        private void รายงานแทงคนำมนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilTankRpt Oil = new OilTankRpt();
            Oil.MdiParent = this;
            Oil.WindowState = FormWindowState.Maximized;
            Oil.Show();
        }
>>>>>>> cf6b7d00e68f682d76b791d63058bad433616ef1
    }
}
