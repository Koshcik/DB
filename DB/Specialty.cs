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
    public partial class Specialty : Form
    {
        DataBase dataBase = new DataBase();
        public Specialty()
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


            var Name_of_the_specialty = textBox56.Text;
            


            var addQuery = $"insert into Specialty  values ('{Name_of_the_specialty }')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            this.Hide();

            dataBase.closeConnection();
        }
    }
}
