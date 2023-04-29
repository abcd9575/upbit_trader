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
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace AutoTrader.View
{
    public partial class MainForm : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "upbit";
        string _id = "root";
        string _pw = "1q2w3e$R";
        string _connectionAddress = "";


        private APIClass api;
        public MainForm( APIClass api )
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            this.api = api;
        }

        private void button_1min_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button_1min))
            {
                //var data = api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1, default(DateTime), 200);
                var data = api.GetCandleWeeks("KRW-BTC", default(DateTime), 200);
                var temp = data.Select(a => a).ToList();
                //foreach (CandleMinute candles in temp)
                //foreach (CandleMonth candles in temp)
                foreach (CandleWeek candles in temp)
                {
                    try
                    {
                        Mysql query = new Mysql();
                        query.getLastdata("btc_min", "KRW-BTC");
                        //query.insert_candle_min(candles, "btc_min");
                        query.insert_candle_week(candles, "btc_week");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //string va = (string)JObject["market"].ToString();
                }

                Console.WriteLine(api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1,default(DateTime),200));
            }
        }


        private void selectTable()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM btc_min");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        //item.SubItems.Add(table[""].ToString());
                        //item.SubItems.Add(table["phone"].ToString());
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private List<CandleMinute> getCandle(int time)
        {
            return api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1);
        }
    }
}
