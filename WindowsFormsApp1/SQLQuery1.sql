 string connect = "data source=vc-stud-mssql1;initial catalog=user52_db;persist security info=True;user id=user52_db;password=***********;MultipleActiveResultSets=True;App=EntityFramework";
                
                SqlConnection myConnection = new SqlConnection(@connect);

                myConnection.Open();
				string command = "Select * from ������� where ����1='" + textBox1.Text + "' and ����2='" + textBox2.Text + "'";
Connect.Close();
string sInsSql = "Insert into �������(����1,����2,����3,����4,����5,����6) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";
 string ����1 = textBox1.Text;
                    string ����2 = textBox2.Text;
                    string ����3= textBox3.Text;
                    string ����4 = textBox4.Text;
                    string ����5= textBox6.Text;
                    string ����6 = textBox5.Text;
					string sInsSotr = string.Format(sInsSql, ����1, ����2,����3,����4,����5,����6);
SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
cmdIns.ExecuteNonQuery();
 MessageBox.Show(string.Format("[����] {0} ������� ���������", ����1), "���������");
string strConn = @"data source=vc-stud-mssql1;initial catalog=[��� �����];persist security info=True;user id=[��� �����];password=[��� ������];MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection sqlConnect = new SqlConnection(strConn);
            sqlConnect.Open();
            string strAll1 = "Delete from [�������] where [����] = '" + textBox5.Text + "'";
            SqlCommand com1 = new SqlCommand(strAll1, sqlConnect);
            com1.ExecuteNonQuery();