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
    public partial class Lessons : Form
    {
        DataBase dataBase = new DataBase();
        public Lessons()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();


                var Lesson_topic = textBox12.Text;
                var Number_of_hours = textBox13.Text;
                var Teacher = textBox14.Text;
                var Subject = textBox15.Text;
                var Task_type = textBox16.Text;
                var groups = textBox17.Text;

                var addQuery = $"insert into lessons values ('{Lesson_topic}','{Number_of_hours}','{Teacher}','{Subject}','{Task_type}','{groups}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                this.Hide();

                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка числовой формат");
            }
        }

        private void Lessons_Load(object sender, EventArgs e)
        {

        }
    }
}
