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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.Label_NewOrder = new System.Windows.Forms.Label();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DIAGViewerAUTH = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_NewOrder
            // 
            this.Label_NewOrder.AutoSize = true;
            this.Label_NewOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewOrder.Location = new System.Drawing.Point(780, 118);
            this.Label_NewOrder.Name = "Label_NewOrder";
            this.Label_NewOrder.Size = new System.Drawing.Size(82, 15);
            this.Label_NewOrder.TabIndex = 29;
            this.Label_NewOrder.Text = "Новый заказ:";
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewName.Location = new System.Drawing.Point(876, 116);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewName.TabIndex = 28;
            // 
            // Button_Add
            // 
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Location = new System.Drawing.Point(783, 158);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(111, 50);
            this.Button_Add.TabIndex = 20;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(779, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Контролировать заказы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(779, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Официант может только создавать и просматривать заказы.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Список заказов";
            // 
            // DIAGViewerAUTH
            // 
            this.DIAGViewerAUTH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DIAGViewerAUTH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DIAGViewerAUTH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DIAGViewerAUTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DIAGViewerAUTH.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.DIAGViewerAUTH.Location = new System.Drawing.Point(12, 76);
            this.DIAGViewerAUTH.Name = "DIAGViewerAUTH";
            this.DIAGViewerAUTH.Size = new System.Drawing.Size(750, 570);
            this.DIAGViewerAUTH.TabIndex = 34;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DIAGViewerAUTH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_NewOrder);
            this.Controls.Add(this.TextBox_NewName);
            this.Controls.Add(this.Button_Add);
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Официант";
            this.Load += new System.EventHandler(this.Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_NewOrder;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DIAGViewerAUTH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
    }
}