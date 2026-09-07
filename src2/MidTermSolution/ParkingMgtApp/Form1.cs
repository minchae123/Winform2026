using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMgtApp
{
    public partial class Form1 : Form
    {
        ArrayList carNumList;
        List<Car> cars = new List<Car>();
        Car car;
        int seq = 0;
        public Form1()
        {
            InitializeComponent();
            carNumList = new ArrayList();
            btn_CarIn.Click += Btn_CarIn_Click;
            btn_CarOut.Click += Btn_CarOut_Click;
        }

        private void Btn_CarOut_Click(object sender, EventArgs e)
        {
            Car car = null;

            foreach (Car c in cars)
            {
                if (c.CarNumber == cbBox_CarList.Text)
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                car.SetOutTime();

                recordList.Items.Add($"차량번호 : {car.CarNumber} [입고시간] {car.InTime} [출차시간] {car.OutTime}");

                cars.Remove(car);
                carNumList.Remove(car.CarNumber);

                cbBox_CarList.Items.Clear();
                cbBox_CarList.Items.AddRange(carNumList.ToArray());
            }

            lbCnt.Text = carNumList.Count.ToString();
        }

        private void Btn_CarIn_Click(object sender, EventArgs e)
        {
            if (carNumList.Count < 8)
            {
                car = new Car();
                car.Seq = ++seq;
                car.SetInTime();
                cars.Add(car);
                carNumList.Add(cbBox_CarList.Text);
                car.CarNumber = cbBox_CarList.Text;
                cbBox_CarList.Items.Clear();
                cbBox_CarList.Items.AddRange(carNumList.ToArray());
                recordList.Items.Add($"차량번호 : {cbBox_CarList.Text} [입고시간] {car.InTime}");
                lbCnt.Text = carNumList.Count.ToString();
            }
        }
    }
}
