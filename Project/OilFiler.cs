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
    public partial class OilFiler : Form
    {
        OdbcConnection con = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        public OilFiler()
        {
            InitializeComponent();
            conDB();
            getOilFiller();
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

        private void getOilFiller()
        {
            cmd.CommandText = "select * from OilFiller";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            this.dataGridView1.DataSource = bindingSource1;
        }
        private void New_Click(object sender, EventArgs e)
        {
            FillerID.Clear();
            FillerName.Clear();
            PhoneNumber.Clear();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (FillerID.Text != "")
                {
                    cmd.CommandText = "insert into OilFiller(FillerID,FillerName,PhoneNumber) values('" + FillerID.Text + "','" + FillerName.Text + "','" + PhoneNumber.Text + "')";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("การเพิ่มข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                        FillerID.Clear();
                        FillerName.Clear();
                        PhoneNumber.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ไม่มีการเพิ่มข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                    }
                    getOilFiller();
                }
                else { MessageBox.Show("กรอกข้อมูลไม่ครบ"); }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete from OilFiller where FillerID='" + FillerID.Text + "'";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("การลบข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                    FillerID.Clear();
                    FillerName.Clear();
                    PhoneNumber.Clear();
                }
                else
                {
                    MessageBox.Show("ไม่มีการลบข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                }
                getOilFiller();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Update OilFiller set FillerID='" + FillerID.Text + "',FillerName='" + FillerName.Text + "',PhoneNumber='" + PhoneNumber.Text + "'";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("การแก้ไขข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกเพิ่ม");
                    FillerID.Clear();
                    FillerName.Clear();
                    PhoneNumber.Clear();
                }
                else
                {
                    MessageBox.Show("ไม่มีการแก้ไชข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                }
                getOilFiller();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FillerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from OilFiller where FillerID= '" + FillerID.Text + "'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    FillerName.Text = rs.GetString(1);
                    PhoneNumber.Text = rs.GetString(2);
                }
                rs.Close();
            }
        }

        private void OilFiler_Load(object sender, EventArgs e)
        {

        }
    }
}
