using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace DB
{
    public partial class print : Form
    {
        DataBase dataBase = new DataBase();
        public print()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }


        private void invisible_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            invisible.Visible = false;
            visible.Visible = true;
        }

        private void visible_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            visible.Visible = false;
            invisible.Visible = true;
        }


        private void print_Load(object sender, EventArgs e)
        {

        }

        private void visible_Click_1(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            visible.Visible = false;
            invisible.Visible = true;
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user ='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                // MessageBox.Show("Авторизация завершена успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                polz frm1 = new polz();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
    }

        
    

