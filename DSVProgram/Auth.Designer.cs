namespace DSVProgram
{
    partial class Auth
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
            this.btnSignin = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Location = new System.Drawing.Point(347, 176);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(75, 23);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(81, 68);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(211, 23);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(15, 70);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 15);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(81, 111);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(211, 23);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(15, 113);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 15);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Authorization";
            // 
            // labelInv
            // 
            this.labelInv.AutoSize = true;
            this.labelInv.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelInv.ForeColor = System.Drawing.Color.Black;
            this.labelInv.Location = new System.Drawing.Point(15, 150);
            this.labelInv.Name = "labelInv";
            this.labelInv.Size = new System.Drawing.Size(93, 17);
            this.labelInv.TabIndex = 5;
            this.labelInv.Text = "{STATUS AUTH}";
            this.labelInv.Visible = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.labelInv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authform";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInv;
    }
}