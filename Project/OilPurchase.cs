using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Reflection.Emit;

namespace Project
{
    public partial class OilPurchase : Form
    {
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public OilPurchase()
        {
            InitializeComponent();
            conDB();
            showOilPurChase();
            getOil();
        }

        private void conDB()
        {
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
        }
        private void showOilPurChase()
        {
            cmd.CommandText = "select OilPurChase.*,CurrentVolume from OilPurchase join OilTank on OilPurchase.OilTankID = OilTank.TankID";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            this.dataGridView1.DataSource = bindingSource2;
        }
        private void getOil()
        {
            cmd.CommandText = "select * from OilTank join Oil on OilTank.OilID = Oil.OilID ";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            OilName.DataSource = bindingSource1;
            OilName.DisplayMember = "OilName";
            OilName.ValueMember = "TankID";
            OilTankID.Text = OilName.SelectedValue.ToString();
        }
        private void New_Click(object sender, EventArgs e)
        {
            PurchaseID.Clear();
            OilVolumePurchase.Clear();
            OilTankID.Clear();
            OilName.SelectedIndex= 0;   
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into OilPurchase(PurchaseID,OilVolumePurchased,PricePerLiter,PurchaseDate,OilTankID) values('" + PurchaseID.Text + "','" + OilVolumePurchase.Text + "','" + pricePerLiter.Text + "','"+ String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value) + "','"+OilTankID.Text+"')";
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                
                String sql = "update OilTank set CurrentVolume +='" + OilVolumePurchase.Text + "' where TankID = '" + OilTankID.Text + "'";
                cmd.CommandText = "update OilTank set CurrentVolume +='"+OilVolumePurchase.Text+"' where TankID = '"+OilTankID.Text+"'";
                cmd.ExecuteNonQuery();
                PurchaseID.Clear();
                OilVolumePurchase.Clear();
                OilTankID.Clear();
                Console.WriteLine(sql);
            }
            else
            {
                MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
            
            showOilPurChase();
        }
       
   

        private void Update_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void PurchaseID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from OilPurchase where PurchaseID= '" + PurchaseID.Text + "'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    OilVolumePurchase.Text = rs.GetString(1);
                    OilTankID.Text = rs.GetString(2);
                   
                }
                rs.Close();
            }
        }

        private void OilName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OilName.SelectedIndex >= 0)
            {
                OilTankID.Text = OilName.SelectedValue.ToString();
            }
        }

        private void OilPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}
