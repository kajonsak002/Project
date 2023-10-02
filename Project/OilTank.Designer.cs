namespace Project
{
    partial class OilTank
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oilTankId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oilTankCapacity = new System.Windows.Forms.TextBox();
            this.oilVolume = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.oilId = new System.Windows.Forms.ComboBox();
            this.oil_id = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสแทงค์น้ำมัน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ปริมาณสูงสุด";
            // 
            // oilTankId
            // 
            this.oilTankId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilTankId.Location = new System.Drawing.Point(247, 57);
            this.oilTankId.Name = "oilTankId";
            this.oilTankId.Size = new System.Drawing.Size(201, 23);
            this.oilTankId.TabIndex = 2;
            this.oilTankId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oilTankId_KeyDown);
            this.oilTankId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oilTankId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(83, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ปริมาณคงเหลือ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(83, 246);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "รหัสน้ำมัน";
            // 
            // oilTankCapacity
            // 
            this.oilTankCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilTankCapacity.Location = new System.Drawing.Point(248, 118);
            this.oilTankCapacity.Name = "oilTankCapacity";
            this.oilTankCapacity.Size = new System.Drawing.Size(201, 23);
            this.oilTankCapacity.TabIndex = 2;
            // 
            // oilVolume
            // 
            this.oilVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilVolume.Location = new System.Drawing.Point(248, 184);
            this.oilVolume.Name = "oilVolume";
            this.oilVolume.Size = new System.Drawing.Size(201, 23);
            this.oilVolume.TabIndex = 2;
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bDelete.Location = new System.Drawing.Point(311, 320);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 47);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bUpdate.Location = new System.Drawing.Point(221, 320);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 47);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bInsert.Location = new System.Drawing.Point(140, 320);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 47);
            this.bInsert.TabIndex = 11;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bNew.Location = new System.Drawing.Point(59, 320);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 47);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // oilId
            // 
            this.oilId.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.oilId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilId.FormattingEnabled = true;
            this.oilId.Location = new System.Drawing.Point(328, 243);
            this.oilId.Name = "oilId";
            this.oilId.Size = new System.Drawing.Size(121, 25);
            this.oilId.TabIndex = 14;
            this.oilId.SelectedIndexChanged += new System.EventHandler(this.oilId_SelectedIndexChanged);
            // 
            // oil_id
            // 
            this.oil_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oil_id.Location = new System.Drawing.Point(247, 243);
            this.oil_id.Name = "oil_id";
            this.oil_id.Size = new System.Drawing.Size(58, 23);
            this.oil_id.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 299);
            this.dataGridView1.TabIndex = 16;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Close.ForeColor = System.Drawing.Color.IndianRed;
            this.Close.Location = new System.Drawing.Point(392, 320);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 44);
            this.Close.TabIndex = 41;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // OilTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.oil_id);
            this.Controls.Add(this.oilId);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oilVolume);
            this.Controls.Add(this.oilTankCapacity);
            this.Controls.Add(this.oilTankId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OilTank";
            this.Text = "OilTank";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oilTankId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oilTankCapacity;
        private System.Windows.Forms.TextBox oilVolume;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.ComboBox oilId;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox oil_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button Close;
    }
}