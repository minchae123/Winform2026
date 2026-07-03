using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComMgtProject
{
    public partial class MyComMgtForm : Form
    {
        String mySqlConnStr = "Server=127.0.0.1;Database=myprog;Uid=root;Pwd=abcd1234";
        DataSet ds;

        public MyComMgtForm()
        {
            InitializeComponent();
            btn_Insert.Click += Btn_Insert_Click;
            btn_Search.Click += Btn_Search_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_Update.Click += Btn_Update_Click;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                //수정하기
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();

                //데이터 수정하기
                StringBuilder sb = new StringBuilder();

                sb.Append("UPDATE mycompany SET ");
                sb.Append("name='").Append(txtName.Text).Append("', ");
                sb.Append("email='").Append(txtEMail.Text).Append("', ");
                sb.Append("dept='").Append(txtDept.Text).Append("', ");
                sb.Append("job='").Append(txtJob.Text).Append("', ");
                sb.Append("level='").Append(txtLevel.Text).Append("', ");
                sb.Append("fla_type='").Append(txtFlaType.Text).Append("', ");
                sb.Append("fla_value='").Append(txtFlaValue.Text).Append("', ");
                sb.Append("flb_type='").Append(txtFlbType.Text).Append("', ");
                sb.Append("flb_value='").Append(txtFlbValue.Text).Append("', ");
                sb.Append("score='").Append(txtScore.Text).Append("', ");
                sb.Append("salary='").Append(txtSalary.Text).Append("' ");
                sb.Append("WHERE id='").Append(txtId.Text).Append("'");

                string sql = sb.ToString();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                Search();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append(" delete from mycompany ");
                sb.Append(" where ");
                sb.Append(" id = '"); sb.Append(txtId.Text); sb.Append("'");
                string sql = sb.ToString();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Search();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {

                // 데이터 공간 생성
                ds = new DataSet();
                // 접속하기
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                string sql = "select * from mycompany";
                // 비연결 모드 DB 연결
                // 비연결 모드 : 데이터베이스에서 가져온 값을 클라이언트 메모리로 저장한 후 연결을 끊는 방식
                // 즉, 데이터를 가져와서 본 프로그램의 연결 공간에 데이터 저장
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                // DataqSet 내에 mycompany라는 table 공간을 만들어 저장
                // 즉, DataSource는 여러개의 DataTale을 가질 수 있음
                adpt.Fill(ds, "mycompany");
                myComDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();
                // 데이터 삽입 쿼리
                StringBuilder sb = new StringBuilder();
                sb.Append(" insert into mycompany");
                sb.Append(" values ( ");
                sb.Append(" '"); sb.Append(txtId.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtName.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtEMail.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtDept.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtJob.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtLevel.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlaType.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlaValue.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlbType.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlbValue.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtScore.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtSalary.Text); sb.Append("'");
                sb.Append(" ) ");
                string sql = sb.ToString();
                // sql 실행
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Search();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
