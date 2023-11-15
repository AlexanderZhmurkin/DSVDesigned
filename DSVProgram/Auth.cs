// Copyright AlexanderAL123, OISP-1-120. ALL RIGHTS RESERVED.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DSVProgram
{
    public partial class Auth : Form
    {
        //Провера для Program.cs для запуска режимов программы
        public bool SuccessfullyAuth = false;
        public bool SUCCESS_ADMIN = false;
        public bool SUCCESS_EMPLOYEE = false;
        public bool SUCCESS_WAITER = false;

        //Первые попытки локализации, очень неправильно, но все же...
        private String STATLOC_Auth = "Аутентификация";
        private String STATLOC_FailedAuth = "Ошибка аутентификации";
        private String STATLOC_WaitAuth = "Ожидание";
        private String STATLOC_EmptyTable = "База данных пуста";
        private String STATLOC_Invalid = "Неверный логин и пароль";

        //По умолчанию режим программы: Админ
        string UniqueTypeEmployee = "UNKDOWN";

        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "admin";
            textBoxPass.Text = "admin";
            labelInv.Text = STATLOC_Auth;
            labelInv.Visible = false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPass.Text == "")
            {
                labelInv.Text = STATLOC_Invalid;
                labelInv.ForeColor = Color.Red;
                labelInv.Visible = true;
            }
            else
            {
                labelInv.Text = STATLOC_Auth;
                labelInv.ForeColor = Color.Black;
                labelInv.Visible = true;

                DataTable AuthDATATABLE = new DataTable();
                SQLiteConnection AuthCONNECTION = new SQLiteConnection("Data Source=DSVBD.db; Version=3;");
                SQLiteCommand AuthCOMMAND = new SQLiteCommand(AuthCONNECTION);
                string AuthQUERY = "SELECT * FROM AuthUser WHERE Login = @Login AND Password = @Password";

                AuthCONNECTION.Open();

                AuthCOMMAND.CommandText = AuthQUERY;
                AuthCOMMAND.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                AuthCOMMAND.Parameters.AddWithValue("@Password", textBoxPass.Text);
                AuthCOMMAND.ExecuteNonQuery();

                SQLiteDataAdapter AuthADAPTER = new SQLiteDataAdapter(AuthCOMMAND);
                AuthADAPTER.Fill(AuthDATATABLE);

                using (SQLiteDataReader AuthREADER = AuthCOMMAND.ExecuteReader())
                {
                    if (AuthREADER.HasRows)
                    {
                        while (AuthREADER.Read())
                        {
                            UniqueTypeEmployee = AuthREADER.GetString(3);
                        }

                        SuccessfullyAuth = true;
                        labelInv.Visible = false;
                        if (UniqueTypeEmployee == "ADMIN") SUCCESS_ADMIN = true;
                        else if (UniqueTypeEmployee == "EMPLOYEE") SUCCESS_EMPLOYEE = true;
                        else if (UniqueTypeEmployee == "WAITER") SUCCESS_WAITER = true;
                        this.Close();
                        AuthCONNECTION.Close();
                    }
                    else
                    {
                        SuccessfullyAuth = false;
                        labelInv.Text = STATLOC_FailedAuth;
                        labelInv.ForeColor = Color.Red;
                        labelInv.Visible = true;
                        AuthCONNECTION.Close();
                    }
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