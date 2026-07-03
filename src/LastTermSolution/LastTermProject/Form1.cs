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
using System.Windows.Forms.DataVisualization.Charting;

namespace LastTermProject
{
    public partial class Form1 : Form
    {
        String mySqlConnStr = "Server=127.0.0.1;Database=myprog;Uid=root;Pwd=abcd1234";
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            btn_Alert.Click += Btn_Alert_Click;
            btn_Delete.Click += Btn_Delete_Click;
            btn_Input.Click += Btn_Input_Click;
            btn_Search.Click += Btn_Search_Click;
            dataGridView.CellClick += DataGridView_CellClick;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            checkedListPlayer.MouseDoubleClick += CheckedListPlayer_MouseDoubleClick;
            InitData();
        }

        private void CheckedListPlayer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DrawChart();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                DrawChart();
            }
        }

        private void DrawChart()
        {
            chart1.Series.Clear();

            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            conn.Open();

            foreach (string name in checkedListPlayer.CheckedItems)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("select * from playerdata ");
                sb.Append("where playername='");
                sb.Append(name);
                sb.Append("'");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    Series s = new Series(name);
                    s.ChartType = SeriesChartType.Bar;

                    s.Points.AddXY("공격", rd["offense"]);
                    s.Points.AddXY("수비", rd["defense"]);
                    s.Points.AddXY("스피드", rd["speed"]);
                    s.Points.AddXY("패스", rd["pass"]);
                    s.Points.AddXY("슛", rd["shoot"]);

                    chart1.Series.Add(s);
                }

                rd.Close();
            }

            conn.Close();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txt_Id.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Offense.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Defense.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Speed.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Pass.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Shoot.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void InitData()
        {
            LoadPlayer();
        }

        private void LoadPlayer()
        {
            checkedListPlayer.Items.Clear();
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();
                string sql = "select playername from playerdata";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    checkedListPlayer.Items.Add(rd["playername"].ToString());
                }

                rd.Close();
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
                ds = new DataSet();
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();
                string sql = "select * from playerdata";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "playerdata");
                dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Input_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("insert into playerdata ");
                sb.Append("values(");

                sb.Append(txt_Id.Text); sb.Append(", ");
                sb.Append("'"); sb.Append(txt_Name.Text); sb.Append("', ");
                sb.Append(txt_Offense.Text); sb.Append(", ");
                sb.Append(txt_Defense.Text); sb.Append(", ");
                sb.Append(txt_Speed.Text); sb.Append(", ");
                sb.Append(txt_Pass.Text); sb.Append(", ");
                sb.Append(txt_Shoot.Text);

                sb.Append(")");

                string sql = sb.ToString();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                LoadPlayer();
                Search();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("delete from playerdata ");
                sb.Append("where playername='");
                sb.Append(txt_Name.Text);
                sb.Append("'");

                string sql = sb.ToString();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                LoadPlayer();
                Search();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Alert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("update playerdata set ");

                sb.Append("offense=");
                sb.Append(txt_Offense.Text);
                sb.Append(",");

                sb.Append("defense=");
                sb.Append(txt_Defense.Text);
                sb.Append(",");

                sb.Append("speed=");
                sb.Append(txt_Speed.Text);
                sb.Append(",");

                sb.Append("pass=");
                sb.Append(txt_Pass.Text);
                sb.Append(",");

                sb.Append("shoot=");
                sb.Append(txt_Shoot.Text);

                sb.Append(" where playername='");
                sb.Append(txt_Name.Text);
                sb.Append("'");

                string sql = sb.ToString();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                LoadPlayer();
                Search();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
