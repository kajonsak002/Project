namespace Project
{
    partial class OilFiler
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
            this.New = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FillerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FillerID = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.New.Location = new System.Drawing.Point(76, 297);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(99, 44);
            this.New.TabIndex = 27;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Close.Location = new System.Drawing.Point(587, 297);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(99, 44);
            this.Close.TabIndex = 26;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Delete.Location = new System.Drawing.Point(462, 297);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 44);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Update.Location = new System.Drawing.Point(339, 297);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 44);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insert.Location = new System.Drawing.Point(209, 297);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(99, 44);
            this.Insert.TabIndex = 23;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "เบอร์โทรศัพท์";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PhoneNumber.Location = new System.Drawing.Point(173, 178);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(192, 30);
            this.PhoneNumber.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "ชื่อพนักงาน";
            // 
            // FillerName
            // 
            this.FillerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FillerName.Location = new System.Drawing.Point(173, 132);
            this.FillerName.Name = "FillerName";
            this.FillerName.Size = new System.Drawing.Size(192, 30);
            this.FillerName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "รหัสพนักงาน";
            // 
            // FillerID
            // 
            this.FillerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FillerID.Location = new System.Drawing.Point(173, 86);
            this.FillerID.Name = "FillerID";
            this.FillerID.Size = new System.Drawing.Size(192, 30);
            this.FillerID.TabIndex = 28;
            this.FillerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FillerID_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 234);
            this.dataGridView1.TabIndex = 34;
            // 
            // OilFiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FillerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FillerID);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "OilFiler";
            this.Text = "OilFiler";
            this.Load += new System.EventHandler(this.OilFiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FillerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FillerID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}