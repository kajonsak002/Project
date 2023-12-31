﻿namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dispenserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oilName = new System.Windows.Forms.ComboBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.oilTankID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(85, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสหัวจ่าย";
            // 
            // dispenserId
            // 
            this.dispenserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dispenserId.Location = new System.Drawing.Point(176, 96);
            this.dispenserId.Name = "dispenserId";
            this.dispenserId.Size = new System.Drawing.Size(195, 23);
            this.dispenserId.TabIndex = 1;
            this.dispenserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dispenserId_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(85, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสแทงค์น้ำมัน";
            // 
            // oilName
            // 
            this.oilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilName.FormattingEnabled = true;
            this.oilName.Location = new System.Drawing.Point(250, 153);
            this.oilName.Name = "oilName";
            this.oilName.Size = new System.Drawing.Size(129, 25);
            this.oilName.TabIndex = 5;
            this.oilName.SelectedIndexChanged += new System.EventHandler(this.oilName_SelectedIndexChanged);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bNew.Location = new System.Drawing.Point(55, 262);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(83, 55);
            this.bNew.TabIndex = 6;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bInsert.Location = new System.Drawing.Point(144, 262);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(83, 55);
            this.bInsert.TabIndex = 7;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bUpdate.Location = new System.Drawing.Point(233, 262);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(83, 55);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bDelete.Location = new System.Drawing.Point(333, 262);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(83, 55);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // oilTankID
            // 
            this.oilTankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilTankID.Location = new System.Drawing.Point(185, 155);
            this.oilTankID.Name = "oilTankID";
            this.oilTankID.Size = new System.Drawing.Size(59, 23);
            this.oilTankID.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 245);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(333, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dispenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.oilTankID);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.oilName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dispenserId);
            this.Controls.Add(this.label1);
            this.Name = "Dispenser";
            this.Text = "Dispenser";
            this.Load += new System.EventHandler(this.Dispenser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dispenserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        public System.Windows.Forms.ComboBox oilName;
        private System.Windows.Forms.TextBox oilTankID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button button1;
    }
}