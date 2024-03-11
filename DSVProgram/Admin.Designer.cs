namespace DSVProgram
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.DIAGViewerAUTH = new System.Windows.Forms.DataGridView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Label_NewLogin = new System.Windows.Forms.Label();
            this.TextBox_NewLogin = new System.Windows.Forms.TextBox();
            this.Label_NewPass = new System.Windows.Forms.Label();
            this.TextBox_NewPass = new System.Windows.Forms.TextBox();
            this.Label_NewMember = new System.Windows.Forms.Label();
            this.Label_Bottom = new System.Windows.Forms.Label();
            this.ComboBox_NewMember = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_IDAuth = new System.Windows.Forms.Label();
            this.TextBox_DelAuth = new System.Windows.Forms.TextBox();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatusText
            // 
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(27, 17);
            this.lbStatusText.Text = "----";
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
            this.DIAGViewerAUTH.Location = new System.Drawing.Point(12, 75);
            this.DIAGViewerAUTH.Name = "DIAGViewerAUTH";
            this.DIAGViewerAUTH.Size = new System.Drawing.Size(750, 570);
            this.DIAGViewerAUTH.TabIndex = 2;
            this.DIAGViewerAUTH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DIAGViewerAUTH_CellContentClick);
            // 
            // Button_Add
            // 
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Location = new System.Drawing.Point(1109, 154);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(134, 63);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "Добавить сотрудника";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Label_NewLogin
            // 
            this.Label_NewLogin.AutoSize = true;
            this.Label_NewLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewLogin.Location = new System.Drawing.Point(787, 119);
            this.Label_NewLogin.Name = "Label_NewLogin";
            this.Label_NewLogin.Size = new System.Drawing.Size(83, 15);
            this.Label_NewLogin.TabIndex = 8;
            this.Label_NewLogin.Text = "Новый логин:";
            // 
            // TextBox_NewLogin
            // 
            this.TextBox_NewLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewLogin.Location = new System.Drawing.Point(883, 117);
            this.TextBox_NewLogin.Name = "TextBox_NewLogin";
            this.TextBox_NewLogin.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewLogin.TabIndex = 7;
            // 
            // Label_NewPass
            // 
            this.Label_NewPass.AutoSize = true;
            this.Label_NewPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewPass.Location = new System.Drawing.Point(787, 156);
            this.Label_NewPass.Name = "Label_NewPass";
            this.Label_NewPass.Size = new System.Drawing.Size(91, 15);
            this.Label_NewPass.TabIndex = 10;
            this.Label_NewPass.Text = "Новый пароль:";
            // 
            // TextBox_NewPass
            // 
            this.TextBox_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewPass.Location = new System.Drawing.Point(883, 154);
            this.TextBox_NewPass.Name = "TextBox_NewPass";
            this.TextBox_NewPass.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewPass.TabIndex = 9;
            // 
            // Label_NewMember
            // 
            this.Label_NewMember.AutoSize = true;
            this.Label_NewMember.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewMember.Location = new System.Drawing.Point(787, 195);
            this.Label_NewMember.Name = "Label_NewMember";
            this.Label_NewMember.Size = new System.Drawing.Size(72, 15);
            this.Label_NewMember.TabIndex = 12;
            this.Label_NewMember.Text = "Должность:";
            // 
            // Label_Bottom
            // 
            this.Label_Bottom.AutoSize = true;
            this.Label_Bottom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Bottom.Location = new System.Drawing.Point(786, 75);
            this.Label_Bottom.Name = "Label_Bottom";
            this.Label_Bottom.Size = new System.Drawing.Size(449, 23);
            this.Label_Bottom.TabIndex = 15;
            this.Label_Bottom.Text = "Создать новую учетную запись для нового сотрудника";
            // 
            // ComboBox_NewMember
            // 
            this.ComboBox_NewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ComboBox_NewMember.FormattingEnabled = true;
            this.ComboBox_NewMember.Location = new System.Drawing.Point(883, 193);
            this.ComboBox_NewMember.Name = "ComboBox_NewMember";
            this.ComboBox_NewMember.Size = new System.Drawing.Size(211, 24);
            this.ComboBox_NewMember.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(786, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Найти и удалить учетную запись сотрудника";
            // 
            // Label_IDAuth
            // 
            this.Label_IDAuth.AutoSize = true;
            this.Label_IDAuth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_IDAuth.Location = new System.Drawing.Point(787, 349);
            this.Label_IDAuth.Name = "Label_IDAuth";
            this.Label_IDAuth.Size = new System.Drawing.Size(50, 15);
            this.Label_IDAuth.TabIndex = 20;
            this.Label_IDAuth.Text = "ID Auth:";
            // 
            // TextBox_DelAuth
            // 
            this.TextBox_DelAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DelAuth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_DelAuth.Location = new System.Drawing.Point(883, 347);
            this.TextBox_DelAuth.Name = "TextBox_DelAuth";
            this.TextBox_DelAuth.Size = new System.Drawing.Size(211, 23);
            this.TextBox_DelAuth.TabIndex = 19;
            // 
            // Button_Delete
            // 
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Location = new System.Drawing.Point(1137, 345);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 18;
            this.Button_Delete.Text = "Уволить";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Список работников";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(787, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Имя:";
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewName.Location = new System.Drawing.Point(883, 233);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(786, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 57);
            this.label4.TabIndex = 29;
            this.label4.Text = "Имейте в виду, что при удалении сотрудника \r\nего учетная запись на некоторое врем" +
    "я станет деактивированной, \r\nа доступ к этой учетной записи будет утерян.";
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
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказыToolStripMenuItem,
            this.показатьЗаказыToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "Управление";
            // 
            // добавитьЗаказыToolStripMenuItem
            // 
            this.добавитьЗаказыToolStripMenuItem.Name = "добавитьЗаказыToolStripMenuItem";
            this.добавитьЗаказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьЗаказыToolStripMenuItem.Text = "Добавить заказы";
            this.добавитьЗаказыToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказыToolStripMenuItem_Click);
            // 
            // показатьЗаказыToolStripMenuItem
            // 
            this.показатьЗаказыToolStripMenuItem.Name = "показатьЗаказыToolStripMenuItem";
            this.показатьЗаказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.показатьЗаказыToolStripMenuItem.Text = "Показать заказы";
            this.показатьЗаказыToolStripMenuItem.Click += new System.EventHandler(this.показатьЗаказыToolStripMenuItem_Click);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_NewName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_IDAuth);
            this.Controls.Add(this.TextBox_DelAuth);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.ComboBox_NewMember);
            this.Controls.Add(this.Label_Bottom);
            this.Controls.Add(this.Label_NewMember);
            this.Controls.Add(this.Label_NewPass);
            this.Controls.Add(this.TextBox_NewPass);
            this.Controls.Add(this.Label_NewLogin);
            this.Controls.Add(this.TextBox_NewLogin);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.DIAGViewerAUTH);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.DataGridView DIAGViewerAUTH;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label Label_NewLogin;
        private System.Windows.Forms.TextBox TextBox_NewLogin;
        private System.Windows.Forms.Label Label_NewPass;
        private System.Windows.Forms.TextBox TextBox_NewPass;
        private System.Windows.Forms.Label Label_NewMember;
        private System.Windows.Forms.Label Label_Bottom;
        private System.Windows.Forms.ComboBox ComboBox_NewMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_IDAuth;
        private System.Windows.Forms.TextBox TextBox_DelAuth;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
    }
}

