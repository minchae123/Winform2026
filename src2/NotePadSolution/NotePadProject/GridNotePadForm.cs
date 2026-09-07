using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadProject
{
    public partial class GridNotePadForm : Form
    {
        public GridNotePadForm()
        {
            InitializeComponent();
            DataGridVeiwSetup();
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnOpen.Click += BtnOpen_Click;
            dataGridView.CellClick += DataGridView_CellClick;
        }

        int selectedRow = 0;

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                DataGridVeiwSetup(); // header text

               StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default);

                String rowValue = sr.ReadLine(); // 첫번째 줄 읽기 (header) 이미 설정해두었기에 따로 설정 x
                String[] cellValue;
                dataGridView.Rows.Clear();
                while (sr.Peek() != -1) // 처음부터 끝까지
                {
                    rowValue = sr.ReadLine(); // 다음 줄 읽기
                    cellValue = rowValue.Split(',');
                    dataGridView.Rows.Add(cellValue);
                }
                sr.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default);

                String strHeader = "";
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    strHeader += dataGridView.Columns[i].HeaderText + ",";
                }
                sw.WriteLine(strHeader);
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    String strRowValue = "";
                    for(int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        strRowValue += dataGridView.Rows[i].Cells[j].Value + ",";
                    }
                    sw.WriteLine(strRowValue);
                }
                sw.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 1) 
            {
                dataGridView.Rows.RemoveAt(selectedRow);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }

        private void DataGridVeiwSetup()
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "이름";
            dataGridView.Columns[1].Name = "전화번호";
            dataGridView.Columns[2].Name = "소속";
            dataGridView.Columns[3].Name = "관계";
            dataGridView.Columns[4].Name = "비고";
        }
    }
}
