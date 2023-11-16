namespace DSVProgram
{
    partial class Waiter
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
            this.Label_NewOrder = new System.Windows.Forms.Label();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.Label_Bottom = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Label_Heater = new System.Windows.Forms.Label();
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
            this.DIAGViewerAUTH.Size = new System.Drawing.Size(870, 657);
            this.DIAGViewerAUTH.TabIndex = 4;
            // 
            // Label_NewOrder
            // 
            this.Label_NewOrder.AutoSize = true;
            this.Label_NewOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewOrder.Location = new System.Drawing.Point(915, 93);
            this.Label_NewOrder.Name = "Label_NewOrder";
            this.Label_NewOrder.Size = new System.Drawing.Size(68, 15);
            this.Label_NewOrder.TabIndex = 29;
            this.Label_NewOrder.Text = "New Order:";
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewName.Location = new System.Drawing.Point(1011, 91);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewName.TabIndex = 28;
            // 
            // Label_Bottom
            // 
            this.Label_Bottom.AutoSize = true;
            this.Label_Bottom.Font = new System.Drawing.Font("Calibri", 15F);
            this.Label_Bottom.Location = new System.Drawing.Point(914, 53);
            this.Label_Bottom.Name = "Label_Bottom";
            this.Label_Bottom.Size = new System.Drawing.Size(309, 24);
            this.Label_Bottom.TabIndex = 26;
            this.Label_Bottom.Text = "Create a new task for an employees";
            // 
            // Button_Add
            // 
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Location = new System.Drawing.Point(1148, 129);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 20;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Label_Heater
            // 
            this.Label_Heater.AutoSize = true;
            this.Label_Heater.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Heater.Location = new System.Drawing.Point(912, 12);
            this.Label_Heater.Name = "Label_Heater";
            this.Label_Heater.Size = new System.Drawing.Size(162, 33);
            this.Label_Heater.TabIndex = 19;
            this.Label_Heater.Text = "Control tasks";
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Label_NewOrder);
            this.Controls.Add(this.TextBox_NewName);
            this.Controls.Add(this.Label_Bottom);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Label_Heater);
            this.Controls.Add(this.DIAGViewerAUTH);
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter Console";
            this.Load += new System.EventHandler(this.Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DIAGViewerAUTH;
        private System.Windows.Forms.Label Label_NewOrder;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.Label Label_Bottom;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label Label_Heater;
    }
}