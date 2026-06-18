using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int money = 0;

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int coin = 0;
            bool isMoney = int.TryParse(txtCash.Text, out coin);

            if (isMoney)
            {
                money += coin;
                txtContext.Text += "[ " + DateTime.Now.ToString() + " ] " + "입금 : " + coin + "원\r\n";
                lbDeposit.Text = money + "원";
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            txtCash.Text = "";
        }

        private void lbWithdraw_Click(object sender, EventArgs e)
        {
            int coin = 0;
            bool isMoney = int.TryParse(txtCash.Text, out coin);

            if (isMoney)
            {
                if(coin > money)
                {
                    MessageBox.Show("보유 금액이 부족합니다.");
                    txtContext.Text += "[ " + DateTime.Now.ToString() + " ] " + "출금 실패 : " + coin + "원\r\n";
                }
                else
                {
                    money -= coin;
                    txtContext.Text += "[ " + DateTime.Now.ToString() + " ] " + "출금 : " + coin + "원\r\n";
                    lbDeposit.Text = money + "원";
                }
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            txtCash.Text = "";
        }
    }
}
