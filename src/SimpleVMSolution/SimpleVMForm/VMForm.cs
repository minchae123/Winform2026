using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVMForm
{
    public partial class VMForm : Form
    {
        public VMForm()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            cbCoin.Items.Clear();
            cbCoin.Items.Add("100원");
            cbCoin.Items.Add("500원");
            cbCoin.Items.Add("1000원");
        }

        int money = 0;

        private void btnCoin_Click(object sender, EventArgs e)
        {
            int i = cbCoin.SelectedIndex;
            switch(i)
            {
                case 0:
                    money += 100;
                    break;
                case 1:
                    money += 500;
                    break;
                case 2:
                    money += 1000;
                    break;
            }
            lbChangesValue.Text = money.ToString();
        }

        private void btnCoke500_Click(object sender, EventArgs e)
        {
            if(money >= 500)
            {
                money -= 500;
                MessageBox.Show("콜라가 뽑혔음");
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
            }
            lbChangesValue.Text = money.ToString();
        }

        private void btnCider300_Click(object sender, EventArgs e)
        {
            if (money >= 300)
            {
                money -= 300;
                MessageBox.Show("사이다가 뽑혔음");
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
            }
            lbChangesValue.Text = money.ToString();
        }

        private void btnCoffee700_Click(object sender, EventArgs e)
        {
            if (money >= 700)
            {
                money -= 700;
                MessageBox.Show("커피가 뽑혔음");
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
            }
            lbChangesValue.Text = money.ToString();
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show(money + "원이 반환되었습니다.");
            money = 0;
            lbChangesValue.Text = money.ToString();
        }
    }
}
