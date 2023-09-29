using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{

    public partial class OilSale : Form
    {
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public OilSale()
        {
            InitializeComponent();
            conDB();
            runningSaaleID();
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
        private void runningSaaleID()
        {
            cmd.CommandText = "SELECT MAX(SaleId) FROM OilSale";
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                int currentSaleID = Convert.ToInt32(result);
                currentSaleID = currentSaleID + 1;
                SaleID.Text= currentSaleID.ToString();
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "INSERT INTO OilSale (SaleID, MemberId, SaleDate, DispenserId, PricePerLiter, LiterSold, Tax, PaymentMethod, FillerId) " +
                             "VALUES (@SaleID, @MemberId, @SaleDate, @DispenserId, @PricePerLiter, @LiterSold, @Tax, @PaymentMethod, @FillerId)";

            cmd.Parameters.AddWithValue("@SaleID", SaleID.Text);
            cmd.Parameters.AddWithValue("@MemberId", MemberID.Text);
            cmd.Parameters.AddWithValue("@SaleDate", SaleDate.Text);
            cmd.Parameters.AddWithValue("@DispenserId", DispenserID.Text);
            cmd.Parameters.AddWithValue("@PricePerLiter", PricePerLiter.Text);
            cmd.Parameters.AddWithValue("@LiterSold", LitersSold.Text);
            cmd.Parameters.AddWithValue("@Tax", Tax.Text);
            //cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            //cmd.Parameters.AddWithValue("@FillerId", FillerID);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
            }
            else
            {
                MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
        }

    }
}
