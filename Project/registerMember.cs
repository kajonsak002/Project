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

namespace Project
{
    public partial class registerMember : Form
    {
        OdbcConnection con =new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();

        public registerMember()
        {
            InitializeComponent();
            conDB();
            getMember();
            runnigID();
        }

        private void runnigID()
        {
            try
            {
                cmd.CommandText = "SELECT count(MemberID) FROM Member";
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    int currentSaleID = Convert.ToInt32(result);
                    currentSaleID = currentSaleID + 1;
                    Console.WriteLine(currentSaleID);
                    customerCode.Text = string.Format("{0:D5}", currentSaleID);
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void getMember()
        {
            cmd.CommandText = "select * from Member";
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            this.dataGridView1.DataSource = bindingSource1;
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
            reset();
        }
        private void reset()
        {
            customerCode.Clear();
            customerName.Clear();
            customerTel.Clear();
            runnigID();
        }
        private Boolean checknull()
        {
            int c = 0;
            if (customerCode.Text != ""){ c += 1; }
            if (customerName.Text != "") { c += 1; }
            if (customerTel.Text != "") { c += 1; }
            if(c==3)
            {
                return true;
            }
            else { return false; }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
                cmd.CommandText = "insert into Member(MemberID,MemberName,PhoneNumber,MemberPoints) values('" + customerCode.Text + "','" + customerName.Text + "','" + customerTel.Text + "','"+0+"')";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("ทำการสมัครสมาชิกสำเร็จ");
                }
                else
                {
                    MessageBox.Show("ไม่สามารถทำการสมัครสมาชิกได้");
                }
                customerCode.Clear();
                customerName.Clear();
                customerTel.Clear();
                getMember();
=======
            try
            {
                if (checknull())
                {
                    cmd.CommandText = "insert into Member(MemberID,MemberName,PhoneNumber,MemberPoints) values('" + customerCode.Text + "','" + customerName.Text + "','" + customerTel.Text + "','" + 0 + "')";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ทำการสมัครสมาชิกสำเร็จ");
                        reset();
                        getMember();
                        runnigID();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถทำการสมัครสมาชิกได้");
                    }
                }
                else { MessageBox.Show("กรอกข้อมูลไม่ครบ"); }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }   
          
>>>>>>> cf6b7d00e68f682d76b791d63058bad433616ef1
        }

    
        private void customerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Member where MemberID= '" + customerCode.Text + "'";
                OdbcDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    customerName.Text = rs.GetString(1);
                    customerTel.Text = rs.GetString(2);
                }
                rs.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {    
                cmd.CommandText = "update Member set  MemberID='"+customerCode.Text +"',MemberName='" + customerName.Text + "',PhoneNumber='" + customerTel.Text + "'where MemberID='" + customerCode.Text + "'";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("การอัปเดตข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกอัปเดต");
                reset();
                getMember();
                }
                else
                {
                    MessageBox.Show("ไม่มีการอัปเดตข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                }     
              

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่หรือไม่?", "ยืนยันการปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "delete Member where MemberID ='" + customerCode.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("การลบข้อมูลเสร็จสมบูรณ์: " + rowsAffected + " แถวถูกลบ");
                        reset();
                        getMember();
                    }
                    else
                    {
                        MessageBox.Show("ไม่มีการลบข้อมูลหรือมีข้อผิดพลาดเกิดขึ้น");
                    }
                }catch (Exception ex) { MessageBox.Show(ex.Message); }  
            }
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่?", "ยืนยันการปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }    
}

