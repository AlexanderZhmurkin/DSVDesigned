// Copyright AlexanderAL123 OISP-1-120. ALL RIGHTS RESERVED.

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSVProgram
{
    public partial class Waiter : Form
    {
        private String DATABASE_FileName = "DSVBD.db";
        private SQLiteConnection DATABASE_Connect;
        private SQLiteCommand DATABASE_Cmd;

        public Waiter()
        {
            InitializeComponent();
        }

        private void Waiter_Load(object sender, EventArgs e)
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
                    DATABASE_Cmd.CommandText = $"INSERT INTO {InTable} ('NameOrder', 'StatusOrder', 'DataCreate', 'PaidOrder') VALUES ('{TextBox_NewName.Text}' , 'Готовиться', '{DateTime.Now.ToString("MM/dd/yyyy - h:mm")}', '0')";
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
                return;
            }
        }

        void DELETING_BASE(string InTable)
        {
            if (DATABASE_Connect.State == ConnectionState.Open)
            {
                try
                {
                    //DATABASE_Cmd.CommandText = $"DELETE FROM {InTable} WHERE IDAuth LIKE '%{TextBox_DelAuth.Text}%'";
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
                return;
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            INSERTING_BASE("TaskUser");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            READING_BASED("TaskUser");
        }
    }
}
