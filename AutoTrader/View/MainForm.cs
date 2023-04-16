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
    public partial class MainForm : Form
    {
        private APIClass api;
        public MainForm( APIClass api )
        {
            InitializeComponent();

            this.api = api;
        }
    }
}
