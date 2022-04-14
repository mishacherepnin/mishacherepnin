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
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = true;
            textBox7.UseSystemPasswordChar = true;
           // Form5 aa = new Form5();
            //this.Hide();
            //aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";

            SqlConnection myConnection = new SqlConnection(@connect); //исправить пароль

            myConnection.Open();//Открытие подключения
            string sInsSql = "Insert into tablee(fam,imia,otch,tele,mail,pass) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";

            // Считываем данные с формы 
            string fam = textBox1.Text;
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
            //MessageBox.Show(string.Format("[Поле] {0} успешно добавлено"), "Сообщение");

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[0-9 ]") && (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z  ]")) && (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z  ]")) && (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Z  ]")) && (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "^[@,a-z,.,0-9]")) && (textBox6.Text == textBox7.Text))
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("check it again Dude");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = false;
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.UseSystemPasswordChar = false;
        }
    }
}
