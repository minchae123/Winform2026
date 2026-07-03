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

namespace TableChartProject
{
    public partial class TableChart : Form
    {
        DataTable dt = new DataTable();
        public TableChart()
        {
            InitializeComponent();
            InitSetting();
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows) 
            {
                if (row["이름"].ToString() == txtName.Text)
                    return;
            }
            DrawTable();
            DrawChart();
        }

        private void DrawChart()
        {
            chart.Series.Clear();

            string[] subject = { "영어", "수학", "과학" };

            foreach (DataRow row in dt.Rows)
            {
                Series s = new Series(row["이름"].ToString());
                s.ChartType = SeriesChartType.Column;

                s.Points.AddXY(subject[0], Convert.ToInt32(row["영어"]));
                s.Points.AddXY(subject[1], Convert.ToInt32(row["수학"]));
                s.Points.AddXY(subject[2], Convert.ToInt32(row["과학"]));

                chart.Series.Add(s);
            }
        }

        private void DrawTable()
        {
            int eng = int.Parse(txtEng.Text);
            int math = int.Parse(txtMath.Text);
            int sci = int.Parse(txtSci.Text);
            int sum = eng + math + sci;
            float avg = (float)sum / 3;
            dt.Rows.Add(txtName.Text, eng, math, sci, sum, avg.ToString("0.00"));
        }

        private void InitSetting()
        {
            dt.Columns.Add("이름");
            dt.Columns.Add("영어");
            dt.Columns.Add("수학");
            dt.Columns.Add("과학");
            dt.Columns.Add("합계");
            dt.Columns.Add("평균");
            dataGridView.DataSource = dt;
        }
    }
}
