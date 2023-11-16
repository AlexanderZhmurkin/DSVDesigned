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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.DIAGViewerAUTH = new System.Windows.Forms.DataGridView();
            this.Label_Heater = new System.Windows.Forms.Label();
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
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).BeginInit();
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
            this.DIAGViewerAUTH.Size = new System.Drawing.Size(864, 633);
            this.DIAGViewerAUTH.TabIndex = 2;
            this.DIAGViewerAUTH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DIAGViewerAUTH_CellContentClick);
            // 
            // Label_Heater
            // 
            this.Label_Heater.AutoSize = true;
            this.Label_Heater.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Heater.Location = new System.Drawing.Point(900, 29);
            this.Label_Heater.Name = "Label_Heater";
            this.Label_Heater.Size = new System.Drawing.Size(203, 33);
            this.Label_Heater.TabIndex = 5;
            this.Label_Heater.Text = "Control accounts";
            // 
            // Button_Add
            // 
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Location = new System.Drawing.Point(1135, 234);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Label_NewLogin
            // 
            this.Label_NewLogin.AutoSize = true;
            this.Label_NewLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewLogin.Location = new System.Drawing.Point(903, 112);
            this.Label_NewLogin.Name = "Label_NewLogin";
            this.Label_NewLogin.Size = new System.Drawing.Size(65, 15);
            this.Label_NewLogin.TabIndex = 8;
            this.Label_NewLogin.Text = "New Login:";
            // 
            // TextBox_NewLogin
            // 
            this.TextBox_NewLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewLogin.Location = new System.Drawing.Point(999, 110);
            this.TextBox_NewLogin.Name = "TextBox_NewLogin";
            this.TextBox_NewLogin.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewLogin.TabIndex = 7;
            // 
            // Label_NewPass
            // 
            this.Label_NewPass.AutoSize = true;
            this.Label_NewPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewPass.Location = new System.Drawing.Point(903, 152);
            this.Label_NewPass.Name = "Label_NewPass";
            this.Label_NewPass.Size = new System.Drawing.Size(90, 15);
            this.Label_NewPass.TabIndex = 10;
            this.Label_NewPass.Text = "New Password:";
            // 
            // TextBox_NewPass
            // 
            this.TextBox_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_NewPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NewPass.Location = new System.Drawing.Point(999, 150);
            this.TextBox_NewPass.Name = "TextBox_NewPass";
            this.TextBox_NewPass.Size = new System.Drawing.Size(211, 23);
            this.TextBox_NewPass.TabIndex = 9;
            // 
            // Label_NewMember
            // 
            this.Label_NewMember.AutoSize = true;
            this.Label_NewMember.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewMember.Location = new System.Drawing.Point(903, 191);
            this.Label_NewMember.Name = "Label_NewMember";
            this.Label_NewMember.Size = new System.Drawing.Size(55, 15);
            this.Label_NewMember.TabIndex = 12;
            this.Label_NewMember.Text = "Member:";
            // 
            // Label_Bottom
            // 
            this.Label_Bottom.AutoSize = true;
            this.Label_Bottom.Font = new System.Drawing.Font("Calibri", 15F);
            this.Label_Bottom.Location = new System.Drawing.Point(902, 70);
            this.Label_Bottom.Name = "Label_Bottom";
            this.Label_Bottom.Size = new System.Drawing.Size(332, 24);
            this.Label_Bottom.TabIndex = 15;
            this.Label_Bottom.Text = "Create new account for new employee";
            // 
            // ComboBox_NewMember
            // 
            this.ComboBox_NewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ComboBox_NewMember.FormattingEnabled = true;
            this.ComboBox_NewMember.Location = new System.Drawing.Point(999, 189);
            this.ComboBox_NewMember.Name = "ComboBox_NewMember";
            this.ComboBox_NewMember.Size = new System.Drawing.Size(211, 24);
            this.ComboBox_NewMember.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(902, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Find and delete account for employee";
            // 
            // Label_IDAuth
            // 
            this.Label_IDAuth.AutoSize = true;
            this.Label_IDAuth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_IDAuth.Location = new System.Drawing.Point(903, 380);
            this.Label_IDAuth.Name = "Label_IDAuth";
            this.Label_IDAuth.Size = new System.Drawing.Size(50, 15);
            this.Label_IDAuth.TabIndex = 20;
            this.Label_IDAuth.Text = "ID Auth:";
            // 
            // TextBox_DelAuth
            // 
            this.TextBox_DelAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DelAuth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_DelAuth.Location = new System.Drawing.Point(999, 378);
            this.TextBox_DelAuth.Name = "TextBox_DelAuth";
            this.TextBox_DelAuth.Size = new System.Drawing.Size(211, 23);
            this.TextBox_DelAuth.TabIndex = 19;
            // 
            // Button_Delete
            // 
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Location = new System.Drawing.Point(1135, 417);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 18;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Controls.Add(this.Label_Heater);
            this.Controls.Add(this.DIAGViewerAUTH);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DIAGViewerAUTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.DataGridView DIAGViewerAUTH;
        private System.Windows.Forms.Label Label_Heater;
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
    }
}

