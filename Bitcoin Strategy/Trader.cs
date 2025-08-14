using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Bitcoin_Strategy
{
    public partial class Trader : Form
    {
        int ChartCuloms = 60;
        TimeSpan ChartPeriod = TimeSpan.FromHours(1);
        static public List<Core.Record> RateHistory = new List<Core.Record>(); //Use toi save a chart
        static public double BtcLast;
        public Trader()
        {
            InitializeComponent();
            UpdareBtcRate.Interval = 10000;
            UpdareBtcRate.Enabled = true;
        }

        static public System.Windows.Forms.DataVisualization.Charting.Series DataToSeries(List<Core.Record> Records)
        {
            var s = new System.Windows.Forms.DataVisualization.Charting.Series();
            //for (int i = Records.Count() - 1; i >= 0; i--)
            //{
            //    var Rate  = Records[i];
            //    s.Points.AddXY(Rate.Date, Rate.Rate);
            //}
            foreach (var Rate in Records)
            {
                if (Rate.Rate != 0)
                {
                    s.Points.AddXY(Rate.Date, Rate.Rate);
                }
            }
            return s;
        }


        static public List<Core.Record> ZoomRecords(List<Core.Record> Records, int Culoms, TimeSpan Range)
        {
            //var RateArray = new List<Core.Record>();
            var List = new Dictionary<int, Core.Record>();
            lock (Records)
            {


                var ThisTime = Records[Records.Count - 1].Date;



                //for (int N = 0; N < Culoms; N++)
                //{
                //    var Empty = new Core.Record();
                //    Empty.Date = ThisTime.AddMilliseconds(-(Range.TotalMilliseconds / Culoms * N));
                //    RateArray[N] = Empty;
                //}

                int[] Added = new int[Culoms];


                for (int Index = Records.Count - 1; Index >= 0; Index--)
                {
                    var Rate = Records[Index];
                    //foreach (var Rate in Records)
                    //{
                    TimeSpan FromNow = ThisTime - Rate.Date;
                    var position = FromNow.TotalMilliseconds / (Range.TotalMilliseconds / Culoms);
                    int N = (int)position;
                    if (N < Culoms)
                    {
                        if (!List.ContainsKey(N))
                        {
                            var Empty = new Core.Record();
                            Empty.Date = ThisTime.AddMilliseconds(-(Range.TotalMilliseconds / Culoms * N));
                            List[N] = Empty;
                        }

                        List[N].Rate = (List[N].Rate * Added[N] + Rate.Rate) / (Added[N] + 1);
                        Added[N] += 1;
                        //RateArray[N].Rate += Rate.Rate;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return List.Values.ToList();
        }

        private void DeviceOfflineEvent(Exception Ex)
        {

        }


        private void UpdareBtcRate_Tick(object sender, EventArgs e)
        {
            //Source 
            string jsonHtml = null;
            using (WebClient client = new WebClient())
            {
                try
                {
                    jsonHtml = client.DownloadString("https://www.bitstamp.net/api/v2/ticker/btcusd/");
                }
                catch (Exception Ex)
                {
                    DeviceOfflineEvent(Ex);
                    return;
                }
            }
            Dictionary<String, String> Datas = Support.JsonManager.JesonToKeyValue(jsonHtml);
            BtcLast = double.Parse(Datas["last"], System.Globalization.CultureInfo.InvariantCulture);
            Core.Record NewRecord = new Core.Record();
            NewRecord.Date = DateTime.Now.ToUniversalTime();
            NewRecord.Rate = BtcLast;
            lock (RateHistory)
                RateHistory.Add(NewRecord);

            BtcRate.Text = "$" + BtcLast;
            var Data = ZoomRecords(RateHistory, ChartCuloms, ChartPeriod);
            chart1.Series.Clear();
            chart1.Series.Add(DataToSeries(Data));
            double? min = null;
            double? max = null;
            foreach (var dt in Data)
            {
                var y = dt.Rate;
                if (y != 0)
                {
                    if (y < min || max == null)
                        min = y;
                    if (y > max || max == null)
                        max = y;
                }
            }
            if (max != null && min != null)
            {
                double margin = (double)max / 200; //0.5%
                if (min == max)
                {
                    margin = (double)max / 200; //0.5%
                }
                else
                {
                    margin = ((double)max - (double)min) / 10;
                }
                min -= margin;
                max += margin;

                Support.StorageManager.SaveObject(max, "max");
                Support.StorageManager.SaveObject(min, "min");


                chart1.ChartAreas[0].AxisY.Maximum = (double)max;
                chart1.ChartAreas[0].AxisY.Minimum = (double)min;
            }
            if (ChartPeriod.TotalMilliseconds / ChartCuloms < 60000)
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            else
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";

            TakeADecision();
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }



        double CurrentUSD;
        double CurrentBTC;

        Core.StategySettings Setting = (Core.StategySettings)Support.StorageManager.LoadObject(typeof(Core.StategySettings), "BestSetting");

        private void TakeADecision()
        {
            TimeSpan MaxTimespan = Setting.RepentineDown.Period;
            if (MaxTimespan < Setting.RepentineUp.Period)
                MaxTimespan = Setting.RepentineUp.Period;
            if (MaxTimespan < Setting.TrendUp.Period)
                MaxTimespan = Setting.TrendUp.Period;
            if (MaxTimespan < Setting.TrendDown.Period)
                MaxTimespan = Setting.TrendDown.Period;

            if ((RateHistory.Last().Date - RateHistory.First().Date) >= MaxTimespan)
            {

                Core.Archive = RateHistory.ToArray();
                Core.Operation Operation = Core.ApplyStrategy(Setting, ref CurrentBTC, ref CurrentUSD, 0.25);
                if (Operation == Core.Operation.Buy)
                {
                }
                else if (Operation == Core.Operation.Sell)
                {

                }
                this.Operation.Text = Operation.ToString();
            }
        }
    }
}
