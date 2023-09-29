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
            this.label3 = new System.Windows.Forms.Label();
            this.OilId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OilVolumePurchase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DispenderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(198, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "รหัสน้ำมัน";
            // 
            // OilId
            // 
            this.OilId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.OilId.Location = new System.Drawing.Point(362, 184);
            this.OilId.Name = "OilId";
            this.OilId.Size = new System.Drawing.Size(192, 30);
            this.OilId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(198, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "ปริมาณที่ซื้อ";
            // 
            // OilVolumePurchase
            // 
            this.OilVolumePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.OilVolumePurchase.Location = new System.Drawing.Point(362, 138);
            this.OilVolumePurchase.Name = "OilVolumePurchase";
            this.OilVolumePurchase.Size = new System.Drawing.Size(192, 30);
            this.OilVolumePurchase.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(198, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "เลขที่ใบซื้อน้ำมัน";
            // 
            // PurchaseID
            // 
            this.PurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PurchaseID.Location = new System.Drawing.Point(362, 92);
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(192, 30);
            this.PurchaseID.TabIndex = 18;
            this.PurchaseID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseID_KeyDown);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.New.Location = new System.Drawing.Point(142, 359);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(99, 44);
            this.New.TabIndex = 28;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Delete.Location = new System.Drawing.Point(530, 359);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 44);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Update.Location = new System.Drawing.Point(405, 359);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 44);
            this.Update.TabIndex = 25;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insert.Location = new System.Drawing.Point(275, 359);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(99, 44);
            this.Insert.TabIndex = 24;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(198, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "รหัสหัวจ่าย";
            // 
            // DispenderID
            // 
            this.DispenderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DispenderID.Location = new System.Drawing.Point(362, 232);
            this.DispenderID.Name = "DispenderID";
            this.DispenderID.Size = new System.Drawing.Size(192, 30);
            this.DispenderID.TabIndex = 29;
            // 
            // OilPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DispenderID);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OilId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OilVolumePurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseID);
            this.Name = "OilPurchase";
            this.Text = "OilPurchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OilId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OilVolumePurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PurchaseID;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DispenderID;
    }
}