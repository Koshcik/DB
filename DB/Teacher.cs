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
    public partial class Teacher : Form
    {
        DataBase dataBase = new DataBase();
        public Teacher()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


            var Last_name = textBox21.Text;
            var Name = textBox22.Text;
            var Middle_name = textBox23.Text;
            var Phone_number = textBox24.Text;
            var Work_experience = textBox19.Text;
            

            var addQuery = $"insert into Teacher  values ('{Last_name}','{Name}','{Middle_name}','{Phone_number}','{Work_experience}')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            this.Hide();

            dataBase.closeConnection();
        }
    }
}
