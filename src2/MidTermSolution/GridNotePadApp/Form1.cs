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

namespace GridNotePadApp
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            dataGridSetUp();
            btn_Add.Click += Btn_Add_Click;
            btn_Save.Click += Btn_Save_Click;
            btn_Open.Click += Btn_Open_Click;
            btn_Delete.Click += Btn_Delete_Click;
        }

        private void dataGridSetUp()
        {
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "학번";
            dataGridView.Columns[1].Name = "이름";
            dataGridView.Columns[2].Name = "소속";
            dataGridView.Columns[3].Name = "전화번호";
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridSetUp();

                StreamReader sr = new StreamReader(
                    openFileDialog.FileName, Encoding.Default);

                String rowValue = sr.ReadLine();
                String[] cellValue;
                dataGridView.Rows.Clear();

                while (sr.Peek() != -1)
                {
                    rowValue = sr.ReadLine();
                    cellValue = rowValue.Split(',');

                    dataGridView.Rows.Add(cellValue);
                }

                sr.Close();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV (*.CSV)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(
                    saveFileDialog.FileName, false, Encoding.Default);

                String strHeader = "";
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    strHeader += dataGridView.Columns[i].HeaderText + ",";
                }

                sw.WriteLine(strHeader);

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    String strRowValue = "";
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        strRowValue += dataGridView.Rows[i].Cells[j].Value + ",";
                    }

                    sw.WriteLine(strRowValue);
                }

                sw.Close();
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }
    }
}
