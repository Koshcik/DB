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
    public partial class Items : Form
    {
        DataBase dataBase = new DataBase();
        public Items()
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


            var ttems_name = textBox49.Text;
            var Payment_per_hour = textBox50.Text;
            var Teacher= textBox39.Text;

            

            var addQuery = $"insert into Items values ('{ttems_name}','{Payment_per_hour}','{Teacher}')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            this.Hide();

            dataBase.closeConnection();
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
