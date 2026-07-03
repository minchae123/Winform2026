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

namespace DBProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_search.Click += Btn_search_Click;
        }

        String mySqlConnStr = "Server=127.0.0.1;Database=myprog;Uid=root;Pwd=abcd1234";
        DataSet ds;

        private void Btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                conn.Open();
                string sql = "select * from mycompany";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(ds, "mycompany");
                myComdataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
