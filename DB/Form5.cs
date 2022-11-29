using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB
{
    public partial class Form5 : Form
    {
        DataBase dataBase = new DataBase();
        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Create_Click_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string querystrng = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystrng, dataBase.getConnection());

            dataBase.openConnection();
            if (checkUser())

            {
                return;
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех");
                Form4 frm_login = new Form4();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnection();
        }
        private Boolean checkUser()
        {
            DataBase dataBase = new DataBase();
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user,login_user,password_user from register where login_user = '{loginUser}'and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользовательно уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
