using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPDownProject
{
    public partial class UpDownForm : Form
    {
        public UpDownForm()
        {
            InitializeComponent();
        }

        int resultNum;
        int tryCount = 0;

        private void InitGame()
        {
            lbTryCount.Text = "-";
            lbStartTime.Text = "-";
            lbState.Text = "-";
            txtInput.Text = "";    
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            tryCount = 0;
            lbTryCount.Text = tryCount.ToString();
            lbStartTime.Text = DateTime.Now.ToString();
            lbState.Text = "게임을 시작합니다. 1~60 중 값을 입력하세요!";
            Random rdn = new Random();
            resultNum = rdn.Next(60);
            txtInput.Text = "";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(tryCount < 10)
            {
                int input = int.Parse(txtInput.Text);
                tryCount++;
                IncreaseTryPrograssBar(tryCount);
                lbTryCount.Text = tryCount.ToString();
                if (input == resultNum)
                {
                    lbState.Text = input + " 정답입니다!";
                    InitGame();
                }
                else if (input > resultNum)
                {
                    lbState.Text = input + " DOWN!";
                }
                else
                {
                    lbState.Text = input + " UP!";
                }
            }
            else
            {
                lbState.Text = "시도 수를 초과하였습니다. 게임이 종료됩니다.";
                btnInput.Enabled = false;
            }
        }

        private void IncreaseTryPrograssBar(int tryCount)
        {
            if (tryCount > 10)
                return;

            tryProgressBar.Value = tryCount * 10;
        }
    }
}
