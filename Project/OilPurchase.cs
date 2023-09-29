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

        private void New_Click(object sender, EventArgs e)
        {
            PurchaseID.Clear();
            OilVolumePurchase.Clear();
            OilId.Clear();
            DispenderID.Clear();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into OilPurchase(PurchaseID,OilVolumePurchased,OilID,DispenserID) values('" + PurchaseID.Text + "','" + OilVolumePurchase.Text + "','" + OilId.Text + "','" + DispenderID.Text + "')";
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                PurchaseID.Clear();
                OilVolumePurchase.Clear();
                OilId.Clear();
                DispenderID.Clear();
            }
            else
            {
                MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update OilPurchase set PurchaseID='" + PurchaseID.Text + "','" + OilVolumePurchase.Text + "','" + OilId.Text + "','" + DispenderID.Text + "'";
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การแก้ไขข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
            }
            else
            {
                MessageBox.Show("ไม่มีการแก้ไขข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete OilPurchase where PurchaseID =" + PurchaseID.Text;
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การลบข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกลบ");
            }
            else
            {
                MessageBox.Show("ไม่มีการลบข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
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
                    OilId.Text = rs.GetString(2);
                    DispenderID.Text = rs.GetString(3);
                }
                rs.Close();
            }
        }
    }
}
