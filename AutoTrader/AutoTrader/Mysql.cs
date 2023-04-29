using AutoTrader.AutoTrader.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTrader.AutoTrader
{
    public class Mysql
    {
        private string _server = "localhost";
        private int _port = 3306;
        private string _database = "upbit";
        private string _id = "root";
        private string _pw = "1q2w3e$R";
        private string _connectionAddress = "";

        public Mysql()
        {
            this._connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", this._server, this._port, this._database, this._id, _pw);
        }
        public void insert_candle_min(CandleMinute candle, string tablename)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                mysql.Open();
                string insertQuery = string.Format("INSERT INTO " + tablename + "(market, candle_date_time_utc, candle_date_time_kst, opening_price, high_price, " +
                "low_price, trade_price, timestamp, candle_acc_trade_price, candle_acc_trade_volume, unit) VALUES (" +
                                "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');",
                                candle.market, candle.candle_date_time_utc, candle.candle_date_time_kst, candle.opening_price, candle.high_price,
                                candle.low_price, candle.trade_price, candle.timestamp, candle.candle_acc_trade_price, candle.candle_acc_trade_volume, candle.unit);
                MySqlCommand command = new MySqlCommand(insertQuery, mysql);
            
                if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to insert data.");

            }
        }
        public void insert_candle_day(CandleDay candle, string tablename)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                mysql.Open();
                string insertQuery = string.Format("INSERT INTO " + tablename + "(market, candle_date_time_utc, candle_date_time_kst, opening_price, high_price, " +
                "low_price, trade_price, timestamp, candle_acc_trade_price, candle_acc_trade_volume, prev_closing_price, change_price, change_rate, converted_trade_price) VALUES (" +
                                "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');",
                                candle.market, candle.candle_date_time_utc, candle.candle_date_time_kst, candle.opening_price, candle.high_price,
                                candle.low_price, candle.trade_price, candle.timestamp, candle.candle_acc_trade_price, candle.candle_acc_trade_volume, candle.prev_closing_price, candle.change_price, candle.change_rate, candle.converted_trade_price);
                MySqlCommand command = new MySqlCommand(insertQuery, mysql);

                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            }
        }
        public void insert_candle_month(CandleMonth candle, string tablename)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                mysql.Open();
                string insertQuery = string.Format("INSERT INTO " + tablename + "(market, candle_date_time_utc, candle_date_time_kst, opening_price, high_price, " +
                "low_price, trade_price, timestamp, candle_acc_trade_price, candle_acc_trade_volume, first_day_of_period) VALUES (" +
                                "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');",
                                candle.market, candle.candle_date_time_utc, candle.candle_date_time_kst, candle.opening_price, candle.high_price,
                                candle.low_price, candle.trade_price, candle.timestamp, candle.candle_acc_trade_price, candle.candle_acc_trade_volume, candle.first_day_of_period);
                MySqlCommand command = new MySqlCommand(insertQuery, mysql);

                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            }
        }

        public void insert_candle_week(CandleWeek candle, string tablename)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                mysql.Open();
                string insertQuery = string.Format("INSERT INTO " + tablename + "(market, candle_date_time_utc, candle_date_time_kst, opening_price, high_price, " +
                "low_price, trade_price, timestamp, candle_acc_trade_price, candle_acc_trade_volume, first_day_of_period) VALUES (" +
                                "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');",
                                candle.market, candle.candle_date_time_utc, candle.candle_date_time_kst, candle.opening_price, candle.high_price,
                                candle.low_price, candle.trade_price, candle.timestamp, candle.candle_acc_trade_price, candle.candle_acc_trade_volume, candle.first_day_of_period);
                MySqlCommand command = new MySqlCommand(insertQuery, mysql);

                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            }
        }
        public DateTime getLastdata(string tablename, string market)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                mysql.Open();
                //string selectQuery = string.Format("SELECT MAX(candle_date_time_kst) FROM " + tablename + " WHERE market =" + market +";");
                string selectQuery = string.Format("SELECT * FROM "+ tablename +" ORDER BY candle_date_time_kst ASC LIMIT 1;");
                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader table = command.ExecuteReader();
                table.Read();
                if (table.FieldCount < 1)
                    MessageBox.Show("Failed to select data.");
                else
                    for (int i = 0; i < table.FieldCount-1; i++)
                    {
                        string field = table.GetName(i);
                        Console.WriteLine(table[field]);
                    }
                table.Close();
                //if (command.ExecuteNonQuery() != 1)
                
            }

            return DateTime.Now;
        }
    }
}
