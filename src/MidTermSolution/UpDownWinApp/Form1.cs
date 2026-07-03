using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownWinApp
{
    public partial class Form1 : Form
    {
        int tryCnt = 0;
        int rNum = 0;
        public Form1()
        {
            InitializeComponent();
            btn_init.Click += Btn_init_Click;
            btn_input.Click += Btn_input_Click;
        }

        private void Btn_input_Click(object sender, EventArgs e)
        {
            tryCnt++;
            lb_try.Text = tryCnt.ToString();
            Move_PrgressBar();
            int input = int.Parse(box_answer.Text);
            if (input > rNum)
            {
                lb_state.Text = $"Down! {input}보다 작은 값을 입력하세요!";
            }
            else if (input < rNum)
            {
                lb_state.Text = $"UP! {input}보다 높은 값을 입력하세요!";
            }
            else
            {
                lb_state.Text = $"정답! {input} 알아맞히셨습니다.";
            }
        }

        private void Btn_init_Click(object sender, EventArgs e)
        {
            InitGame();
        }

        private void InitGame()
        {
            Random r = new Random();
            rNum = r.Next(10) + 1;
            lb_time.Text = DateTime.Now.ToString();
        }

        private void Move_PrgressBar()
        {
            progressBar1.Value = tryCnt * 10;
        }
    }
}
