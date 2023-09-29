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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสแทงค์น้ำมัน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ปริมาณสูงสุด";
            // 
            // oilTankId
            // 
            this.oilTankId.Location = new System.Drawing.Point(180, 57);
            this.oilTankId.Name = "oilTankId";
            this.oilTankId.Size = new System.Drawing.Size(201, 22);
            this.oilTankId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ปริมาณคงเหลือ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 246);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "รหัสน้ำมัน";
            // 
            // oilTankCapacity
            // 
            this.oilTankCapacity.Location = new System.Drawing.Point(180, 118);
            this.oilTankCapacity.Name = "oilTankCapacity";
            this.oilTankCapacity.Size = new System.Drawing.Size(201, 22);
            this.oilTankCapacity.TabIndex = 2;
            // 
            // oilVolume
            // 
            this.oilVolume.Location = new System.Drawing.Point(180, 184);
            this.oilVolume.Name = "oilVolume";
            this.oilVolume.Size = new System.Drawing.Size(201, 22);
            this.oilVolume.TabIndex = 2;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(410, 319);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(283, 319);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(173, 319);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 11;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(71, 319);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // oilId
            // 
            this.oilId.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.oilId.FormattingEnabled = true;
            this.oilId.Location = new System.Drawing.Point(272, 243);
            this.oilId.Name = "oilId";
            this.oilId.Size = new System.Drawing.Size(121, 24);
            this.oilId.TabIndex = 14;
            // 
            // oil_id
            // 
            this.oil_id.Location = new System.Drawing.Point(173, 243);
            this.oil_id.Name = "oil_id";
            this.oil_id.Size = new System.Drawing.Size(58, 22);
            this.oil_id.TabIndex = 15;
            // 
            // OilTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}