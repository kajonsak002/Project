﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Dispenser : Form
    {
        DbHelper dbHelper;
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public Dispenser()
        {
            InitializeComponent();
            dbHelper = new DbHelper("DSN=PROJECT");
            conDB();
            getOilTank();
            showDispenser();
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
        private void showDispenser()
        {
            
            cmd.CommandText = "select DispenserID,OilTankID,OilName from Dispenser join OilTank on Dispenser.OilTankID = OilTank.TankID join Oil on OilTank.OilID = Oil.OilID";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            this.dataGridView1.DataSource = bindingSource2;
        }

        private void getOilTank()
        {
            try
            {
                cmd.CommandText = "select TankID,TankID + OilName as TON from OilTank join Oil on OilTank.OilID = Oil.OilID";
                OdbcDataAdapter ad = new OdbcDataAdapter();
                ad.SelectCommand = cmd;
                DataTable table = new DataTable();
                ad.Fill(table);
                bindingSource1.DataSource = table;
                oilName.DataSource = bindingSource1;
                oilName.DisplayMember = "TON";
                oilName.ValueMember = "TankID";
                oilTankID.Text = oilName.SelectedValue.ToString();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Dispenser_Load(object sender, EventArgs e)
        {

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            dispenserId.Clear();
            oilTankID.Clear();
            oilName.SelectedIndex = 0;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (dispenserId.Text != "")
                {
                    cmd.CommandText = "INSERT INTO Dispenser (DispenserID, OilTankID) VALUES ('" + dispenserId.Text + "','" + oilTankID.Text + "' )";

                    cmd.ExecuteNonQuery();
                    showDispenser();
                    dispenserId.Clear();
                    oilTankID.Clear();
                    oilName.SelectedIndex = 0;
                }
                else { MessageBox.Show("กรอกข้อมูลไม่ครบ"); }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void oilName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oilName.SelectedIndex >= 0)
            {
               oilTankID.Text =oilName.SelectedValue.ToString();

            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dispenserId.Text != "")
                {
                    dbHelper.UpdateDispenser(oilTankID.Text, dispenserId.Text);
                    showDispenser();
                }
                else { MessageBox.Show("กรอกข้อมูลไม่ครบ"); }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dispenserId.Text != "") {
                    DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbHelper.DeleteDispenser(dispenserId.Text);
                        showDispenser();
                    }
                }
                else { MessageBox.Show("กรอกข้อมูลไม่ครบ"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dispenserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select OilName from Dispenser join OilTank on Dispenser.OilTankID = OilTank.TankID join Oil on OilTank.OilID = Oil.OilID where DispenserID ='"+dispenserId.Text+"'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    oilName.Text = rs.GetString(0);
                }
                rs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องปิดฟอร์มนี้หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
         
        }
    }
}
