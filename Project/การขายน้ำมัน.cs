using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class การขายน้ำมัน : Form
    {
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public การขายน้ำมัน()
        {
            InitializeComponent();
            try
            {
                con.ConnectionString = "DSN=PROJECT";
                con.Open();
                cmd.Connection = con;
                //MessageBox.Show("เชื่อมต่อฐานข้อมูลสำเร็จ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลากในการเชื่อมต่อฐานข้อมูล" + ex.Message);
            }
            cmd.CommandText = "select SaleID,OilSale.MemberID,MemberName,LitersSold,PricePerLiter,cast(LitersSold*PricePerLiter AS DECIMAL(10, 2)) as Amount,SaleDate,PayMentmethod,OilFiller.FillerID,FillerName from OilSale join Member on OilSale.MemberID = Member.MemberID join OilFiller on OilSale.FillerID = OilFiller.FillerID";
                OdbcDataAdapter ad = new OdbcDataAdapter();
                ad.SelectCommand = cmd;
                DataTable table = new DataTable();
                ad.Fill(table);
                bindingSource1.DataSource = table;
                this.dataGridView1.DataSource = bindingSource1;
            
        }
    }
}
