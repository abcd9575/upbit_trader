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
                var data = api.GetCandleMinutes("KRW-BTC", APIClass.MinuteUnit._1, default(DateTime), 200);
                var temp = data.Select(a => a).ToList();
                foreach (CandleMinute candles in temp)
                {
                    //Console.WriteLine(JsonConvert.SerializeObject(candles));
                    //var json_candle = JObject.Parse(JsonConvert.SerializeObject(candles));
                    //string market = (string)json_candle["market"];
                    //string candle_date_time_utc = ((DateTime)json_candle["candle_date_time_utc"]).ToString("yyyy-MM-dd HH:mm:dd");
                    //string candle_date_time_kst = ((DateTime)json_candle["candle_date_time_kst"]).ToString("yyyy-MM-dd HH:mm:dd");
                    //double opening_price = (double)json_candle["opening_price"];
                    //double high_price = (double)json_candle["high_price"];
                    //double low_price = (double)json_candle["low_price"];
                    //double trade_price = (double)json_candle["trade_price"];
                    //long timestamp = (long)json_candle["timestamp"];
                    //double candle_acc_trade_price = (double)json_candle["candle_acc_trade_price"];
                    //double candle_acc_trade_volume = (double)json_candle["candle_acc_trade_volume"];
                    //int unit = (int)json_candle["unit"];
                    try
                    {
                        using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                        {
                            mysql.Open();
                            //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                            string fields = "";
                            Type candle_type = typeof(CandleMinute);
                            System.Reflection.FieldInfo[] fieldInfos = candle_type.GetFields();
                            foreach (System.Reflection.FieldInfo info in fieldInfos)
                            {
                                fields += info.Name + ", ";
                            }
                            fields = fields.Substring(0, fields.Length - 2);


                            string insertQuery = string.Format("INSERT INTO btc_min (" +
                                fields + ") VALUES (" +
                                "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');",
                                candles.market, candles.candle_date_time_utc, candles.candle_date_time_kst, candles.opening_price, candles.high_price,
                                candles.low_price, candles.trade_price, candles.timestamp, candles.candle_acc_trade_price, candles.candle_acc_trade_volume, candles.unit);

                            MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                            if (command.ExecuteNonQuery() != 1)
                                MessageBox.Show("Failed to insert data.");

                            selectTable();

                        }
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

        private void insertTable()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                    string insertQuery = string.Format("INSERT INTO btc_min (name, phone) VALUES ('{0}', '{1}');", "testname", "testnumber");

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");

                    selectTable();


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
                        item.SubItems.Add(table[""].ToString());
                        item.SubItems.Add(table["phone"].ToString());
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
