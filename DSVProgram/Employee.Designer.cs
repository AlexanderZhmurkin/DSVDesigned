namespace DSVProgram
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DIAGViewerAUTH = new System.Windows.Forms.DataGridView();
            this.Label_Order = new System.Windows.Forms.Label();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.Label_Bottom = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Label_Heater = new System.Windows.Forms.Label();
            this.ComboBox_NewMember = new System.Windows.Forms.ComboBox();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).BeginInit();
            this.SuspendLayout();
            // 
            // DIAGViewerAUTH
            // 
            this.DIAGViewerAUTH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DIAGViewerAUTH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DIAGViewerAUTH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DIAGViewerAUTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DIAGViewerAUTH.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.DIAGViewerAUTH.Location = new System.Drawing.Point(12, 12);
            this.DIAGViewerAUTH.Name = "DIAGViewerAUTH";
            this.DIAGViewerAUTH.Size = new System.Drawing.Size(809, 657);
            this.DIAGViewerAUTH.TabIndex = 3;
            // 
            // Label_Order
            // 
            this.Label_Order.AutoSize = true;
            this.Label_Order.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Order.Location = new System.Drawing.Point(842, 98);
            this.Label_Order.Name = "Label_Order";
            this.Label_Order.Size = new System.Drawing.Size(42, 15);
            this.Label_Order.TabIndex = 34;
            this.Label_Order.Text = "Order:";
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewName.Location = new System.Drawing.Point(938, 96);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewName.TabIndex = 33;
            // 
            // Label_Bottom
            // 
            this.Label_Bottom.AutoSize = true;
            this.Label_Bottom.Font = new System.Drawing.Font("Calibri", 15F);
            this.Label_Bottom.Location = new System.Drawing.Point(841, 58);
            this.Label_Bottom.Name = "Label_Bottom";
            this.Label_Bottom.Size = new System.Drawing.Size(247, 24);
            this.Label_Bottom.TabIndex = 32;
            this.Label_Bottom.Text = "Switch status order for tasks";
            // 
            // Button_Update
            // 
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Location = new System.Drawing.Point(993, 188);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 23);
            this.Button_Update.TabIndex = 31;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Label_Heater
            // 
            this.Label_Heater.AutoSize = true;
            this.Label_Heater.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Heater.Location = new System.Drawing.Point(839, 17);
            this.Label_Heater.Name = "Label_Heater";
            this.Label_Heater.Size = new System.Drawing.Size(162, 33);
            this.Label_Heater.TabIndex = 30;
            this.Label_Heater.Text = "Control tasks";
            // 
            // ComboBox_NewMember
            // 
            this.ComboBox_NewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ComboBox_NewMember.FormattingEnabled = true;
            this.ComboBox_NewMember.Location = new System.Drawing.Point(938, 141);
            this.ComboBox_NewMember.Name = "ComboBox_NewMember";
            this.ComboBox_NewMember.Size = new System.Drawing.Size(211, 24);
            this.ComboBox_NewMember.TabIndex = 36;
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Status.Location = new System.Drawing.Point(842, 143);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(79, 15);
            this.Label_Status.TabIndex = 35;
            this.Label_Status.Text = "Status Order:";
            // 
            // Button_Delete
            // 
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Location = new System.Drawing.Point(1074, 188);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 37;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.ComboBox_NewMember);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_Order);
            this.Controls.Add(this.TextBox_NewName);
            this.Controls.Add(this.Label_Bottom);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Label_Heater);
            this.Controls.Add(this.DIAGViewerAUTH);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Console";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DIAGViewerAUTH;
        private System.Windows.Forms.Label Label_Order;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.Label Label_Bottom;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Label Label_Heater;
        private System.Windows.Forms.ComboBox ComboBox_NewMember;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Button Button_Delete;
    }
}