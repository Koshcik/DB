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
    enum RowState //Методы"Модификаторы".................................................................................................................................................
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        int selectedRow;
        private string result = "";
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Стартовая позиция............................................................................................................
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 1;
            button3.FlatAppearance.BorderColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 1;
            button4.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button38.FlatStyle = FlatStyle.Flat;
            button38.FlatAppearance.BorderSize = 1;
            button38.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button63.FlatStyle = FlatStyle.Flat;
            button63.FlatAppearance.BorderSize = 1;
            button63.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button37.FlatStyle = FlatStyle.Flat;
            button37.FlatAppearance.BorderSize = 1;
            button37.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            //Cтуденты
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 1;
            button10.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 1;
            button11.FlatAppearance.BorderColor = Color.Red;
            button55.FlatStyle = FlatStyle.Flat;
            button55.FlatAppearance.BorderSize = 1;
            button55.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 1;
            button12.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button64.FlatStyle = FlatStyle.Flat;
            button64.FlatAppearance.BorderSize = 1;
            button64.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 1;
            button9.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            button40.FlatStyle = FlatStyle.Flat;
            button40.FlatAppearance.BorderSize = 1;
            button40.FlatAppearance.BorderColor = Color.FromArgb(89, 190, 160);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;



        }



        //Группа..........................................................................................................................................................................
        private void CreateColumns()//Метод создания....................................................................................................................................
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Group_number", "Код группы");
            dataGridView1.Columns.Add("Specialty", "Код спецальности");
            dataGridView1.Columns.Add("Department", "Код Отделение");
            dataGridView1.Columns.Add("Number_of_students", "Код кол-во студентов");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dqw, IDataRecord record)//Тип данных......................................................................................................
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dqw)//Метод Обнавление.................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from groups";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dqw, reader);
            }
            reader.Close();
            button4.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)//Форма.......................................................................................................................
        {
            CreateColumns();//1
            RefreshDataGrid(dataGridView1);//1
            CreateColumns2();//2
            RefreshDataGrid2(dataGridView2);//2
            CreateColumns3();//3
            RefreshDataGrid3(dataGridView3);//3
            CreateColumns4();//4
            RefreshDataGrid4(dataGridView4);//4
            CreateColumns5();//5
            RefreshDataGrid5(dataGridView5);//5
            CreateColumns6();//6
            RefreshDataGrid6(dataGridView6);//6
            CreateColumns7();//7
            RefreshDataGrid7(dataGridView7);//7
            CreateColumns8();//8
            RefreshDataGrid8(dataGridView8);//8
            CreateColumns9();//9
            RefreshDataGrid9(dataGridView9);//9
        }


        private void button1_Click(object sender, EventArgs e)//Кнопка Новой записи....................................................................................................... 
        {


            Form2 addTP = new Form2();
            addTP.Show();

        }
        private void button37_Click(object sender, EventArgs e) //Кнопка обнавления......................................................................................................
        {
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//Считывания данных с таблицы......................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
            }

        }
        private void textBox18_TextChanged(object sender, EventArgs e)//Поиск.............................................................................................................
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)//Метод поиска................................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from groups  where concat (code,Group_number,Specialty,Department,Number_of_students) like '%" + textBox18.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void deleteRow()//Метод удаления.........................................................................................................................................
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)//Кнопка удаления..........................................................................................................
        {
            deleteRow();


        }
        private void Update()//Метод сохранения.........................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from groups where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var Group_number = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var Specialty = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var Department = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var Number_of_students = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var changeQuery = $"update groups set Group_number= '{Group_number}',Specialty='{Specialty}',Department='{Department}',Number_of_students='{Number_of_students}'where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка такого отделения не существует" + ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)//Кнопка сохранения........................................................................................................
        {
            Update();
        }
        private void Chande()//Метод изменения
        {
            try
            {
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                var code = textBox1.Text;
                var Group_number = textBox2.Text;
                int Specialty;                 //изменение
                int Department;
                int Number_of_students;
                if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
                {
                    if (int.TryParse(textBox5.Text, out Number_of_students))
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(code, Group_number, Number_of_students);
                        dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

                    }
                    else
                    {
                        MessageBox.Show("числовой формат");
                    }
                    if (int.TryParse(textBox4.Text, out Department))
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(code, Group_number, Department, Number_of_students);
                        dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

                    }
                    else
                    {
                        MessageBox.Show("числовой формат");
                    }
                    if (int.TryParse(textBox3.Text, out Specialty))
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(code, Group_number, Specialty, Department, Number_of_students);
                        dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

                    }
                    else
                    {
                        MessageBox.Show("числовой формат");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка id имеет числовой фотмат \r\n " + ex);

            }
        }
        //Студенты................................................................................................................................................................................
        private void CreateColumns2()//Метод создания.................................................................................................................................... 
        {
            dataGridView2.Columns.Add("code", "code");
            dataGridView2.Columns.Add("Last_name", "Отчество");//Cоздание колонки
            dataGridView2.Columns.Add("Name", "Имя");
            dataGridView2.Columns.Add("Middle_name", "Фамилия");
            dataGridView2.Columns.Add("Phone_number", "Номер телефона");//code Last_name Name Middle_name Phone_number Address
            dataGridView2.Columns.Add("Address", "Адрес");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow2(DataGridView dqw, IDataRecord record)//Тип данных.....................................................................................................
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid2(DataGridView dqw)//Метод обнавления..................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from STUDENTS";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow2(dqw, reader);
            }
            reader.Close();
            button12.Visible = true;
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }





        private void button38_Click(object sender, EventArgs e)
        {

        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button4_Click(object sender, EventArgs e)//Кнопка изменения.........................................................................................................
        {
            Chande();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            STUDENTS addTP = new STUDENTS();
            addTP.Show();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)//Поиск..............................................................................................................
        {
            Search2(dataGridView2);
        }

        private void button40_Click(object sender, EventArgs e)//Обнавление................................................................................................................
        {
            RefreshDataGrid2(dataGridView2);
        }

        private void button11_Click(object sender, EventArgs e)//Удаление...................................................................................................................
        {
            deleteRow2();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }
        private void Search2(DataGridView dgw)//Метод поиска...........................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from STUDENTS where concat (code,Last_name, Name, Middle_name, Phone_number, Address) like '%" + textBox25.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)//Считывания данных с таблицы....................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                textBox6.Text = row.Cells[0].Value.ToString();
                textBox7.Text = row.Cells[1].Value.ToString();
                textBox8.Text = row.Cells[2].Value.ToString();
                textBox9.Text = row.Cells[3].Value.ToString();
                textBox10.Text = row.Cells[4].Value.ToString();
                textBox38.Text = row.Cells[5].Value.ToString();
            }

        }

        private void Update2()//Метод сохранения.........................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView2.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView2.Rows[index].Cells[6].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from STUDENTS where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView2.Rows[index].Cells[0].Value.ToString();
                        var Last_name = dataGridView2.Rows[index].Cells[1].Value.ToString();
                        var Name = dataGridView2.Rows[index].Cells[2].Value.ToString();
                        var Middle_name = dataGridView2.Rows[index].Cells[3].Value.ToString();
                        var Phone_number = dataGridView2.Rows[index].Cells[4].Value.ToString();
                        var Address = dataGridView2.Rows[index].Cells[5].Value.ToString();
                        var changeQuery = $"update STUDENTS set Last_name= '{Last_name}',Name='{Name}',Middle_name='{Middle_name}',Phone_number='{Phone_number}',Address='{Address}'where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button12.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        private void button9_Click(object sender, EventArgs e)//Сохранение...............................................................................................................
        {
            Update2();
        }
        private void deleteRow2()//Метод удаления........................................................................................................................................
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;
            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[6].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView2.Rows[index].Cells[6].Value = RowState.Deleted;
            button12.Visible = false;

        }
        private void Chande2()//Метод изменения...........................................................................................................................................
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox6.Text;
            var Last_name = textBox7.Text;
            var Name = textBox8.Text;                 //изменение
            var Middle_name = textBox9.Text;
            var Phone_number = textBox10.Text;
            var Address = textBox38.Text;

            dataGridView2.Rows[selectedRowIndex].SetValues(code, Last_name, Name, Middle_name, Phone_number, Address);
            dataGridView2.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
        }
        private void button12_Click(object sender, EventArgs e)//Изменение.................................................................................................................
        {
            Chande2();
        }

        //Занятия........................................................................................................................................................................
        private void CreateColumns3()//Метод создания.................................................................................................................................... 
        {
            dataGridView3.Columns.Add("code", "code");
            dataGridView3.Columns.Add("Lesson_topic", "Темы занятий");//Cоздание колонки
            dataGridView3.Columns.Add("Number_of_hours", "Кол-во часов");
            dataGridView3.Columns.Add("Teacher", "Преподователь");
            dataGridView3.Columns.Add("Subject", "Предмет");//code Lesson_topic Number_of_hours Teacher Subject Task_type groups
            dataGridView3.Columns.Add("Task_type", "Тип занятий");
            dataGridView3.Columns.Add("groups", "Группа");
            dataGridView3.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow3(DataGridView dqw, IDataRecord record)//Тип данных....................................................................................................
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), RowState.ModifiedNew);
        }
        private void RefreshDataGrid3(DataGridView dqw)//Метод обнавления.................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Lessons";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow3(dqw, reader);
            }
            reader.Close();
            button8.Visible = true;
        }
        private void Search3(DataGridView dgw)//Метод Поиска...........................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Lessons where concat (code, Lesson_topic, Number_of_hours, Teacher, Subject, Task_type, groups) like '%" + textBox26.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow3(dgw, read);
            }
            read.Close();
        }
        private void Update3()//Метод сохранения............................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView3.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView3.Rows[index].Cells[7].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Lessons where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView3.Rows[index].Cells[0].Value.ToString();
                        var Lesson_topic = dataGridView3.Rows[index].Cells[1].Value.ToString();
                        var Number_of_hours = dataGridView3.Rows[index].Cells[2].Value.ToString();
                        var Teacher = dataGridView3.Rows[index].Cells[3].Value.ToString();
                        var Subject = dataGridView3.Rows[index].Cells[4].Value.ToString();
                        var Task_type = dataGridView3.Rows[index].Cells[5].Value.ToString();
                        var groups = dataGridView3.Rows[index].Cells[6].Value.ToString();

                        var changeQuery = $"update Lessons set Lesson_topic= '{Lesson_topic}',Number_of_hours='{Number_of_hours}',Teacher='{Teacher}',Subject='{Subject}',Task_type='{Task_type}',groups='{groups}'where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    button8.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка пользователя с таким ID не существует" + ex);
            }
            dataBase.closeConnection();
            button4.Visible = true;
        }
        private void deleteRow3()//метод удаления..........................................................................................................................................
        {
            int index = dataGridView3.CurrentCell.RowIndex;
            dataGridView3.Rows[index].Visible = false;
            if (dataGridView3.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted;
            button8.Visible = false;

        }
        private void Chande3()//Метод изменения...........................................................................................................................................
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox11.Text;
            var Lesson_topic = textBox12.Text;
            var Number_of_hours = textBox13.Text;                 //изменение
            var Teacher = textBox14.Text;
            var Subject = textBox15.Text;
            var Task_type = textBox16.Text;
            var groups = textBox17.Text;


            dataGridView3.Rows[selectedRowIndex].SetValues(code, Lesson_topic, Number_of_hours, Teacher, Subject, Task_type, groups);
            dataGridView3.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
        }

        private void button6_Click(object sender, EventArgs e)//Добавление................................................................................................................
        {
            Lessons addTP = new Lessons();
            addTP.Show();
        }

        private void button7_Click(object sender, EventArgs e)//удаление..................................................................................................................
        {
            deleteRow3();
        }

        private void button8_Click(object sender, EventArgs e)//Изменение.................................................................................................................
        {
            Chande3();
        }

        private void button5_Click(object sender, EventArgs e)//Сохранение.................................................................................................................
        {
            Update3();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)//Поиск.............................................................................................................
        {
            Search3(dataGridView3);
        }

        private void button42_Click(object sender, EventArgs e)//обнавление...............................................................................................................
        {
            RefreshDataGrid3(dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)//Считывания данных с таблицы....................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];
                textBox11.Text = row.Cells[0].Value.ToString();
                textBox12.Text = row.Cells[1].Value.ToString();
                textBox13.Text = row.Cells[2].Value.ToString();
                textBox14.Text = row.Cells[3].Value.ToString();
                textBox15.Text = row.Cells[4].Value.ToString();
                textBox16.Text = row.Cells[5].Value.ToString();
                textBox17.Text = row.Cells[6].Value.ToString();
            }
        }


        //Преподователи..................................................................................................................................................................
        private void CreateColumns4()//Метод создания....................................................................................................................................
        {
            dataGridView4.Columns.Add("code", "code");
            dataGridView4.Columns.Add("Last_name ", "Фамилия");//Cоздание колонки
            dataGridView4.Columns.Add("Name ", "Имя");
            dataGridView4.Columns.Add("Middle_name ", "Отчество");
            dataGridView4.Columns.Add("Phone_number ", "Номер телефона");//code Lesson_topic Number_of_hours Teacher Subject Task_type groups
            dataGridView4.Columns.Add("Work_experience ", "Стаж работы");
            dataGridView4.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow4(DataGridView dqw, IDataRecord record)//Тип данных......................................................................................................
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid4(DataGridView dqw)//Метод обнавления................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Teacher";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow4(dqw, reader);
            }
            reader.Close();
            button16.Visible = true;
        }
        private void Search4(DataGridView dgw)//Метод поиска..............................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Teacher where concat (code, Last_name , Name , Middle_name , Phone_number , Work_experience) like '%" + textBox30.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow4(dgw, read);
            }
            read.Close();
        }
        private void Update4()//Метод сохранения........................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView4.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView4.Rows[index].Cells[6].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Teacher where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView4.Rows[index].Cells[0].Value.ToString();
                        var Last_name = dataGridView4.Rows[index].Cells[1].Value.ToString();
                        var Name = dataGridView4.Rows[index].Cells[2].Value.ToString();
                        var Middle_name = dataGridView4.Rows[index].Cells[3].Value.ToString();
                        var Phone_number = dataGridView4.Rows[index].Cells[4].Value.ToString();
                        var Work_experience = dataGridView4.Rows[index].Cells[5].Value.ToString();
                        var changeQuery = $"update Teacher set Last_name= '{Last_name}',Name='{Name}',Middle_name='{Middle_name}',Phone_number='{Phone_number}',Work_experience='{Work_experience}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button16.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка числовой формат ID \r\n" + ex);
            }
        }
        private void deleteRow4()//Метод удаления........................................................................................................................................
        {
            int index = dataGridView4.CurrentCell.RowIndex;
            dataGridView4.Rows[index].Visible = false;
            if (dataGridView4.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView4.Rows[index].Cells[6].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView4.Rows[index].Cells[6].Value = RowState.Deleted;
            button16.Visible = false;

        }
        private void Chande4()//Метод изменения..........................................................................................................................................
        {
            var selectedRowIndex = dataGridView4.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox20.Text;
            var Last_name = textBox21.Text;
            var Name = textBox22.Text;                 //изменение
            var Middle_name = textBox23.Text;
            var Phone_number = textBox24.Text;
            var Work_experience = textBox19.Text;


            dataGridView4.Rows[selectedRowIndex].SetValues(code, Last_name, Name, Middle_name, Phone_number, Work_experience);
            dataGridView4.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)//Добавление.............................................................................................................
        {
            Teacher addTP = new Teacher();
            addTP.Show();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)//Поиск............................................................................................................
        {
            Search4(dataGridView4);
        }

        private void button44_Click(object sender, EventArgs e)//Обнавление..............................................................................................................
        {
            RefreshDataGrid4(dataGridView4);
        }

        private void button15_Click(object sender, EventArgs e)//Удаление..............................................................................................................
        {
            deleteRow4();
        }

        private void button16_Click(object sender, EventArgs e)//Изменение..............................................................................................................
        {
            Chande4();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)//Считывание с таблицы..............................................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];
                textBox20.Text = row.Cells[0].Value.ToString();
                textBox21.Text = row.Cells[1].Value.ToString();
                textBox22.Text = row.Cells[2].Value.ToString();
                textBox23.Text = row.Cells[3].Value.ToString();
                textBox24.Text = row.Cells[4].Value.ToString();
                textBox19.Text = row.Cells[5].Value.ToString();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Update4();
        }


        //Типы занятий......................................................................................................................................................................
        private void CreateColumns5()//Метод создания....................................................................................................................................
        {
            dataGridView5.Columns.Add("code", "code");
            dataGridView5.Columns.Add("Type_name", "Название занятий");//Cоздание колонки
            dataGridView5.Columns.Add("Payment", "Оплата");
            dataGridView5.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow5(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid5(DataGridView dqw)//Метод Обнавление..............................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Types_of_classes ";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow5(dqw, reader);
            }
            reader.Close();
            button20.Visible = true;
        }
        private void Search5(DataGridView dgw)//Метод поиска..............................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Types_of_classes  where concat (code, Type_name , Payment ) like '%" + textBox31.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow5(dgw, read);
            }
            read.Close();
        }
        private void Update5()//Метод Сохранения..............................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView5.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView5.Rows[index].Cells[3].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView5.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Types_of_classes  where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView5.Rows[index].Cells[0].Value.ToString();
                        var Type_name = dataGridView5.Rows[index].Cells[1].Value.ToString();
                        var Payment = dataGridView5.Rows[index].Cells[2].Value.ToString();

                        var changeQuery = $"update Types_of_classes  set Type_name= '{Type_name}',Payment='{Payment}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button20.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ID имеет числовой формат\r\n" + ex);
            }
        }
        private void deleteRow5()//Метод удаления..............................................................................................................
        {
            int index = dataGridView5.CurrentCell.RowIndex;
            dataGridView5.Rows[index].Visible = false;
            if (dataGridView5.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView5.Rows[index].Cells[3].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView5.Rows[index].Cells[3].Value = RowState.Deleted;
            button20.Visible = false;

        }
        private void Chande5()//Метод изменения..............................................................................................................
        {
            var selectedRowIndex = dataGridView5.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox27.Text;
            var Type_name = textBox28.Text;
            var Payment = textBox29.Text;                 //изменение

            dataGridView5.Rows[selectedRowIndex].SetValues(code, Type_name, Payment);
            dataGridView5.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
        }

        private void button18_Click(object sender, EventArgs e)//Добавление..............................................................................................................
        {
            Types_of_classes addTP = new Types_of_classes();
            addTP.Show();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)//Поиск..............................................................................................................
        {
            Search5(dataGridView5);
        }

        private void button46_Click(object sender, EventArgs e)//Обнавление..............................................................................................................
        {
            RefreshDataGrid5(dataGridView5);
        }

        private void button19_Click(object sender, EventArgs e)//Удаление..............................................................................................................
        {
            deleteRow5();
        }

        private void button20_Click(object sender, EventArgs e)//Изменение..............................................................................................................
        {
            Chande5();
        }

        private void button17_Click(object sender, EventArgs e)//Сохранение..............................................................................................................
        {
            Update5();
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)//Считывание с таблицы..............................................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[selectedRow];
                textBox27.Text = row.Cells[0].Value.ToString();
                textBox28.Text = row.Cells[1].Value.ToString();
                textBox29.Text = row.Cells[2].Value.ToString();




            }
        }
        //Отделения.......................................................................................................................
        private void CreateColumns6()//Метод создания....................................................................................................................................
        {
            dataGridView6.Columns.Add("code", "code");
            dataGridView6.Columns.Add("Name_of_the_department ", "Название отдела");//Cоздание колонки
            dataGridView6.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow6(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid6(DataGridView dqw)//Метод обнавления..............................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Departments  ";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow6(dqw, reader);
            }
            reader.Close();
            button24.Visible = true;
        }
        private void Search6(DataGridView dgw)//Метод поиска..............................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Departments   where concat (code, Name_of_the_department) like '%" + textBox32.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow6(dgw, read);
            }
            read.Close();
        }
        private void Update6()//Метод сохранения..............................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView6.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView6.Rows[index].Cells[2].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView6.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Departments   where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView6.Rows[index].Cells[0].Value.ToString();
                        var Name_of_the_department = dataGridView6.Rows[index].Cells[1].Value.ToString();


                        var changeQuery = $"update Departments   set Name_of_the_department= '{Name_of_the_department}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button24.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ID имеет числовой формат \r\n" + ex);
            }
        }
        private void deleteRow6()//Метод удаления..............................................................................................................
        {
            int index = dataGridView6.CurrentCell.RowIndex;
            dataGridView6.Rows[index].Visible = false;
            if (dataGridView6.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView6.Rows[index].Cells[2].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView6.Rows[index].Cells[2].Value = RowState.Deleted;
            button24.Visible = false;
        }
        private void Chande6()//Метод изменения..............................................................................................................
        {
            var selectedRowIndex = dataGridView6.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox34.Text;
            var Name_of_the_department = textBox35.Text;
            //изменение

            dataGridView6.Rows[selectedRowIndex].SetValues(code, Name_of_the_department);
            dataGridView6.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)//Поиск..............................................................................................................
        {
            Search6(dataGridView6);
        }

        private void button48_Click(object sender, EventArgs e)//Обнавление..............................................................................................................
        {
            RefreshDataGrid6(dataGridView6);
        }

        private void button22_Click(object sender, EventArgs e)//Добавление..............................................................................................................
        {
            Departments addTP = new Departments();
            addTP.Show();
        }

        private void button23_Click(object sender, EventArgs e)//Удаление..............................................................................................................
        {
            deleteRow6();
        }

        private void button24_Click(object sender, EventArgs e)//Изменение..............................................................................................................
        {
            Chande6();
        }

        private void button21_Click(object sender, EventArgs e)//Сохранение..............................................................................................................
        {
            Update6();
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)//Считывание данных..............................................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView6.Rows[selectedRow];
                textBox34.Text = row.Cells[0].Value.ToString();
                textBox35.Text = row.Cells[1].Value.ToString();

            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }
        //Темы..........................................................................................................................................................................
        private void CreateColumns7()//Метод создания....................................................................................................................................
        {
            dataGridView7.Columns.Add("code", "code");
            dataGridView7.Columns.Add("Topic_name  ", "Название темы");//Cоздание колонки Teacher

            dataGridView7.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow7(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid7(DataGridView dqw)// Метод Обнавление..............................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Lesson_topics   ";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow7(dqw, reader);
            }
            reader.Close();
            button28.Visible = true;
        }
        private void Search7(DataGridView dgw)//Метод поиска..............................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Lesson_topics    where concat (code, Topic_name, ) like '%" + textBox33.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow7(dgw, read);
            }
            read.Close();
        }
        private void Update7()//Метод Сохранения..............................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView7.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView7.Rows[index].Cells[2].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView7.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Lesson_topics    where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView7.Rows[index].Cells[0].Value.ToString();
                        var Topic_name = dataGridView7.Rows[index].Cells[1].Value.ToString();



                        var changeQuery = $"update Lesson_topics   set Topic_name = '{Topic_name}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button28.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка id имеет числовой формат /r/n" + ex);
            }
        }
        private void deleteRow7()//Метод удаления..............................................................................................................
        {
            int index = dataGridView7.CurrentCell.RowIndex;
            dataGridView7.Rows[index].Visible = false;
            if (dataGridView7.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView7.Rows[index].Cells[2].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView7.Rows[index].Cells[2].Value = RowState.Deleted;
            button28.Visible = false;
        }
        private void Chande7()//Метод изменения..............................................................................................................
        {
            var selectedRowIndex = dataGridView7.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox41.Text;
            var Topic_name = textBox42.Text;

            //изменение

            dataGridView7.Rows[selectedRowIndex].SetValues(code, Topic_name);
            dataGridView7.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
        }

        private void textBox33_TextChanged(object sender, EventArgs e)//Поиск..............................................................................................................
        {
            Search7(dataGridView7);
        }

        private void button50_Click(object sender, EventArgs e)//Обнавление..............................................................................................................
        {
            RefreshDataGrid7(dataGridView7);
        }

        private void button26_Click(object sender, EventArgs e)//Добавление..............................................................................................................
        {
            Lesson_topics addTP = new Lesson_topics();
            addTP.Show();
        }

        private void button27_Click(object sender, EventArgs e)//Удаление..............................................................................................................
        {
            deleteRow7();
        }

        private void button28_Click(object sender, EventArgs e)//Изменение..............................................................................................................
        {
            Chande7();
        }

        private void button25_Click(object sender, EventArgs e)//Сохранение..............................................................................................................
        {
            Update7();
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)//Считывание..............................................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView7.Rows[selectedRow];
                textBox41.Text = row.Cells[0].Value.ToString();
                textBox42.Text = row.Cells[1].Value.ToString();

            }
        }
        //Предмет....................................................................................................................................................................
        private void CreateColumns8()//Метод создания....................................................................................................................................
        {
            dataGridView8.Columns.Add("code", "code");
            dataGridView8.Columns.Add("ttems_name", "Название предмета");//Cоздание колонки
            dataGridView8.Columns.Add("Payment_per_hour", "Оплата за час");
            dataGridView8.Columns.Add("Teacher  ", "Преподователи");
            dataGridView8.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow8(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }
        private void RefreshDataGrid8(DataGridView dqw)//Обновление.......................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Items   ";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow8(dqw, reader);
            }
            reader.Close();
            button32.Visible = true;
        }
        private void Search8(DataGridView dgw)//Метод поиска.............................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Items    where concat (code, ttems_name,Payment_per_hour,Teacher) like '%" + textBox36.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow8(dgw, read);
            }
            read.Close();
        }
        private void Update8()//Добавление...............................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView8.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView8.Rows[index].Cells[4].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView8.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Items    where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView8.Rows[index].Cells[0].Value.ToString();
                        var ttems_name = dataGridView8.Rows[index].Cells[1].Value.ToString();
                        var Payment_per_hour = dataGridView8.Rows[index].Cells[2].Value.ToString();
                        var Teacher = dataGridView8.Rows[index].Cells[3].Value.ToString();

                        var changeQuery = $"update Items set ttems_name = '{ttems_name}',Payment_per_hour='{Payment_per_hour}',Teacher='{Teacher}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button32.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ID имеет числовой формат/r/n" + ex);
            }
        }
        private void deleteRow8()//Удаление.............................................................................................................................................
        {
            int index = dataGridView8.CurrentCell.RowIndex;
            dataGridView8.Rows[index].Visible = false;
            if (dataGridView8.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView8.Rows[index].Cells[4].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView8.Rows[index].Cells[4].Value = RowState.Deleted;
            button32.Visible = false;
        }
        private void Chande8()//Изменение................................................................................................................................................
        {
            var selectedRowIndex = dataGridView8.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox48.Text;
            var ttems_name = textBox49.Text;
            var Payment_per_hour = textBox50.Text;
            var Teacher = textBox39.Text;
            //изменение

            dataGridView8.Rows[selectedRowIndex].SetValues(code, ttems_name, Payment_per_hour, Teacher);
            dataGridView8.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            Search8(dataGridView8);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            RefreshDataGrid8(dataGridView8);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Items addTP = new Items();
            addTP.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            deleteRow8();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Chande8();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Update8();
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)//Форма..........................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView8.Rows[selectedRow];
                textBox48.Text = row.Cells[0].Value.ToString();
                textBox49.Text = row.Cells[1].Value.ToString();
                textBox50.Text = row.Cells[2].Value.ToString();
                textBox39.Text = row.Cells[3].Value.ToString();

            }
        }
        //Специальность..................................................................................................................................................................
        private void CreateColumns9()//Метод создания....................................................................................................................................
        {
            dataGridView9.Columns.Add("code", "code");
            dataGridView9.Columns.Add("Name_of_the_specialty ", "Название специальности");//Cоздание колонки
            dataGridView9.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow9(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid9(DataGridView dqw)//Обновление.......................................................................................................................
        {
            dqw.Rows.Clear();
            string queryString = $"select * from Specialty    ";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow9(dqw, reader);
            }
            reader.Close();
            button36.Visible = true;
        }
        private void Search9(DataGridView dgw)//Метод поиска.............................................................................................................................
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Specialty where concat (code, Name_of_the_specialty) like '%" + textBox37.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()); // поиск

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow9(dgw, read);
            }
            read.Close();
        }
        private void Update9()//Добавление...............................................................................................................................................
        {
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView9.Rows.Count; index++) //code Last_name Name Middle_name Phone_number Address
                {
                    var rowState = (RowState)dataGridView9.Rows[index].Cells[2].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var code = Convert.ToInt32(dataGridView9.Rows[index].Cells[0].Value); //добавление
                        var DeleteQuery = $"delete from Specialty where code = {code}";
                        var command = new SqlCommand(DeleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if (rowState == RowState.Modified)
                    {
                        var code = dataGridView9.Rows[index].Cells[0].Value.ToString();
                        var Name_of_the_specialty = dataGridView9.Rows[index].Cells[1].Value.ToString();

                        var changeQuery = $"update Specialty set Name_of_the_specialty = '{Name_of_the_specialty}' where code='{code}' ";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dataBase.closeConnection();
                button36.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка id Имеет числовой формат\r\n" + ex);
            }
        }
        private void deleteRow9()//Удаление.............................................................................................................................................
        {
            int index = dataGridView9.CurrentCell.RowIndex;
            dataGridView9.Rows[index].Visible = false;
            if (dataGridView9.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView9.Rows[index].Cells[2].Value = RowState.Deleted; //удаление
                return;
            }
            dataGridView9.Rows[index].Cells[2].Value = RowState.Deleted;
            button36.Visible = false;
        }
        private void Chande9()//Изменение................................................................................................................................................
        {
            var selectedRowIndex = dataGridView9.CurrentCell.RowIndex;//code Last_name Name Middle_name Phone_number Address
            var code = textBox55.Text;
            var Name_of_the_specialty = textBox56.Text;

            //изменение

            dataGridView9.Rows[selectedRowIndex].SetValues(code, Name_of_the_specialty);
            dataGridView9.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            Search9(dataGridView9);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            RefreshDataGrid9(dataGridView9);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Specialty addTP = new Specialty();
            addTP.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            deleteRow9();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Chande9();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Update9();
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)//Форма..........................................................................................
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView9.Rows[selectedRow];
                textBox55.Text = row.Cells[0].Value.ToString();
                textBox56.Text = row.Cells[1].Value.ToString();


            }
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            polz addTP = new polz();
            addTP.Show();
        }
        //Группа..................................................................................................................................
        private void button63_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox1.Text + "\r\n";
            result += " Номер группы: " + textBox2.Text + "\r\n";
            result += " ID Специальность: " + textBox3.Text + "\r\n";
            result += " ID Отделение: " + textBox4.Text + "\r\n";
            result += " ID Кол-во студентов: " + textBox5.Text + "\r\n";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler1;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler1(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Студенты.................................................................................................................................
        private void button64_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox6.Text + "\r\n";
            result += " Фамилия: " + textBox7.Text + "\r\n";
            result += " Имя: " + textBox8.Text + "\r\n";
            result += " Отчество : " + textBox9.Text + "\r\n";
            result += " Номер телефона : " + textBox10.Text + "\r\n";
            result += " Адресс : " + textBox38.Text + "\r\n";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler2;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler2(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Занятия....................................................................................................................................
        private void button65_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox11.Text + "\r\n";
            result += " Тема занятий : " + textBox12.Text + "\r\n";
            result += " Кол-во часов : " + textBox13.Text + "\r\n";
            result += " ID Отделение: " + textBox14.Text + "\r\n";
            result += " ID Кол-во студентов: " + textBox15.Text + "\r\n";
            result += " ID Кол-во студентов: " + textBox16.Text + "\r\n";
            result += " ID Кол-во студентов: " + textBox17.Text + "\r\n";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler3;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler3(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Преподы
        private void button66_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox20.Text + "\r\n";
            result += " Фамилия: " + textBox21.Text + "\r\n";
            result += " Имя: " + textBox22.Text + "\r\n";
            result += " Отчество : " + textBox23.Text + "\r\n";
            result += " Номер телефона : " + textBox24.Text + "\r\n";
            result += " Стаж работы : " + textBox19.Text + "\r\n";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler4;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler4(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Типы занятий...............................................................................................................................
        private void button67_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox27.Text + "\r\n";
            result += " Название: " + textBox28.Text + "\r\n";
            result += " Оплата: " + textBox29.Text + "\r\n";


            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler5;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler5(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Отделения......................................................................................................................................
        private void button68_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox34.Text + "\r\n";
            result += " Название отделения: " + textBox35.Text + "\r\n";



            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler6;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler6(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Темы..........................................................................................................................................
        private void button69_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox41.Text + "\r\n";
            result += " Название темы: " + textBox42.Text + "\r\n";



            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler7;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler7(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Предмет...................................................................................................................................
        private void button70_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox48.Text + "\r\n";
            result += " Название предмета: " + textBox49.Text + "\r\n";
            result += " Оплата за час: " + textBox50.Text + "\r\n";
            result += " Преподователь: " + textBox39.Text + "\r\n";



            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler8;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler8(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        //Спецальность...............................................................................................................................
        private void button71_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = " ID: " + textBox55.Text + "\r\n";
            result += " Название спецальности: " + textBox56.Text + "\r\n";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler9;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler9(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }



        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm1 = new sign_up();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void label49_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
    
    



