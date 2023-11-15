// Copyright (c) PEPE POPO, OISP-1-120

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSVProgram
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        public bool SuccessfullyAuth = false;
        public bool SUCCESS_ADMIN = false;
        public bool SUCCESS_EMPLOYEE = false;
        public bool SUCCESS_WAITER = false;

        private void Auth_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "admin";
            textBoxPass.Text = "admin";
            labelInv.Visible = false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPass.Text == "")
            {
                labelInv.Visible = true;
            }
            else
            {
                string UniqueTypeEmployee = "ADMIN";
                string AuthQUERY = "SELECT * FROM AuthUser WHERE Login = @Login AND Password = @Password";
                string EmployeeQUERY = "INSERT * INTO AuthUser(Empl) VALUES (@Empl)";
                SQLiteConnection AuthCONNECTION = new SQLiteConnection("Data Source=DSVBD.db; Version=3;");
                SQLiteCommand AuthCOMMAND = new SQLiteCommand(AuthCONNECTION);
                AuthCONNECTION.Open();

                AuthCOMMAND.CommandText = AuthQUERY;
                AuthCOMMAND.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                AuthCOMMAND.Parameters.AddWithValue("@Password", textBoxPass.Text);

                SQLiteDataAdapter AuthADAPTER = new SQLiteDataAdapter(AuthCOMMAND);
                DataTable AuthDATATABLE = new DataTable();
                AuthADAPTER.Fill(AuthDATATABLE);

                if (AuthDATATABLE.Rows.Count > 0)
                {
                    SuccessfullyAuth = true;
                    if (UniqueTypeEmployee == "ADMIN") SUCCESS_ADMIN = true;
                    else if (UniqueTypeEmployee == "EMPLOYEE") SUCCESS_EMPLOYEE = true;
                    else if (UniqueTypeEmployee == "WAITER") SUCCESS_WAITER = true;
                    this.Close();
                    AuthCONNECTION.Close();
                }
                else
                {
                    SuccessfullyAuth = false;
                    labelInv.Visible = true;
                    AuthCONNECTION.Close();
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelInv.Visible = false;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            labelInv.Visible = false;
        }
    }
}