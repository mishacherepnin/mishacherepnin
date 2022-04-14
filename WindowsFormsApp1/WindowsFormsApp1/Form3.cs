using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from tablee where fam='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
            SqlConnection myConnection = new SqlConnection(@connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();//чтение строк
            //Переменные для хранения данных, чтоб не ругался компилятор
            string fam = "null"; //или просто ""
            string pass = "null";



            while (rd.Read())//Чтение данных
            {
                fam = rd.GetString(0);
                pass = rd.GetString(5);
                if (fam == "admin" && pass == "admin")
                {
                    Form5 frm2 = new Form5();
                    frm2.Show();
                    this.Hide();
                   
                }
                else
                {
                    Form4 frm2 = new Form4();
                    frm2.Show();
                    this.Hide();
                }



                if ((fam == " ") || (pass == " "))// если введены неправильные данные

                { 
                    MessageBox.Show("Неправильный логин или пароль");
                }

              



            }
            myConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

    

