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

namespace ChartProject
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
            InitCombo();
        }

        private void InitCombo()
        {
            cboType.Items.Add("Column");
            cboType.Items.Add("Bar");
            cboType.Items.Add("Pie");
            cboType.Items.Add("Bubble");
            cboType.Items.Add("Doughnut");
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            myChart.Series.Clear();
            Series s1 = new Series("인구");
            string[] xValue = { "서울", "대전", "전주" };
            int[] yValue = { 10000, 3000, 2000 };
            string type = cboType.Text;
            switch (type)
            {
                case "Column":
                    s1.ChartType = SeriesChartType.Column;
                    break;
                case "Bar":
                    s1.ChartType = SeriesChartType.Bar;
                    break;
                case "Pie":
                    s1.ChartType = SeriesChartType.Pie;
                    break;
                case "Bubble":
                    s1.ChartType = SeriesChartType.Bubble;
                    break;
                case "Doughnut":
                    s1.ChartType = SeriesChartType.Doughnut;
                    break;
                default:
                    s1.ChartType = SeriesChartType.Column;
                    break;

            }


            s1.Points.DataBindXY(xValue, yValue);
            myChart.Series.Add(s1);
        }
    }
}
