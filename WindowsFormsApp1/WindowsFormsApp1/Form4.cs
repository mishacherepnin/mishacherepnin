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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet23.Поезда' table. You can move, or remove it, as needed.
            this.поездаTableAdapter.Fill(this.dataSet23.Поезда);
            // TODO: This line of code loads data into the 'dataSet22.Компании' table. You can move, or remove it, as needed.
            this.компанииTableAdapter.Fill(this.dataSet22.Компании);
            // TODO: This line of code loads data into the 'dataSet18.tablee' table. You can move, or remove it, as needed.
            this.tableeTableAdapter.Fill(this.dataSet18.tablee);
            // TODO: This line of code loads data into the 'dataSet17._112' table. You can move, or remove it, as needed.
            this._112TableAdapter.Fill(this.dataSet17._112);
            // TODO: This line of code loads data into the 'dataSet16._111' table. You can move, or remove it, as needed.
            this._111TableAdapter.Fill(this.dataSet16._111);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet8.tablee". При необходимости она может быть перемещена или удалена.
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            //dataGridView3.Visible = false;
            
            // TODO: This line of code loads data into the 'dataSet7.nedvijimost' table. You can move, or remove it, as needed.
            this.nedvijimostTableAdapter.Fill(this.dataSet7.nedvijimost);
            // TODO: This line of code loads data into the 'dataSet6.Sdelka' table. You can move, or remove it, as needed.
            this.sdelkaTableAdapter.Fill(this.dataSet6.Sdelka);
            // TODO: This line of code loads data into the 'dataSet5.Realtor' table. You can move, or remove it, as needed.
            this.realtorTableAdapter.Fill(this.dataSet5.Realtor);
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user129_db;persist security info=True;user id=user129_db;password=user129;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);

            myConnection.Open();

            string query = "SELECT * FROM nedvijimost";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

           // foreach (string[] s in data)
           //    dataGridView1.Rows.Add(s);
           // dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            //dataGridView3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            //dataGridView3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            //dataGridView3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
