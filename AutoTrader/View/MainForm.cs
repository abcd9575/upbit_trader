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
                    Console.WriteLine(JsonConvert.SerializeObject(candles));

                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                    {
                        mysql.Open();
                        //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                        string insertQuery = string.Format("INSERT INTO new_table (name, phone) VALUES ('{0}', '{1}');", "testname", "testnumber");

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
                    string selectQuery = string.Format("SELECT * FROM new_table");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
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
