using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureProject
{
    public partial class DSForm : Form
    {
        DataTable dt = new DataTable();
        public DSForm()
        {
            InitializeComponent();
            InitData();
            InitEvent();
        }

        private void InitEvent()
        {
            btnInput.Click += BtnInput_Click;
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtId.Text, txtName.Text, cbScore.Text);
        }

        private void InitData()
        {
            cbScore.Items.Add("A");
            cbScore.Items.Add("B");
            cbScore.Items.Add("C");
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("학점");
            dataGridView.DataSource = dt;
        }
    }
}
