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

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.Компании' table. You can move, or remove it, as needed.
            this.компанииTableAdapter.Fill(this.dataSet21.Компании);
            // TODO: This line of code loads data into the 'dataSet20.Поезда' table. You can move, or remove it, as needed.
            this.поездаTableAdapter.Fill(this.dataSet20.Поезда);
            // TODO: This line of code loads data into the 'dataSet19.Билеты' table. You can move, or remove it, as needed.
            this.билетыTableAdapter.Fill(this.dataSet19.Билеты);
            // TODO: This line of code loads data into the 'dataSet15.pretendent' table. You can move, or remove it, as needed.
            this.pretendentTableAdapter.Fill(this.dataSet15.pretendent);
            // TODO: This line of code loads data into the 'dataSet14.zaiavki' table. You can move, or remove it, as needed.
            this.zaiavkiTableAdapter.Fill(this.dataSet14.zaiavki);
            // TODO: This line of code loads data into the 'dataSet13.doljnost' table. You can move, or remove it, as needed.
            this.doljnostTableAdapter.Fill(this.dataSet13.doljnost);
            // TODO: This line of code loads data into the 'dataSet12._1vakansia' table. You can move, or remove it, as needed.
            this._1vakansiaTableAdapter.Fill(this.dataSet12._1vakansia);
            // TODO: This line of code loads data into the 'dataSet11._1firma' table. You can move, or remove it, as needed.
            this._1firmaTableAdapter.Fill(this.dataSet11._1firma);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet9.tablee". При необходимости она может быть перемещена или удалена.
            this.tableeTableAdapter1.Fill(this.dataSet9.tablee);
            // TODO: This line of code loads data into the 'dataSet4.Sdelka' table. You can move, or remove it, as needed.
            this.sdelkaTableAdapter.Fill(this.dataSet4.Sdelka);
            // TODO: This line of code loads data into the 'dataSet3.Realtor' table. You can move, or remove it, as needed.
            this.realtorTableAdapter.Fill(this.dataSet3.Realtor);
            // TODO: This line of code loads data into the 'dataSet2.Prodavec' table. You can move, or remove it, as needed.
            this.prodavecTableAdapter.Fill(this.dataSet2.Prodavec);
            // TODO: This line of code loads data into the 'dataSet1.Pokupatel' table. You can move, or remove it, as needed.
            this.pokupatelTableAdapter.Fill(this.dataSet1.Pokupatel);


            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            //dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            //button8.Visible = true;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            //button13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);

            myConnection.Open();

            string query = "SELECT * FROM tablee ";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);

            myConnection.Open();

            string query = "SELECT * FROM Услуги ";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            //dataGridView4.Visible = false;
            //dataGridView6.Visible = false;
            
            button10.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            //dataGridView4.Visible = true;
            //dataGridView6.Visible = false;
           
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            //dataGridView4.Visible = false;
            //dataGridView6.Visible = false;
           
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            //dataGridView4.Visible = false;
           // dataGridView6.Visible = false;
            
            button10.Visible = false;
            button11.Visible = true;
            button12.Visible = false;
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Пусто Фамилия");
            else if (textBox2.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Пусто Имя");
            else if (textBox3.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Пусто Отчество");
            else if (textBox4.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Введите Телефон");
            else if (textBox5.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Введите Почту");
            else if (textBox6.Text == String.Empty)//Проверка на пустоту текстбокса
                MessageBox.Show("Введите Пароль");
            else
            {
                //подключение к базе данных
                string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";

                SqlConnection myConnection = new SqlConnection(@connect);

                myConnection.Open();//Открытие подключения

                //вывод данных из таблицы users по логину и паролю
                string command = "Select * from Ses1_Риэлтор where Фамилия='" + textBox7.Text + "' and Имя='" + textBox2.Text + "'" + "' and Отчество='" + textBox3.Text + "'" + "' and [ДоляОтКомиссии(руб)]='" + textBox4.Text + "'";
                // Добавление
                string sInsSql = "Insert into tablee(fam,imia,otch,tele,mail,pass) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";

                // Считываем данные с формы 
                string fam = textBox7.Text;
                string imia = textBox2.Text;
                string otch = textBox3.Text;
                string tele = textBox4.Text;
                string mail = textBox5.Text;
                string pass = textBox6.Text;
                // Формируем запрос на вставку данных с формы 
                string sInsSotr = string.Format(sInsSql, fam, imia, otch, tele, mail, pass);

                // Создаем команду 
                SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);

                // Выполняем команду на вставку записи 
                cmdIns.ExecuteNonQuery();

                // Выводим сообщение ...
                MessageBox.Show(string.Format("[fam] {0} успешно добавлено", fam), "Сообщение");
                MessageBox.Show(string.Format("[imia] {0} успешно добавлено", imia), "Сообщение");
                MessageBox.Show(string.Format("[otch] {0} успешно добавлено", otch), "Сообщение");
                MessageBox.Show(string.Format("[tele] {0} успешно добавлено", tele), "Сообщение");
                MessageBox.Show(string.Format("[mail] {0} успешно добавлено", mail), "Сообщение");
                MessageBox.Show(string.Format("[pass] {0} успешно добавлено", pass), "Сообщение");
                this.tableeTableAdapter1.Update(this.dataSet9.tablee);
                this.tableeTableAdapter1.Fill(this.dataSet9.tablee);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            //dataGridView4.Visible = false;
           // dataGridView6.Visible = true;
           // button8.Visible = true;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
          //  button13.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.pretendentTableAdapter.Update(this.dataSet15.pretendent);
            this.zaiavkiTableAdapter.Update(this.dataSet14.zaiavki);
            this.doljnostTableAdapter.Update(this.dataSet13.doljnost);
            this._1vakansiaTableAdapter.Update(this.dataSet12._1vakansia);
            this._1firmaTableAdapter.Update(this.dataSet11._1firma);
            this.tableeTableAdapter1.Update(this.dataSet9.tablee);
            this.sdelkaTableAdapter.Update(this.dataSet4.Sdelka);
            this.realtorTableAdapter.Update(this.dataSet3.Realtor);
            this.prodavecTableAdapter.Update(this.dataSet2.Prodavec);
            this.pokupatelTableAdapter.Update(this.dataSet1.Pokupatel);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.pretendentTableAdapter.Update(this.dataSet15.pretendent);
            this.zaiavkiTableAdapter.Update(this.dataSet14.zaiavki);
            this.doljnostTableAdapter.Update(this.dataSet13.doljnost);
            this._1vakansiaTableAdapter.Update(this.dataSet12._1vakansia);
            this._1firmaTableAdapter.Update(this.dataSet11._1firma);
            this.tableeTableAdapter1.Update(this.dataSet9.tablee);
            this.sdelkaTableAdapter.Update(this.dataSet4.Sdelka);
            this.realtorTableAdapter.Update(this.dataSet3.Realtor);
            this.prodavecTableAdapter.Update(this.dataSet2.Prodavec);
            this.pokupatelTableAdapter.Update(this.dataSet1.Pokupatel);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.pretendentTableAdapter.Update(this.dataSet15.pretendent);
            this.zaiavkiTableAdapter.Update(this.dataSet14.zaiavki);
            this.doljnostTableAdapter.Update(this.dataSet13.doljnost);
            this._1vakansiaTableAdapter.Update(this.dataSet12._1vakansia);
            this._1firmaTableAdapter.Update(this.dataSet11._1firma);
            this.tableeTableAdapter1.Update(this.dataSet9.tablee);
            this.sdelkaTableAdapter.Update(this.dataSet4.Sdelka);
            this.realtorTableAdapter.Update(this.dataSet3.Realtor);
            this.prodavecTableAdapter.Update(this.dataSet2.Prodavec);
            this.pokupatelTableAdapter.Update(this.dataSet1.Pokupatel);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.pretendentTableAdapter.Update(this.dataSet15.pretendent);
            this.zaiavkiTableAdapter.Update(this.dataSet14.zaiavki);
            this.doljnostTableAdapter.Update(this.dataSet13.doljnost);
            this._1vakansiaTableAdapter.Update(this.dataSet12._1vakansia);
            this._1firmaTableAdapter.Update(this.dataSet11._1firma);
            this.tableeTableAdapter1.Update(this.dataSet9.tablee);
            this.sdelkaTableAdapter.Update(this.dataSet4.Sdelka);
            this.realtorTableAdapter.Update(this.dataSet3.Realtor);
            this.prodavecTableAdapter.Update(this.dataSet2.Prodavec);
            this.pokupatelTableAdapter.Update(this.dataSet1.Pokupatel);
        }
    }
}
