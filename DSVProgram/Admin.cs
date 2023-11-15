// Copyright AlexanderAL123 OISP-1-120. ALL RIGHTS RESERVED.

using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DSVProgram
{
    public partial class Admin : Form
    {
        //Первые попытки локализации, очень неправильно, но все же...
        private String STATLOC_Connected = "Подключен";
        private String STATLOC_Disconnected = "Отключен";
        private String STATLOC_Wait = "Ожидание";
        private String STATLOC_Error = "Ошибка";
        private String STATLOC_EmptyTable = "База данных пуста";
        private String STATLOC_Select = "Выбрана ячейка";

        private String DATABASE_FileName = "DSVBD.db";
        private SQLiteConnection DATABASE_Connect;
        private SQLiteCommand DATABASE_Cmd;

        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DATABASE_Connect = new SQLiteConnection();
            DATABASE_Cmd = new SQLiteCommand();
            lbStatusText.Text = STATLOC_Wait;
            CONNECT_BASED();
        }

        void CONNECT_BASED()
        {
            lbStatusText.Text = STATLOC_Wait;
            if (File.Exists(DATABASE_FileName))
            {
                try
                {
                    DATABASE_Connect = new SQLiteConnection("Data Source=" + DATABASE_FileName + ";Version=3;");
                    DATABASE_Cmd.Connection = DATABASE_Connect;
                    DATABASE_Connect.Open();
                    lbStatusText.Text = STATLOC_Connected;
                }
                catch (SQLiteException exec)
                {
                    lbStatusText.Text = STATLOC_Disconnected;
                    MessageBox.Show(STATLOC_Error + ": " + exec.Message, Text);
                }
            }
            else
            {
                lbStatusText.Text = STATLOC_Error;
            }
        }

        void READING_BASED(String InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                DataTable DBTable = new DataTable();
                try
                {
                    String SQLRequest = "SELECT * FROM " + InTable;
                    SQLiteDataAdapter SQLAdapt = new SQLiteDataAdapter(SQLRequest, DATABASE_Connect);
                    SQLAdapt.Fill(DBTable);

                    if (DBTable.Rows.Count > 0)
                    {
                        DIAGViewerAUTH.Update();
                        DIAGViewerAUTH.DataSource = DBTable;
                    }
                    else lbStatusText.Text = STATLOC_EmptyTable;
                }
                catch (SQLiteException exec)
                {
                    MessageBox.Show(STATLOC_Error + ": " + exec.Message, Text);
                }
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка соединения с базой данных.", Text);
                lbStatusText.Text = STATLOC_Disconnected;
                return;
            }
        }

        void INSERTING_BASE(string InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                try
                {
                    DATABASE_Cmd.CommandText = "INSERT INTO " + InTable + " ('Login', 'Password', 'Member') VALUES ('" + textBoxLogin.Text + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "')";
                    DATABASE_Cmd.ExecuteNonQuery();
                    READING_BASED(InTable);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка соединения с базой данных.", Text);
                lbStatusText.Text = STATLOC_Disconnected;
                return;
            }
        }

        void DELETING_BASE(string InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                try
                {
                    DATABASE_Cmd.CommandText = "DELETE FROM " + InTable + " WHERE Login LIKE " + "'%" + textBox3.Text + "%'";
                    DATABASE_Cmd.ExecuteNonQuery();
                    DIAGViewerAUTH.Update();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка соединения с базой данных.", Text);
                lbStatusText.Text = STATLOC_Disconnected;
                return;
            }
        }

        private void btTabAuth_Click(object sender, EventArgs e)
        {
            READING_BASED("AuthUser");
        }

        private void btTabTasks_Click(object sender, EventArgs e)
        {
            READING_BASED("TaskUser");
        }

        private void DIAGViewerAUTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbStatusText.Text = STATLOC_Select;

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            INSERTING_BASE("AuthUser");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DELETING_BASE("AuthUser");
        }
    }
}