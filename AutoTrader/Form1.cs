using AutoTrader.AutoTrader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTrader
{
    public partial class Form1 : Form
    {
        private APIClass API;
        public Form1()
        {
            InitializeComponent();

            button_login.Click += ReceiveButtonEvent;
            button_checkFee.Click += ReceiveButtonEvent;
            button_checkAccount.Click += ReceiveButtonEvent;



        }

        public void ReceiveButtonEvent(object sender, EventArgs e)
        {
            if(sender.Equals(button_login))
            {
                API = new APIClass(textBox_access.Text, textBox_secret.Text);
                Console.WriteLine("로그인완료");
            }
            else if (sender.Equals(button_checkAccount))
            {
                Console.WriteLine(API.GetAccount());
            }
            else if (sender.Equals(button_checkFee))
            {
                Console.WriteLine(API.GetOrderChance("KRW-BTC"));
            }
        }

    }
}
