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
    
    public partial class STUDENTS : Form
    {
        DataBase dataBase = new DataBase();
        public STUDENTS()
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

            var Last_name = textBox2.Text;
            var Name = textBox3.Text;
            var Middle_name = textBox4.Text;
            var Phone_number = textBox5.Text;
            var Address = textBox1.Text;


            var addQuery = $"insert into STUDENTS values ('{Last_name}','{Name}','{Middle_name}','{Phone_number}','{Address}')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            this.Hide();

            dataBase.closeConnection();
        }
    }
}
