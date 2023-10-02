namespace Project
{
    partial class Oil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.New = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.oilPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oilName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oilCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Density = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChemicalVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DensityValues = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 497);
            this.dataGridView1.TabIndex = 23;
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.New.Location = new System.Drawing.Point(18, 317);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(99, 44);
            this.New.TabIndex = 22;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Close.ForeColor = System.Drawing.Color.IndianRed;
            this.Close.Location = new System.Drawing.Point(216, 388);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(99, 44);
            this.Close.TabIndex = 21;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Delete.Location = new System.Drawing.Point(91, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 44);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Update.Location = new System.Drawing.Point(281, 317);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 44);
            this.Update.TabIndex = 19;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Insert.Location = new System.Drawing.Point(151, 317);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(99, 44);
            this.Insert.TabIndex = 18;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ราคาต่อลิตร";
            // 
            // oilPrice
            // 
            this.oilPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilPrice.Location = new System.Drawing.Point(186, 104);
            this.oilPrice.Name = "oilPrice";
            this.oilPrice.Size = new System.Drawing.Size(192, 23);
            this.oilPrice.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "ชื่อน้ำมัน";
            // 
            // oilName
            // 
            this.oilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilName.Location = new System.Drawing.Point(186, 58);
            this.oilName.Name = "oilName";
            this.oilName.Size = new System.Drawing.Size(192, 23);
            this.oilName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "รหัสน้ำมัน";
            // 
            // oilCode
            // 
            this.oilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilCode.Location = new System.Drawing.Point(186, 12);
            this.oilCode.Name = "oilCode";
            this.oilCode.Size = new System.Drawing.Size(192, 23);
            this.oilCode.TabIndex = 12;
            this.oilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oilCode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(22, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "ค่าความหนืด";
            // 
            // Density
            // 
            this.Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Density.Location = new System.Drawing.Point(186, 158);
            this.Density.Name = "Density";
            this.Density.Size = new System.Drawing.Size(192, 23);
            this.Density.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(22, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "ปริมาณสารตะกั่ว";
            // 
            // ChemicalVolume
            // 
            this.ChemicalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChemicalVolume.Location = new System.Drawing.Point(186, 204);
            this.ChemicalVolume.Name = "ChemicalVolume";
            this.ChemicalVolume.Size = new System.Drawing.Size(192, 23);
            this.ChemicalVolume.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(22, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "ค่าความหนาแน่น";
            // 
            // DensityValues
            // 
            this.DensityValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DensityValues.Location = new System.Drawing.Point(186, 250);
            this.DensityValues.Name = "DensityValues";
            this.DensityValues.Size = new System.Drawing.Size(192, 23);
            this.DensityValues.TabIndex = 30;
            // 
            // Oil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DensityValues);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChemicalVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Density);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oilPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oilName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oilCode);
            this.Name = "Oil";
            this.Text = "Oil";
            this.Load += new System.EventHandler(this.Oil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oilPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oilName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oilCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Density;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChemicalVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DensityValues;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}