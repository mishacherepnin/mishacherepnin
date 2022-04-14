 string connect = "data source=vc-stud-mssql1;initial catalog=user52_db;persist security info=True;user id=user52_db;password=***********;MultipleActiveResultSets=True;App=EntityFramework";
                
                SqlConnection myConnection = new SqlConnection(@connect);

                myConnection.Open();
				string command = "Select * from ТАБЛИЦА where ПОЛЕ1='" + textBox1.Text + "' and ПОЛЕ2='" + textBox2.Text + "'";
Connect.Close();
string sInsSql = "Insert into ТАБЛИЦА(ПОЛЕ1,ПОЛЕ2,ПОЛЕ3,ПОЛЕ4,ПОЛЕ5,ПОЛЕ6) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";
 string ПОЛЕ1 = textBox1.Text;
                    string ПОЛЕ2 = textBox2.Text;
                    string ПОЛЕ3= textBox3.Text;
                    string ПОЛЕ4 = textBox4.Text;
                    string ПОЛЕ5= textBox6.Text;
                    string ПОЛЕ6 = textBox5.Text;
					string sInsSotr = string.Format(sInsSql, ПОЛЕ1, ПОЛЕ2,ПОЛЕ3,ПОЛЕ4,ПОЛЕ5,ПОЛЕ6);
SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
cmdIns.ExecuteNonQuery();
 MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", ПОЛЕ1), "Сообщение");
string strConn = @"data source=vc-stud-mssql1;initial catalog=[Ваш логин];persist security info=True;user id=[Ваш логин];password=[Ваш пароль];MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection sqlConnect = new SqlConnection(strConn);
            sqlConnect.Open();
            string strAll1 = "Delete from [Таблица] where [Поле] = '" + textBox5.Text + "'";
            SqlCommand com1 = new SqlCommand(strAll1, sqlConnect);
            com1.ExecuteNonQuery();