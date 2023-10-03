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
    public partial class Oil : Form
    {
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public Oil()
        {
            InitializeComponent();
            conDB();
            OilInventoly();
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

        private void OilInventoly()
        {
           
            cmd.CommandText = "select * from Oil";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            this.dataGridView1.DataSource = bindingSource1;
        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Oil(OilID,OilName,PricePerLiter,Density,ChemicalVolume,DensityValue) " +
                    "values('" + oilCode.Text + "','" + oilName.Text + "','" + oilPrice.Text + "'," +
                    "'" + Density.Text + "','" + ChemicalVolume.Text + "','" + DensityValues.Text + "')";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                }
                else
                {
                    MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                }
                oilCode.Clear();
                oilName.Clear();
                oilPrice.Clear();

                Density.Clear();
                ChemicalVolume.Clear();
                DensityValues.Clear();
                OilInventoly();
            }catch(Exception ex) {MessageBox.Show("เกิดข้อผิดพลาดหรือ กรอกข้อมูลไม่ครบ"); }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Oil set OilID='" + oilCode.Text + "',OilName='" + oilName.Text + "' , " +
                "PricePerLiter='" + oilPrice.Text + "'," +
                //"OilVolume='"+oilVolume.Text+"'," +
                "Density='" + Density.Text + "'," +
                "ChemicalVolume='" + ChemicalVolume.Text + "'," +
                "DensityValue='" + DensityValues.Text + "'where OilId='" + oilCode.Text + "'";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("การแก้ไขข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                }
                else
                {
                    MessageBox.Show("ไม่มีการแก้ไขข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                }
                oilCode.Clear();
                oilName.Clear();
                oilPrice.Clear();
                // oilVolume.Clear();
                Density.Clear();
                ChemicalVolume.Clear();
                DensityValues.Clear();
                OilInventoly();
            }catch(Exception ex) {MessageBox.Show("เกิดข้อผิดพลาด หรือกรอกข้อมูลไม่ครบ"); }
            }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("คุณต้องลบข้อมูลหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    cmd.CommandText = "delete Oil where OilID =" + oilCode.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("การลบข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกลบ");
                    }
                    else
                    {
                        MessageBox.Show("ไม่มีการลบข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                    }
                    oilCode.Clear();
                    oilName.Clear();
                    oilPrice.Clear();
                    //oilVolume.Clear();
                    Density.Clear();
                    ChemicalVolume.Clear();
                    DensityValues.Clear();
                    OilInventoly();
                }
            }catch(Exception ex) { MessageBox.Show("เกิดข้อผิดพลาดหรือ ไม่ได้กรอกข้อมูล"); }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องปิดฟอร์มนี้หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void oilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Oil where OilId= '" + oilCode.Text + "'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    oilName.Text = rs.GetString(1);
                    oilPrice.Text = rs.GetString(2);
                   // oilVolume.Text = rs.GetString(3);
                    Density.Text = rs.GetString(3);
                    ChemicalVolume.Text = rs.GetString(4);
                    DensityValues.Text = rs.GetString(5);
                }
                rs.Close();
            }
        }

        private void Oil_Load(object sender, EventArgs e)
        {

        }
    }
}
