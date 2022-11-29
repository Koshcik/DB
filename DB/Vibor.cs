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
using System.Drawing.Printing;

namespace DB
{
    public partial class Vibor : Form
    {
        DataBase dataBase = new DataBase();
        
        public Vibor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = Color.DarkRed;
        }

        private void Vibor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            log_in frm1 = new log_in();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print frm1 = new print();
            this.Hide();
            frm1.ShowDialog();
            this.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
