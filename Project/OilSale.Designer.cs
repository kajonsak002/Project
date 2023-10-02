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
            this.components = new System.ComponentModel.Container();
            this.SaleDate = new System.Windows.Forms.DateTimePicker();
            this.FillerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PricePerLiter = new System.Windows.Forms.TextBox();
            this.LitersSold = new System.Windows.Forms.TextBox();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.New = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FillerID = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.OilName = new System.Windows.Forms.ComboBox();
            this.DispenserID = new System.Windows.Forms.TextBox();
            this.MemberName = new System.Windows.Forms.ComboBox();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.MemberID = new System.Windows.Forms.TextBox();
            this.SaleID = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Button();
            this.Tax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleDate
            // 
            this.SaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SaleDate.Location = new System.Drawing.Point(749, 17);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(112, 22);
            this.SaleDate.TabIndex = 0;
            this.SaleDate.Value = new System.DateTime(2023, 10, 2, 0, 0, 0, 0);
            // 
            // FillerName
            // 
            this.FillerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FillerName.FormattingEnabled = true;
            this.FillerName.Location = new System.Drawing.Point(320, 402);
            this.FillerName.Name = "FillerName";
            this.FillerName.Size = new System.Drawing.Size(174, 28);
            this.FillerName.TabIndex = 1;
            this.FillerName.SelectedIndexChanged += new System.EventHandler(this.FillerName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(57, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "รูปแบบการชำระเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "เลขที่ใบขาย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(111, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสหัวจ่าย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(100, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ราคาต่อลิตร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(72, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "จำนวนลิตรที่ขาย";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(92, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "ภาษีมูลค่าเพิ่ม";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(316, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "รหัสสมาชิก";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(38, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "รหัสพนักงานเติมน้ำมัน";
            // 
            // PricePerLiter
            // 
            this.PricePerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PricePerLiter.Location = new System.Drawing.Point(229, 140);
            this.PricePerLiter.Name = "PricePerLiter";
            this.PricePerLiter.Size = new System.Drawing.Size(174, 27);
            this.PricePerLiter.TabIndex = 12;
            // 
            // LitersSold
            // 
            this.LitersSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LitersSold.Location = new System.Drawing.Point(229, 198);
            this.LitersSold.Name = "LitersSold";
            this.LitersSold.Size = new System.Drawing.Size(174, 27);
            this.LitersSold.TabIndex = 14;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "เงินสด",
            "บัตรเครดิต/เดบิต",
            "พร้อมเพย์"});
            this.PaymentMethod.Location = new System.Drawing.Point(229, 352);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(174, 28);
            this.PaymentMethod.TabIndex = 17;
            this.PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.PaymentMethod_SelectedIndexChanged);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.New.Location = new System.Drawing.Point(740, 122);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(92, 47);
            this.New.TabIndex = 18;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insert.Location = new System.Drawing.Point(740, 203);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(92, 47);
            this.Insert.TabIndex = 19;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Update.Location = new System.Drawing.Point(740, 291);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 47);
            this.Update.TabIndex = 21;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // FillerID
            // 
            this.FillerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FillerID.Location = new System.Drawing.Point(229, 402);
            this.FillerID.Name = "FillerID";
            this.FillerID.Size = new System.Drawing.Size(68, 27);
            this.FillerID.TabIndex = 23;
            // 
            // OilName
            // 
            this.OilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.OilName.FormattingEnabled = true;
            this.OilName.Location = new System.Drawing.Point(320, 77);
            this.OilName.Name = "OilName";
            this.OilName.Size = new System.Drawing.Size(174, 28);
            this.OilName.TabIndex = 24;
            this.OilName.SelectedIndexChanged += new System.EventHandler(this.OilName_SelectedIndexChanged);
            // 
            // DispenserID
            // 
            this.DispenserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DispenserID.Location = new System.Drawing.Point(230, 76);
            this.DispenserID.Name = "DispenserID";
            this.DispenserID.Size = new System.Drawing.Size(68, 27);
            this.DispenserID.TabIndex = 25;
            // 
            // MemberName
            // 
            this.MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MemberName.FormattingEnabled = true;
            this.MemberName.Location = new System.Drawing.Point(487, 11);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(174, 28);
            this.MemberName.TabIndex = 26;
            this.MemberName.SelectedIndexChanged += new System.EventHandler(this.MemberName_SelectedIndexChanged);
            // 
            // MemberID
            // 
            this.MemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MemberID.Location = new System.Drawing.Point(409, 11);
            this.MemberID.Name = "MemberID";
            this.MemberID.Size = new System.Drawing.Size(68, 27);
            this.MemberID.TabIndex = 27;
            // 
            // SaleID
            // 
            this.SaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SaleID.Location = new System.Drawing.Point(124, 7);
            this.SaleID.Name = "SaleID";
            this.SaleID.Size = new System.Drawing.Size(151, 27);
            this.SaleID.TabIndex = 28;
            this.SaleID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleID_KeyDown);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Total.Location = new System.Drawing.Point(229, 297);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(174, 27);
            this.Total.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(92, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "มูลค่ารวม";
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Sum.Location = new System.Drawing.Point(409, 291);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(92, 47);
            this.Sum.TabIndex = 31;
            this.Sum.Text = "คำนวณ";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Tax.Location = new System.Drawing.Point(230, 248);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(45, 27);
            this.Tax.TabIndex = 32;
            this.Tax.Text = "7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(282, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "เปอร์เซ็น";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(409, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "บาท";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(409, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "ลิตร";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "วันที่";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Close.ForeColor = System.Drawing.Color.IndianRed;
            this.Close.Location = new System.Drawing.Point(740, 369);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(92, 44);
            this.Close.TabIndex = 41;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // OilSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SaleID);
            this.Controls.Add(this.MemberID);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.DispenserID);
            this.Controls.Add(this.OilName);
            this.Controls.Add(this.FillerID);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.New);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.LitersSold);
            this.Controls.Add(this.PricePerLiter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FillerName);
            this.Controls.Add(this.SaleDate);
            this.Name = "OilSale";
            this.Text = "OilSale";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SaleDate;
        private System.Windows.Forms.ComboBox FillerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PricePerLiter;
        private System.Windows.Forms.TextBox LitersSold;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox FillerID;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox OilName;
        private System.Windows.Forms.TextBox DispenserID;
        private System.Windows.Forms.ComboBox MemberName;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.TextBox MemberID;
        private System.Windows.Forms.TextBox SaleID;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Close;
    }
}