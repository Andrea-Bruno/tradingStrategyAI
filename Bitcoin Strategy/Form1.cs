using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_Strategy
{
    public partial class Form1 : Form
    {
        public static Form1 Istance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Benchmark
            //var n = DateTime.Now;
            //do
            //{
            //} while (n == DateTime.Now);

            //for (Single i = 0; i < 16000000; i++)
            //{

            //}
            //System.Diagnostics.Debug.WriteLine("single " + (DateTime.Now - n).TotalSeconds);


            //n = DateTime.Now;
            //do
            //{
            //} while (n == DateTime.Now);

            //for (double i = 0; i < 16000000; i++)
            //{

            //}
            //System.Diagnostics.Debug.WriteLine("double " + (DateTime.Now - n).TotalSeconds);


            Core.Run();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Istance = this;
        }

        private void ClickTextBox(object sender, EventArgs e)
        {
            string Name = ((System.Windows.Forms.TextBox)sender).Name;
            Core.Stats Stats = Core.StatsCollection[Name];
            chart1.Series.Clear();
            if (Stats != null)
                chart1.Series.Add(Stats.ChardData());

            //switch (((System.Windows.Forms.TextBox)sender).Name)
            //{
            //    case "D1":
            //        Stats = Core.StatsCollection["D1"];
            //        break;
            //    case "M1":
            //        break;
            //    case "D2":
            //        break;
            //    case "M2":
            //        break;
            //    case "D3":
            //        break;
            //    case "S3":
            //        break;
            //    case "D4":
            //        break;
            //    case "S4":
            //        break;
            //    default:
            //        break;
            //}
        }

        private void ShowRobot_Click(object sender, EventArgs e)
        {
            var Trader = new Trader();
            Trader.Show();
        }
    }
}
