using System;
using System.Collections.Generic;
using System.Linq;

namespace Bitcoin_Strategy
{
    static public class Core
    {
        public class Record
        {
            public DateTime Date;
            public double Rate;
        }
        public static void Run()
        {
            DateTime StartDate = new DateTime(2016, 1, 1);
            LoadHostory(StartDate.AddDays(-2));
            Archive = CompressArchive(Archive, TimeSpan.FromSeconds(30));
            //TestStrategy_OLD(StartDate);
            TestStrategy(StartDate);
        }


        public class Stats
        {
            public class Average
            {
                private int N;
                public double AveragePerformence;
                public void Add(double Performence)
                {
                    AveragePerformence = AveragePerformence * N + Performence;
                    N++;
                    AveragePerformence = AveragePerformence / N;
                }
            }
            public Dictionary<double, Average> Elements = new Dictionary<double, Average>();
            public void AddValue(double Value, Double Performence)
            {
                Average Average;
                if (!Elements.TryGetValue(Value, out Average))
                {
                    Average = new Average();
                    lock (Elements)
                        Elements.Add(Value, Average);
                }
                Average.Add(Performence);
            }
            public double? GetBestValue(out double BestPerformance)
            {
                double? BestValue = null;
                BestPerformance = 0.0;
                lock (Elements)
                    foreach (var Value in Elements.Keys)
                    {
                        double Perforance = Elements[Value].AveragePerformence;
                        if (Perforance >= BestPerformance)
                        {
                            BestValue = Value;
                            BestPerformance = Perforance;
                        }
                    }
                return BestValue;
            }
            public System.Windows.Forms.DataVisualization.Charting.Series ChardData()
            {
                var s = new System.Windows.Forms.DataVisualization.Charting.Series();
                lock (Elements)
                    foreach (var Time in Elements.Keys)
                    {
                        var Average = Elements[Time];
                        s.Points.AddXY(Time, Average.AveragePerformence);
                    }
                return s;
            }

        }

        public static Dictionary<string, Stats> StatsCollection = new Dictionary<string, Stats>();

        public static void TestStrategy(DateTime StartDate)
        {
            //New ULTRA fast funchtion with caching!

            double Moltiplicator;

            double D1_min;
            double D1_max;
            double M1_min;
            double M1_max;
            double D2_min;
            double D2_max;
            double M2_min;
            double M2_max;
            double D3_min;
            double D3_max;
            double S3_min;
            double S3_max;
            double D4_min;
            double D4_max;
            double S4_min;
            double S4_max;


            if (false)
            {
                Moltiplicator = 3;
                D1_min = 0.005;
                D1_max = 0.02;
                M1_min = 60;
                M1_max = 480;
                D2_min = 0.005;
                D2_max = 0.02;
                M2_min = 60;
                M2_max = 480;
                D3_min = 0.001;
                D3_max = 0.01;
                S3_min = 30;
                S3_max = 480;
                D4_min = 0.001;
                D4_max = 0.01;
                S4_min = 30;
                S4_max = 480;
            }
            else
            {
                Moltiplicator = 1;
                D1_min = 0.7;
                D1_max = 1.5;
                M1_min = 220;
                M1_max = 350;
                D2_min = 0.0;
                D2_max = 0.01;
                M2_min = 50;
                M2_max = 350;
                D3_min = 0;
                D3_max = 0.02;
                S3_min = 200;
                S3_max = 400;
                D4_min = 0.003;
                D4_max = 0.008;
                S4_min = 90;
                S4_max = 160;
            }

            double Step1 = 0.03 * Moltiplicator;
            double Step2 = 30 * Moltiplicator;
            double Step3 = 0.001 * Moltiplicator;
            double Step4 = 30 * Moltiplicator;

            double StartUSD = 1000.0;

            int StartId;
            for (StartId = 0; StartId < Archive.Length; StartId++)
            {
                if (Archive[StartId].Date > StartDate)
                {
                    break;
                }
            }

            var CachesTrendUp = new Dictionary<Monitorize, bool?[]>();
            var CachesTrendDown = new Dictionary<Monitorize, bool?[]>();
            var CachesRepentineUp = new Dictionary<Monitorize, bool?[]>();
            var CachesRepentineDown = new Dictionary<Monitorize, bool?[]>();

            bool?[] CacheTrendUp = null;
            bool?[] CacheTrendDown = null;
            bool?[] CacheRepentineUp = null;
            bool?[] CacheRepentineDown = null;

            Random rnd = new Random();
            Func<double, double, double, double> GetRnd = delegate (double min, double max, double step)
            {
                double range = max - min;
                int steps = 1 + (int)Math.Round(range / step);
                return min + step * (double)rnd.Next(steps);
            };

            double BestPerformence = 0.0;
            StategySettings BestSetting = null;

            StatsCollection.Clear();
            var StD1 = new Stats();
            StatsCollection.Add("D1", StD1);
            var StM1 = new Stats();
            StatsCollection.Add("M1", StM1);
            var StD2 = new Stats();
            StatsCollection.Add("D2", StD2);
            var StM2 = new Stats();
            StatsCollection.Add("M2", StM2);
            var StD3 = new Stats();
            StatsCollection.Add("D3", StD3);
            var StS3 = new Stats();
            StatsCollection.Add("S3", StS3);
            var StD4 = new Stats();
            StatsCollection.Add("D4", StD4);
            var StS4 = new Stats();
            StatsCollection.Add("S4", StS4);


            double D1 = 0, M1 = 0, D2 = 0, M2 = 0, D3 = 0, S3 = 0, D4 = 0, S4 = 0;
            Monitorize TrendUp, TrendDown, RepentineUp, RepentineDown;

            Func<Monitorize> GetTrendUp = delegate ()
            {
                D1 = GetRnd(D1_min, D1_max, Step1);
                M1 = GetRnd(M1_min, M1_max, Step2);
                var Result = new Monitorize { Delta = D1, Period = TimeSpan.FromMinutes(M1) };
                CacheTrendUp = new bool?[Archive.Length - 1];
                CachesTrendUp.Add(Result, CacheTrendUp);
                return Result;
            };
            TrendUp = GetTrendUp();

            Func<Monitorize> GetTrendDown = delegate ()
            {
                D2 = -GetRnd(D2_min, D2_max, Step1);
                M2 = GetRnd(M2_min, M2_max, Step2);
                var Result = new Monitorize { Delta = D2, Period = TimeSpan.FromMinutes(M2) };
                CacheTrendDown = new bool?[Archive.Length - 1];
                CachesTrendDown.Add(Result, CacheTrendDown);
                return Result;
            };
            TrendDown = GetTrendDown();

            Func<Monitorize> GetRepentineUp = delegate ()
            {
                D3 = GetRnd(D3_min, D3_max, Step3);
                S3 = GetRnd(S3_min, S3_max, Step4);
                var Result = new Monitorize { Delta = D3, Period = TimeSpan.FromSeconds(S3) };
                CacheRepentineUp = new bool?[Archive.Length - 1];
                CachesRepentineUp.Add(Result, CacheRepentineUp);
                return Result;
            };
            RepentineUp = GetRepentineUp();

            Func<Monitorize> GetRepentineDown = delegate ()
            {
                D4 = -GetRnd(D4_min, D4_max, Step3);
                S4 = GetRnd(S4_min, S4_max, Step4);
                var Result = new Monitorize { Delta = D4, Period = TimeSpan.FromSeconds(S4) };
                CacheRepentineDown = new bool?[Archive.Length - 1];
                CachesRepentineDown.Add(Result, CacheRepentineDown);
                return Result;
            };
            RepentineDown = GetRepentineDown();

            DateTime StartTest = DateTime.Now;
            for (int Count = 0; Count < 10000; Count++)
            {

                Form1.Istance.toolStripProgressBar1.Value = (int)(100.0 / 10000 * Count);
                Form1.Istance.Speed.Text = (Count / (DateTime.Now - StartTest).TotalHours).ToString("F1");
                if (Count % 100 == 0)
                {
                    double Out;
                    Form1.Istance.D1.Text = StD1.GetBestValue(out Out).ToString();
                    Form1.Istance.M1.Text = StM1.GetBestValue(out Out).ToString();
                    Form1.Istance.D2.Text = StD2.GetBestValue(out Out).ToString();
                    Form1.Istance.M2.Text = StM2.GetBestValue(out Out).ToString();
                    Form1.Istance.D3.Text = StD3.GetBestValue(out Out).ToString();
                    Form1.Istance.S3.Text = StS3.GetBestValue(out Out).ToString();
                    Form1.Istance.D4.Text = StD4.GetBestValue(out Out).ToString();
                    Form1.Istance.S4.Text = StS4.GetBestValue(out Out).ToString();
                }

                //Counter++;

                //Task.Factory.StartNew(() =>
                //{

                double USD = StartUSD;
                double BTC = 0;

                int LastId = Archive.Length - 1;
                for (int IdRec = StartId; IdRec < LastId; IdRec++)
                {
                    System.Windows.Forms.Application.DoEvents();
                    Strategy(IdRec, ref BTC, ref USD, 0.25, TrendUp, ref CacheTrendUp[IdRec], TrendDown, ref CacheTrendDown[IdRec], RepentineUp, ref CacheRepentineUp[IdRec], RepentineDown, ref CacheRepentineDown[IdRec]);
                }

                USD += BTC * Archive.Last().Rate;

                double PerformenceStategyLess = StartUSD / Archive[StartId].Rate * Archive.Last().Rate;
                double Performance = USD / PerformenceStategyLess;

                StD1.AddValue(D1, Performance);
                StM1.AddValue(M1, Performance);
                StD2.AddValue(D2, Performance);
                StM2.AddValue(M2, Performance);
                StD3.AddValue(D3, Performance);
                StS3.AddValue(S3, Performance);
                StD4.AddValue(D4, Performance);
                StS4.AddValue(S4, Performance);

                if (Performance > BestPerformence)
                {
                    BestPerformence = Performance;

                    Form1.Istance.label1.Text = "USD=" + USD;
                    System.Diagnostics.Debug.WriteLine("USD=" + USD);

                    BestSetting = new StategySettings() { Performence = Performance, TrendUp = TrendUp, TrendDown = TrendDown, RepentineUp = RepentineUp, RepentineDown = RepentineDown };
                    Support.StorageManager.SaveObject(BestSetting, "BestSetting");
                }

                int NewTrendCasualuty = 3;
                int n0 = rnd.Next(-NewTrendCasualuty, CachesTrendUp.Count);
                if (n0 < 0)
                    TrendUp = GetTrendUp();
                else
                {
                    TrendUp = CachesTrendUp.Keys.ElementAt(n0);
                    CacheTrendUp = CachesTrendUp[TrendUp];
                    D1 = TrendUp.Delta;
                    M1 = TrendUp.Period.TotalMinutes;
                }

                int n1 = rnd.Next(-NewTrendCasualuty, CachesTrendDown.Count);
                if (n1 < 0)
                    TrendDown = GetTrendDown();
                else
                {
                    TrendDown = CachesTrendDown.Keys.ElementAt(n1);
                    CacheTrendDown = CachesTrendDown[TrendDown];
                    D2 = TrendDown.Delta;
                    M2 = TrendDown.Period.TotalMinutes;
                }

                int n2 = rnd.Next(-NewTrendCasualuty, CachesRepentineUp.Count);
                if (n2 < 0)
                    RepentineUp = GetRepentineUp();
                else
                {
                    RepentineUp = CachesRepentineUp.Keys.ElementAt(n2);
                    CacheRepentineUp = CachesRepentineUp[RepentineUp];
                    D3 = RepentineUp.Delta;
                    S3 = RepentineUp.Period.TotalSeconds;
                }

                int n3 = rnd.Next(-NewTrendCasualuty, CachesRepentineDown.Count);
                if (n3 < 0)
                    RepentineDown = GetRepentineDown();
                else
                {
                    RepentineDown = CachesRepentineDown.Keys.ElementAt(n3);
                    CacheRepentineDown = CachesRepentineDown[RepentineDown];
                    D4 = RepentineDown.Delta;
                    S4 = RepentineDown.Period.TotalSeconds;
                }

            }
            //System.Diagnostics.Debug.WriteLine(Counter);
            System.Diagnostics.Debugger.Break();
        }

        private class CacheElement
        {
            public bool? IsTrendUp;
            public bool? IsTrendDown;
            public bool? IsRepentineUp;
            public bool? IsRepentineDown;
        }

        public static void TestStrategy_OLD(DateTime StartDate)
        {
            //This is a old function, now obsolete


            double StartUSD = 1000.0;

            int StartId;
            for (StartId = 0; StartId < Archive.Length; StartId++)
            {
                if (Archive[StartId].Date > StartDate)
                {
                    break;
                }
            }

            bool Resume = true;
            double BestPerformenceUSD = 0;
            StategySettings BestSetting = null;
            double Moltiplicator = 3;
            double Step1 = 0.03 * Moltiplicator;
            double Step2 = 30 * Moltiplicator;
            double Step3 = 0.001 * Moltiplicator;
            double Step4 = 30 * Moltiplicator;
            for (double D1 = 0.005; D1 <= 2.0; D1 += Step1)
            {
                Form1.Istance.toolStripProgressBar1.Value = (int)(100.0 / (2.0 - 0.005) * D1 - 0.005);
                for (double M1 = 60.0; M1 <= 480.0; M1 += Step2)
                {
                    var TrendUp = new Monitorize { Delta = D1, Period = TimeSpan.FromMinutes(M1) };
                    for (double D2 = 0.005; D2 <= 2.0; D2 += Step1)
                    {
                        for (double M2 = 60.0; M2 <= 480.0; M2 += Step2)
                        {
                            var TrendDown = new Monitorize { Delta = -D2, Period = TimeSpan.FromMinutes(M2) };
                            for (double D3 = 0.001; D3 <= 0.01; D3 += Step3)
                            {
                                for (double S3 = 30.0; S3 <= 480.0; S3 += Step4)
                                {
                                    var RepentineUp = new Monitorize { Delta = D3, Period = TimeSpan.FromSeconds(S3) };
                                    for (double D4 = 0.001; D4 <= 0.01; D4 += Step3)
                                    {
                                        for (double S4 = 30.0; S4 <= 480.0; S4 += Step4)
                                        {
                                            var RepentineDown = new Monitorize { Delta = -D4, Period = TimeSpan.FromSeconds(S4) };

                                            if (Resume)
                                            {
                                                Resume = false;
                                                var ResumeRec = (StategySettings)Support.StorageManager.LoadObject(typeof(StategySettings), "BestSetting");
                                                if (ResumeRec != null)
                                                {
                                                    TrendUp = ResumeRec.TrendUp;
                                                    TrendDown = ResumeRec.TrendDown;
                                                    RepentineUp = ResumeRec.RepentineUp;
                                                    RepentineDown = ResumeRec.RepentineDown;
                                                    D1 = TrendUp.Delta;
                                                    M1 = TrendUp.Period.TotalMinutes;
                                                    D2 = -TrendDown.Delta;
                                                    M2 = TrendDown.Period.TotalMinutes;
                                                    D3 = RepentineUp.Delta;
                                                    S3 = RepentineUp.Period.TotalSeconds;
                                                    D4 = -RepentineDown.Delta;
                                                    S4 = RepentineDown.Period.TotalSeconds;
                                                }
                                            }


                                            double USD = StartUSD;
                                            double BTC = 0;

                                            for (int IdRec = StartId; IdRec < Archive.Length; IdRec++)
                                            {
                                                Strategy(IdRec, ref BTC, ref USD, 0.25, TrendUp, TrendDown, RepentineUp, RepentineDown);
                                            }


                                            USD += BTC * Archive.Last().Rate;
                                            System.Windows.Forms.Application.DoEvents();


                                            if (USD > BestPerformenceUSD)
                                            {
                                                BestPerformenceUSD = USD;
                                                Form1.Istance.label1.Text = "USD=" + USD;
                                                System.Diagnostics.Debug.WriteLine("USD=" + USD);

                                                double PerformenceStategyLess = StartUSD / Archive[StartId].Rate * Archive.Last().Rate;
                                                BestSetting = new StategySettings() { Performence = USD / PerformenceStategyLess, TrendUp = TrendUp, TrendDown = TrendDown, RepentineUp = RepentineUp, RepentineDown = RepentineDown };
                                                Support.StorageManager.SaveObject(BestSetting, "BestSetting");
                                            }
                                            //}

                                            //});
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //System.Diagnostics.Debug.WriteLine(Counter);
            System.Diagnostics.Debugger.Break();
        }

        public class StategySettings
        {
            public StategySettings()
            {
            }
            public double Performence;
            public Monitorize TrendUp;
            public Monitorize TrendDown;
            public Monitorize RepentineUp;
            public Monitorize RepentineDown;
        }

        public static Record[] Archive;
        public static void LoadHostory(DateTime StartDate)
        {
            List<Record> ArchiveList = new List<Record>();
            //http://api.bitcoincharts.com/v1/csv/ Data source CSV
            String File = System.AppDomain.CurrentDomain.BaseDirectory + @"../../.bitstampUSD.csv";
            var reader = new System.IO.StreamReader(System.IO.File.OpenRead(File));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var Date = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(long.Parse(values[0])).ToLocalTime();
                if (Date >= StartDate)
                {
                    var r = new Record();
                    r.Date = Date;
                    r.Rate = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
                    ArchiveList.Add(r);
                }
            }
            reader.Close();
            Archive = ArchiveList.ToArray();
        }

        public static Record[] CompressArchive(Record[] Archive, TimeSpan Block)
        {
            List<Record> ArchiveList = new List<Record>();
            DateTime Position = Archive[0].Date + Block;
            var Last = Archive[Archive.Length - 1];
            int N = 0;
            double Sum = 0.0;
            foreach (var item in Archive)
            {
                if (item.Date >= Position)
                {
                    if (N > 0)
                    {
                        ArchiveList.Add(new Record() { Date = Position, Rate = Sum / (double)N });
                        Sum = 0.0;
                        N = 0;
                    }
                    do
                    {
                        Position += Block;
                    } while (item.Date >= Position);
                }
                N++;
                Sum += item.Rate;
            }
            if (N > 0)
                ArchiveList.Add(new Record() { Date = Position, Rate = Sum / (double)N });

            return ArchiveList.ToArray();
        }

        public class Monitorize
        {
            public Monitorize() { }
            public long Ticks
            {
                //Is necessary for serialize the TimeSpan
                get
                {
                    return Period.Ticks;
                }
                set
                {
                    Period = TimeSpan.FromTicks(value);
                }
            }
            public string TeriodString
            {
                //Is necessary for serialize the TimeSpan
                get
                {
                    return Period.ToString(@"dd\.hh\:mm\:ss");
                }
                set { }
            }

            public TimeSpan Period;
            public double Delta;
        }
        public enum Operation { None, Buy, Sell }

        private static void Strategy(int RecId, ref double BTC, ref double USD, double Commission, Monitorize TrendUp, Monitorize TrendDown, Monitorize RepentineUp, Monitorize RepentineDown)
        {
            bool IsTrendUp = OutOfDelta(RecId, TrendUp);
            bool IsRepentineDown = false;
            if (IsTrendUp) //Load the value if is necessary (Speed UP)
                IsRepentineDown = OutOfDelta(RecId, RepentineDown);
            bool IsTrendDown = OutOfDelta(RecId, TrendDown);
            bool IsRepentineUp = false;
            if (IsTrendDown) //Load the value if is necessary (Speed UP)
                IsRepentineUp = OutOfDelta(RecId, RepentineUp);
            Strategy(RecId, ref BTC, ref USD, Commission, IsTrendUp, IsTrendDown, IsRepentineUp, IsRepentineDown);
        }

        private static void Strategy(int RecId, ref double BTC, ref double USD, double Commission, Monitorize TrendUp, ref bool? CacheIsTrendUp, Monitorize TrendDown, ref bool? CacheIsTrendDown, Monitorize RepentineUp, ref bool? CacheIsRepentineUp, Monitorize RepentineDown, ref bool? CacheIsRepentineDown)
        {
            //bool? IsTrendUp = CacheIsTrendUp;
            //bool? IsTrendDown = CacheIsTrendDown;
            //bool? IsRepentineUp = CacheIsRepentineUp;
            //bool? IsRepentineDown = CacheIsRepentineDown;

            if (CacheIsTrendUp == null)
            {
                CacheIsTrendUp = OutOfDelta(RecId, TrendUp);
                //CacheIsTrendUp = IsTrendUp;
            }

            if (CacheIsTrendUp == true)
            {
                if (CacheIsRepentineDown == null)
                {
                    CacheIsRepentineDown = OutOfDelta(RecId, RepentineDown);
                    //CacheIsRepentineDown = IsRepentineDown;
                }
            }
            else
            {
                if (CacheIsTrendDown == null)
                {
                    CacheIsTrendDown = OutOfDelta(RecId, TrendDown);
                    //CacheIsTrendDown = IsTrendDown;
                }

                if (CacheIsTrendDown == true)
                {
                    if (CacheIsRepentineUp == null)
                    {
                        CacheIsRepentineUp = OutOfDelta(RecId, RepentineUp);
                        //CacheIsRepentineUp = IsRepentineUp;
                    }
                }
            }

            Strategy(RecId, ref BTC, ref USD, Commission, CacheIsTrendUp, CacheIsTrendDown, CacheIsRepentineUp, CacheIsRepentineDown);
        }

        public static Operation  Strategy(int RecId, ref double BTC, ref double USD, double Commission, bool? IsTrendUp, bool? IsTrendDown, bool? IsRepentineUp, bool? IsRepentineDown)
        {
            Operation Execute = Operation.None;
            if (IsTrendUp == true)
            {
                if (IsRepentineDown == true)
                {
                    Execute = Operation.Sell;//Buy bitcoin
                }
            }
            else if (IsTrendDown == true)
            {
                if (IsRepentineUp == true)
                {
                    Execute = Operation.Buy;//Sell bitcoin
                }
            }
            if (Execute == Operation.Sell && BTC >= 0.1)
            {//Sell bitcoin
                double Add = BTC * Archive[RecId].Rate;//Add USD
                Add -= Add / 100.0 * Commission;
                USD += Add;
                BTC = 0.0;
            }
            else if (Execute == Operation.Buy && USD >= 50)
            {//Buy bitcoin
                double Add = USD / Archive[RecId].Rate;//Add bitcoin
                Add -= Add / 100.0 * Commission;
                BTC += Add;
                USD = 0.0;
            }
            return Execute;
        }

        public static Operation ApplyStrategy(StategySettings Setting, ref double BTC, ref double USD, double Commission)
        {
            int RecId = Archive.Count() - 1;
            bool IsTrendUp = OutOfDelta(RecId,Setting.TrendUp);
            bool IsRepentineDown = false;
            if (IsTrendUp) //Load the value if is necessary (Speed UP)
                IsRepentineDown = OutOfDelta(RecId, Setting.RepentineDown);
            bool IsTrendDown = OutOfDelta(RecId, Setting.TrendDown);
            bool IsRepentineUp = false;
            if (IsTrendDown) //Load the value if is necessary (Speed UP)
                IsRepentineUp = OutOfDelta(RecId, Setting.RepentineUp);
           return Core.Strategy(RecId,ref BTC, ref USD, Commission, IsTrendUp, IsTrendDown, IsRepentineUp, IsRepentineDown);
        }
        static public bool OutOfDelta(int RecId, Monitorize Monitor)
        {
            Record StartRec = Archive[RecId];
            Record ExitRec = null;
            DateTime Exit = StartRec.Date - Monitor.Period;

            int Id = RecId - 1;
            while (Archive[Id].Date > Exit)
            {
                ExitRec = Archive[Id];
                Id--;
            }
            if (ExitRec == null)
                return false;
            //double Delta = StartRec.Rate - ExitRec.Rate;
            double Variation = 1 - StartRec.Rate / ExitRec.Rate;
            if (Monitor.Delta < 0)
            {
                if (Variation < Monitor.Delta)
                    return true;
                else
                    return false;
            }
            else
            {
                if (Variation > Monitor.Delta)
                    return true;
                else
                    return false;

            }
        }
    }
}
