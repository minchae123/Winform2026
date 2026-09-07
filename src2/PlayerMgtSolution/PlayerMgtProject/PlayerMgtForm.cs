using PlayerDataClassLibrary;
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

namespace PlayerMgtProject
{
    public partial class PlayerMgtForm : Form
    {
        DataTable dt = new DataTable();
        public PlayerMgtForm()
        {
            InitializeComponent();
            InitData();
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strPlayers = "";
            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                strPlayers += checkedListBoxPlayer.CheckedItems[i].ToString();
                strPlayers += ", ";
            }
            if (strPlayers.Length >= 2)
                strPlayers = strPlayers.Remove(strPlayers.Length - 2, 2);
            lbName.Text = strPlayers;
            SetDataGrid();
            SetChart();
        }

        private void SetChart()
        {
            chart.Series.Clear();

            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                Series[] serieses = new Series[checkedListBoxPlayer.CheckedItems.Count];

                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataClassLibrary.PlayerDataSon.name))
                {
                    serieses[i] = new Series(PlayerDataClassLibrary.PlayerDataSon.name);
                    serieses[i].Points.AddXY("공격", PlayerDataClassLibrary.PlayerDataSon.offense);
                    serieses[i].Points.AddXY("수비", PlayerDataClassLibrary.PlayerDataSon.defense);
                    serieses[i].Points.AddXY("스피드", PlayerDataClassLibrary.PlayerDataSon.speed);
                    serieses[i].Points.AddXY("패스", PlayerDataClassLibrary.PlayerDataSon.pass);
                    serieses[i].Points.AddXY("슛", PlayerDataClassLibrary.PlayerDataSon.shoot);
                }

                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataClassLibrary.PlayerDataPark.name))
                {
                    serieses[i] = new Series(PlayerDataClassLibrary.PlayerDataPark.name);
                    serieses[i].Points.AddXY("공격", PlayerDataClassLibrary.PlayerDataPark.offense);
                    serieses[i].Points.AddXY("수비", PlayerDataClassLibrary.PlayerDataPark.defense);
                    serieses[i].Points.AddXY("스피드", PlayerDataClassLibrary.PlayerDataPark.speed);
                    serieses[i].Points.AddXY("패스", PlayerDataClassLibrary.PlayerDataPark.pass);
                    serieses[i].Points.AddXY("슛", PlayerDataClassLibrary.PlayerDataPark.shoot);
                }
                serieses[i].ChartType = SeriesChartType.Radar;
                chart.Series.Add(serieses[i]);
            }
        }

        private void SetDataGrid()
        {
            dt.Rows.Clear();

            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataClassLibrary.PlayerDataSon.name))
                {
                    dt.Rows.Add(PlayerDataClassLibrary.PlayerDataSon.name,
                        PlayerDataClassLibrary.PlayerDataSon.offense,
                        PlayerDataClassLibrary.PlayerDataSon.defense,
                        PlayerDataClassLibrary.PlayerDataSon.speed,
                        PlayerDataClassLibrary.PlayerDataSon.pass,
                        PlayerDataClassLibrary.PlayerDataSon.shoot);
                }

                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataClassLibrary.PlayerDataPark.name))
                {
                    dt.Rows.Add(PlayerDataClassLibrary.PlayerDataPark.name,
                        PlayerDataClassLibrary.PlayerDataPark.offense,
                        PlayerDataClassLibrary.PlayerDataPark.defense,
                        PlayerDataClassLibrary.PlayerDataPark.speed,
                        PlayerDataClassLibrary.PlayerDataPark.pass,
                        PlayerDataClassLibrary.PlayerDataPark.shoot);
                }
            }

            dataGridView.DataSource = dt;
        }

        private void InitData()
        {
            checkedListBoxPlayer.Items.Clear();
            checkedListBoxPlayer.Items.Add(PlayerDataSon.name);
            checkedListBoxPlayer.Items.Add(PlayerDataPark.name);

            dt = new DataTable();
            dt.Columns.Add("이름");
            dt.Columns.Add("공격");
            dt.Columns.Add("수비");
            dt.Columns.Add("스피드");
            dt.Columns.Add("패스");
            dt.Columns.Add("슛");
            
        }
    }
}
