using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTrader.AutoTrader;

namespace AutoTrader.View
{
    public partial class LoginForm : Form
    {
        private APIClass api;
        private bool loginFlag;
        public LoginForm()
        {
            InitializeComponent();
            this.loginFlag = false;
            button_Login.Click += ReceiveButtonEvent;
            
        }

        private void ReceiveButtonEvent(object sender, EventArgs e)
        {
            if (sender.Equals(button_Login))
            {
                this.loginFlag = login();

                if (this.loginFlag)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("로그인에 실패했습니다.");
                }
            }

        }
        private bool login()
        {
            string accessKey = textBox_Access.Text;
            string secertKey = textBox_Secert.Text;

            if( accessKey.Length >= 15 && secertKey.Length >= 15)
            {
                APIClass api = new APIClass(accessKey, secertKey);
                var account = api.GetAccount();

                if(account != null)
                {
                    this.api = api;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public APIClass GetUpbitAPI()
        {
            return this.api;
        }

        public bool GetLoginFlag()
        {
            return this.loginFlag;
        }

        private void textBox_Secert_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_Login.Click += ReceiveButtonEvent;
            }

        }
    }
}
