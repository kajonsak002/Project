﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
            getOilFiller();
            getDispender();
            getMember();
            getPrice();
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
        private void getMember()
        {
            cmd.CommandText = "select * from Member";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource3.DataSource = table;
            MemberName.DataSource = bindingSource3;
            MemberName.DisplayMember = "MemberName";
            MemberName.ValueMember = "MemberID";
            MemberID.Text = MemberName.SelectedValue.ToString();
        }
        private void getDispender()
        {
            cmd.CommandText = "select * from Dispenser join OilTank on Dispenser.OilTankID = OilTank.TankID join Oil on OilTank.OilID = Oil.OilID";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            OilName.DataSource = bindingSource2;
            OilName.DisplayMember = "OilName";
            OilName.ValueMember = "DispenserID";
            DispenserID.Text = OilName.SelectedValue.ToString();
            
        }
        private void getOilFiller()
        {
            cmd.CommandText = "select * from OilFiller";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            FillerName.DataSource = bindingSource1;
            FillerName.DisplayMember = "FillerName";
            FillerName.ValueMember = "FillerID";
            FillerID.Text = FillerName.SelectedValue.ToString();
        }
        private void Insert_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "insert into OilSale(SaleID,DispenserID,PricePerLiter,MemberID,LitersSold,SaleDate) values('" + SaleID.Text + "','" + DispenserID.Text + "','" + PricePerLiter.Text + "','" + MemberID.Text + "','" + LitersSold.Text + "','"+String.Format("{0:d}", SaleDate.Value)+"'";
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
            }
            else
            {
                MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
            }
            addPoint(int.Parse(Total.Text));
            deCapacity();
        }
        private void FillerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FillerName.SelectedIndex >= 0)
            {
                FillerID.Text = FillerName.SelectedValue.ToString();
            }
        }
        private void OilName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OilName.SelectedIndex >= 0)
            {
                DispenserID.Text = OilName.SelectedValue.ToString();
                getPrice();
            }
        }
        private void MemberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MemberName.SelectedIndex >= 0)
            {
                MemberID.Text = MemberName.SelectedValue.ToString();
            }
        }

        private void getPrice()
        {
            cmd.CommandText = "select PricePerLiter from Oil join OilTank on Oil.OilID = OilTank.OilID join Dispenser on OilTank.TankID = Dispenser.OilTankID where DispenserID='"+DispenserID.Text+"'";
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                decimal pricePerLitter = reader.GetDecimal(0);
                PricePerLiter.Text = pricePerLitter.ToString();
            }
            reader.Close();
        }
        private void addPoint(int price)
        {
            int point = 0;
            if(price >= 1000)
            {
                point = 10;
            }
            else if(price >= 500)
            {
                point = 5;
            } else if (price >= 100)
            {
                point = 1;
            }

            cmd.CommandText = "update Member set MemberPoints+='" + point + "'where MemberID='" + MemberID.Text + "'";
            cmd.ExecuteNonQuery();

        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int tax = int.Parse(Tax.Text);
            double pricePerLiter = double.Parse(PricePerLiter.Text);
            int soldPrice = int.Parse(LitersSold.Text) * (int)Math.Floor(pricePerLiter);
            double total = soldPrice * tax/100 + soldPrice;
            Total.Text = total.ToString();
        }

        private void deCapacity()
        {
            int lit = int.Parse(LitersSold.Text);
            cmd.CommandText = "update OilTank set CurrentVolume-='"+lit+"'from OilTank join Dispenser on OilTank.TankID = Dispenser.OilTankID where DispenserID='"+DispenserID.Text+"'";
            cmd.ExecuteNonQuery();
        }
    }
}
