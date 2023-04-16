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
using AutoTrader.AutoTrader.Model;
using Newtonsoft.Json;

namespace AutoTrader.View
{
    public partial class MainForm : Form
    {
        private APIClass api;
        public MainForm( APIClass api )
        {
            InitializeComponent();

            this.api = api;
        }

        private void button_1min_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button_1min))
            {
                var data = api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1, default(DateTime), 200);
                var temp = data.Select(a => a).ToList();
                foreach (CandleMinute candles in temp)
                    Console.WriteLine(JsonConvert.SerializeObject(candles));

                Console.WriteLine(api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1,default(DateTime),200));
            }
        }

        private List<CandleMinute> getCandle(int time)
        {
            return api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1);
        }
    }
}
