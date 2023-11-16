// Copyright AlexanderAL123 OISP-1-120. ALL RIGHTS RESERVED.

using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DSVProgram
{
    public partial class Employee : Form
    {
        private String DATABASE_FileName = "DSVBD.db";
        private SQLiteConnection DATABASE_Connect;
        private SQLiteCommand DATABASE_Cmd;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DATABASE_Connect = new SQLiteConnection();
            DATABASE_Cmd = new SQLiteCommand();

            CONNECT_BASED();
            READING_BASED("TaskUser");
        }

        void CONNECT_BASED()
        {
            if (File.Exists(DATABASE_FileName))
            {
                try
                {
                    DATABASE_Connect = new SQLiteConnection("Data Source=" + DATABASE_FileName + ";Version=3;");
                    DATABASE_Cmd.Connection = DATABASE_Connect;
                    DATABASE_Connect.Open();
                }
                catch (SQLiteException exec)
                {
                    MessageBox.Show("" + exec.Message, Text);
                }
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
                }
                catch (SQLiteException exec)
                {
                    MessageBox.Show("" + exec.Message, Text);
                }
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка соединения с базой данных.", Text);
                return;
            }
        }

        void INSERTING_BASE(string InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                try
                {
                    //DATABASE_Cmd.CommandText = "INSERT INTO " + InTable + " ('Login', 'Password', 'Member') VALUES ('" + TextBox_NewLogin.Text + "' , '" + TextBox_NewPass.Text + "' , '" + UniqueTypeEmployee + "')";
                    DATABASE_Cmd.ExecuteNonQuery();
                    READING_BASED(InTable);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("SQL SYNTAX Error: " + ex.Message, Text);
                }
            }
            else
            {
                MessageBox.Show("Unknown database connection error", Text);
                return;
            }
        }

        void DELETING_BASE(string InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                try
                {
                    DATABASE_Cmd.CommandText = $"DELETE FROM {InTable} WHERE NameOrder LIKE '%{TextBox_NewName.Text}%'";
                    DATABASE_Cmd.ExecuteNonQuery();
                    READING_BASED(InTable);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("SQL SYNTAX Error: " + ex.Message, Text);
                }
            }
            else
            {
                MessageBox.Show("Unknown database connection error", Text);
                return;
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            DELETING_BASE("TaskUser");
        }
    }
}
