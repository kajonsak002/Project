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
    public partial class OilTank : Form
    {
        DbHelper dbHelper;
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public OilTank()
        {
            InitializeComponent();
            dbHelper = new DbHelper("DSN=PROJECT");
            conDB();
            getOil();
            showOilTank();
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
        private void showOilTank()
        {
            cmd.CommandText = "select OilTank.*,OilName from OilTank join Oil on OilTank.OilID = Oil.OilID";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            this.dataGridView1.DataSource = bindingSource2;
        }

        private void getOil()
        {
            cmd.CommandText = "select * from Oil";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            oilId.DataSource = bindingSource1;
            oilId.DisplayMember = "OilName";
            oilId.ValueMember = "OilID";
            oil_id.Text = oilId.SelectedValue.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            oilTankId.Clear();
            oilTankCapacity.Clear();
            oilVolume.Clear();
            oilId.SelectedIndex = 0;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            dbHelper.InsertOilTank(oilTankId.Text, oil_id.Text,oilTankCapacity.Text,oilVolume.Text);
            showOilTank();
            
        }

        private void oilId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oilId.SelectedIndex >= 0)
            {
                oil_id.Text = oilId.SelectedValue.ToString();
                
            }
    
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            dbHelper.UpdateOilTank(oilTankId.Text,oil_id.Text,oilTankCapacity.Text,oilVolume.Text);
            showOilTank();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            dbHelper.DeleteOilTank(oilTankId.Text);
            showOilTank();
        }

        private void oilTankId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void oilTankId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select MaxCapacity,CurrentVolume,OilName from OilTank join Oil on OilTank.OilID = Oil.OilID where TankID= '" + oilTankId.Text + "'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    oilTankCapacity.Text = rs.GetString(0);
                    oilVolume.Text= rs.GetString(1);
                    oilId.Text = rs.GetString(2);
                }
                rs.Close();
            }
        }
    }
}
