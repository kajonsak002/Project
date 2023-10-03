namespace Project
{
    partial class OilPurchase
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
            this.label3 = new System.Windows.Forms.Label();
            this.OilTankID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OilVolumePurchase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OilName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pricePerLiter = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(58, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "รหัสแทงค์น้ำมัน";
            // 
            // OilTankID
            // 
            this.OilTankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OilTankID.Location = new System.Drawing.Point(217, 240);
            this.OilTankID.Name = "OilTankID";
            this.OilTankID.Size = new System.Drawing.Size(57, 23);
            this.OilTankID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(53, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ปริมาณที่ซื้อ";
            // 
            // OilVolumePurchase
            // 
            this.OilVolumePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OilVolumePurchase.Location = new System.Drawing.Point(217, 135);
            this.OilVolumePurchase.Name = "OilVolumePurchase";
            this.OilVolumePurchase.Size = new System.Drawing.Size(74, 23);
            this.OilVolumePurchase.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "เลขที่ใบซื้อน้ำมัน";
            // 
            // PurchaseID
            // 
            this.PurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PurchaseID.Location = new System.Drawing.Point(217, 89);
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(192, 23);
            this.PurchaseID.TabIndex = 18;
            this.PurchaseID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseID_KeyDown);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.New.Location = new System.Drawing.Point(96, 318);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(99, 44);
            this.New.TabIndex = 28;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Insert.Location = new System.Drawing.Point(217, 318);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(99, 44);
            this.Insert.TabIndex = 24;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 347);
            this.dataGridView1.TabIndex = 31;
            // 
            // OilName
            // 
            this.OilName.DropDownHeight = 200;
            this.OilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OilName.FormattingEnabled = true;
            this.OilName.IntegralHeight = false;
            this.OilName.Location = new System.Drawing.Point(295, 240);
            this.OilName.Name = "OilName";
            this.OilName.Size = new System.Drawing.Size(111, 25);
            this.OilName.TabIndex = 32;
            this.OilName.SelectedIndexChanged += new System.EventHandler(this.OilName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(53, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "ราคาต่อลิตร";
            // 
            // pricePerLiter
            // 
            this.pricePerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pricePerLiter.Location = new System.Drawing.Point(217, 182);
            this.pricePerLiter.Name = "pricePerLiter";
            this.pricePerLiter.Size = new System.Drawing.Size(74, 23);
            this.pricePerLiter.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "วันที่";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(297, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "ลิตร";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(297, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "บาท";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Close.ForeColor = System.Drawing.Color.IndianRed;
            this.Close.Location = new System.Drawing.Point(334, 318);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(99, 44);
            this.Close.TabIndex = 40;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // OilPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricePerLiter);
            this.Controls.Add(this.OilName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OilTankID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OilVolumePurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseID);
            this.Name = "OilPurchase";
            this.Text = "OilPurchase";
            this.Load += new System.EventHandler(this.OilPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OilTankID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OilVolumePurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PurchaseID;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox OilName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricePerLiter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Close;
    }
}