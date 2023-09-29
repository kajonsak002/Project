namespace Project
{
    partial class OilSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaleDate = new System.Windows.Forms.DateTimePicker();
            this.FillerID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaleID = new System.Windows.Forms.TextBox();
            this.MemberID = new System.Windows.Forms.TextBox();
            this.PricePerLiter = new System.Windows.Forms.TextBox();
            this.DispenserID = new System.Windows.Forms.TextBox();
            this.LitersSold = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.New = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaleDate
            // 
            this.SaleDate.Location = new System.Drawing.Point(612, 17);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(243, 22);
            this.SaleDate.TabIndex = 0;
            // 
            // FillerID
            // 
            this.FillerID.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FillerID.FormattingEnabled = true;
            this.FillerID.Location = new System.Drawing.Point(229, 362);
            this.FillerID.Name = "FillerID";
            this.FillerID.Size = new System.Drawing.Size(174, 36);
            this.FillerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "รูปแบบการชำระเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "เลขที่ใบขาย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(111, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสหัวจ่าย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(100, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "ราคาต่อลิตร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(72, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "จำนวนลิตรที่ขาย";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(92, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "ภาษีมูลค่าเพิ่ม";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(315, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "รหัสสมาชิก";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(38, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "รหัสพนักงานเติมน้ำมัน";
            // 
            // SaleID
            // 
            this.SaleID.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SaleID.Location = new System.Drawing.Point(124, 8);
            this.SaleID.Name = "SaleID";
            this.SaleID.Size = new System.Drawing.Size(174, 36);
            this.SaleID.TabIndex = 10;
            // 
            // MemberID
            // 
            this.MemberID.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MemberID.Location = new System.Drawing.Point(412, 8);
            this.MemberID.Name = "MemberID";
            this.MemberID.Size = new System.Drawing.Size(174, 36);
            this.MemberID.TabIndex = 11;
            // 
            // PricePerLiter
            // 
            this.PricePerLiter.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PricePerLiter.Location = new System.Drawing.Point(229, 140);
            this.PricePerLiter.Name = "PricePerLiter";
            this.PricePerLiter.Size = new System.Drawing.Size(174, 36);
            this.PricePerLiter.TabIndex = 12;
            // 
            // DispenserID
            // 
            this.DispenserID.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DispenserID.Location = new System.Drawing.Point(229, 85);
            this.DispenserID.Name = "DispenserID";
            this.DispenserID.Size = new System.Drawing.Size(174, 36);
            this.DispenserID.TabIndex = 13;
            // 
            // LitersSold
            // 
            this.LitersSold.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LitersSold.Location = new System.Drawing.Point(229, 198);
            this.LitersSold.Name = "LitersSold";
            this.LitersSold.Size = new System.Drawing.Size(174, 36);
            this.LitersSold.TabIndex = 14;
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Tax.Location = new System.Drawing.Point(229, 248);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(174, 36);
            this.Tax.TabIndex = 16;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "เงินสด",
            "บัตรเครดิต/เดบิต",
            "พร้อมเพย์"});
            this.PaymentMethod.Location = new System.Drawing.Point(229, 307);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(174, 36);
            this.PaymentMethod.TabIndex = 17;
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.New.Location = new System.Drawing.Point(482, 79);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(92, 47);
            this.New.TabIndex = 18;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insert.Location = new System.Drawing.Point(482, 140);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(92, 47);
            this.Insert.TabIndex = 19;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Delete.Location = new System.Drawing.Point(482, 260);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 47);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Update.Location = new System.Drawing.Point(482, 198);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 47);
            this.Update.TabIndex = 21;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("IBM Plex Sans Thai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Close.Location = new System.Drawing.Point(482, 323);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(92, 47);
            this.Close.TabIndex = 22;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // OilSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.New);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.LitersSold);
            this.Controls.Add(this.DispenserID);
            this.Controls.Add(this.PricePerLiter);
            this.Controls.Add(this.MemberID);
            this.Controls.Add(this.SaleID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FillerID);
            this.Controls.Add(this.SaleDate);
            this.Name = "OilSale";
            this.Text = "OilSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SaleDate;
        private System.Windows.Forms.ComboBox FillerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SaleID;
        private System.Windows.Forms.TextBox MemberID;
        private System.Windows.Forms.TextBox PricePerLiter;
        private System.Windows.Forms.TextBox DispenserID;
        private System.Windows.Forms.TextBox LitersSold;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Close;
    }
}