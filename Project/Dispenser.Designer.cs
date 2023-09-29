namespace Project
{
    partial class Dispenser
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
            this.label1 = new System.Windows.Forms.Label();
            this.dispenserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oilTankId = new System.Windows.Forms.ComboBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.meterNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสหัวจ่าย";
            // 
            // dispenserId
            // 
            this.dispenserId.Location = new System.Drawing.Point(167, 81);
            this.dispenserId.Name = "dispenserId";
            this.dispenserId.Size = new System.Drawing.Size(195, 22);
            this.dispenserId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสแทงค์น้ำมัน";
            // 
            // oilTankId
            // 
            this.oilTankId.FormattingEnabled = true;
            this.oilTankId.Location = new System.Drawing.Point(194, 188);
            this.oilTankId.Name = "oilTankId";
            this.oilTankId.Size = new System.Drawing.Size(168, 24);
            this.oilTankId.TabIndex = 5;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(75, 262);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 6;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(177, 262);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 7;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(287, 262);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(414, 262);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // meterNumber
            // 
            this.meterNumber.Location = new System.Drawing.Point(167, 133);
            this.meterNumber.Name = "meterNumber";
            this.meterNumber.Size = new System.Drawing.Size(195, 22);
            this.meterNumber.TabIndex = 3;
            // 
            // Dispenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.oilTankId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meterNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dispenserId);
            this.Controls.Add(this.label1);
            this.Name = "Dispenser";
            this.Text = "Dispenser";
            this.Load += new System.EventHandler(this.Dispenser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dispenserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        public System.Windows.Forms.ComboBox oilTankId;
        private System.Windows.Forms.TextBox meterNumber;
    }
}