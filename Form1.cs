using Cyfrowe.Logic;
using Cyfrowe.Logic.Signals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Cyfrowe.Logic.SignalTypes;
using Point = Cyfrowe.Logic.Point;

namespace Cyfrowe
{
    
    public partial class CPS : Form
    {
        private List<Signal> AllSignals =
             new List<Signal>
             {
                new S1(),
                new S2(),
                new S3(),
                new S4(),
                new S5(),
                new S6(),
                new S7(),
                new S8(),
                new S9(),
                new S10(),
                new S11()
             };
        private Signal CurrentSignal;
        public CPS()
        {
            InitializeComponent();
        }

        private void SignalSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSignal = AllSignals[SignalSelect.SelectedIndex];
            
            if(CurrentSignal.CzyCzestotliwosc == true)
            {
                this.CzestotliwoscInput.Enabled = true;
            } else 
                this.CzestotliwoscInput.Enabled = false;

            if (CurrentSignal.CzyAmplituda == true)
            {
                this.AmplitudaInput.Enabled = true;
            }
            else
                this.AmplitudaInput.Enabled = false;

            if (CurrentSignal.CzyczasPoczatkowy == true)
            {
                this.CzasPoczatkowyInput.Enabled = true;
            }
            else
                this.CzasPoczatkowyInput.Enabled = false;

            if (CurrentSignal.CzyCzasTrwaniaSygnalu == true)
            {
                this.CzasTrwaniaSygnaluInput.Enabled = true;
            }
            else
                this.CzasTrwaniaSygnaluInput.Enabled = false;

            if (CurrentSignal.CzyOkresSygnalu == true)
            {
                this.OkresSygnaluInput.Enabled = true;
            }
            else
                this.OkresSygnaluInput.Enabled = false;

            if (CurrentSignal.CzySkokCzasowy == true)
            {
                this.SkokCzasowyInput.Enabled = true;
            }
            else
                this.SkokCzasowyInput.Enabled = false;

            if (CurrentSignal.CzyWspolczynnikWypelnienia == true)
            {
                this.WspolczynnikWypelnieniaInput.Enabled = true;
            }
            else
                this.WspolczynnikWypelnieniaInput.Enabled = false;

            if (CurrentSignal.CzyNrPierwszejProbki == true)
            {
                this.NumerPierwszejProbkiInput.Enabled = true;
            }
            else
                this.NumerPierwszejProbkiInput.Enabled = false;
            if (CurrentSignal.CzyNrProbki == true)
            {
                this.NumerProbkiSkokuInput.Enabled = true;
            }
            else
                this.NumerProbkiSkokuInput.Enabled = false;
            if (CurrentSignal.CzyPrawdopodobienstwoA == true)
            {
                this.PrawdopodobienstwoAInput.Enabled = true;
            }
            else
                this.PrawdopodobienstwoAInput.Enabled = false;



        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            SetVariables(CurrentSignal);
            Signal signal = CurrentSignal;
            
            if (SignalSelect.SelectedIndex >= 0 && SignalSelect.SelectedIndex <=11)
            {
                
                //Display current setting
                //this.CzasTrwaniaSygnaluInput.Text = signal.CzasTrwaniaSygnalu.ToString();
                //this.CzasPoczatkowyInput.Text = signal.PoczatekSygnalu.ToString();
                //this.AmplitudaInput.Text = signal.Amplituda.ToString();
                //this.CzestotliwoscInput.Text = signal.CzestotliwoscProbkowania.ToString();
                //this.WspolczynnikWypelnieniaInput.Text = signal.WspolczynnikWypelnienia.ToString();
                //this.OkresSygnaluInput.Text = signal.OkresPodstawowy.ToString();
                //this.SkokCzasowyInput.Text = signal.SkokCzasowy.ToString();


                //Calculating
                this.MocSredniaOutput.Text = signal.CalculateMocSrednia().ToString();
                this.WariacjaOutput.Text = signal.CalculateWariacje().ToString();
                this.WartoscSkutecznaOutput.Text = signal.CalculateWartoscSkuteczna().ToString();
                this.WartoscSredniaBezwzglednaOutpu.Text = signal.CalculateSredniaWartoscBezwzgledna().ToString();
                this.WartoscSredniaOutput.Text = signal.CalculateWartoscSrednia().ToString();

                drawPlot(signal);
                

                //Drawing Histogram
                this.Histogram.Series.Clear();
                this.Histogram.Titles.Clear();
                this.Histogram.Titles.Add(this.SignalSelect.SelectedItem.ToString());
                int size = Int32.Parse(this.HistogramSelect.SelectedItem.ToString());
                


                if (size == null) size = 5;
                int[] values = new int[size];
                double[] value = new double[size];
                double min = signal.PointList.Min(r => r.Y);
                double max = signal.PointList.Max(r => r.Y);
                //this.Histogram.ChartAreas[0].AxisX.Maximum = max;
                //this.Histogram.ChartAreas[0].AxisX.Minimum = min;
                
                this.Histogram.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
                this.Histogram.ChartAreas[0].AxisY.IsStartedFromZero = true;
                double skip = (max - min) / size;
               // this.Histogram.Titles.Add("Zakres +/-" + Math.Round(skip/2,2));
                value[0] = min;

                for (int i = 1; i < size; i++)
                {
                    value[i] = value[i - 1] + skip;
                }

                Series HSeries = this.Histogram.Series.Add(this.SignalSelect.SelectedItem.ToString());
                foreach (Point point in signal.PointList)
                {
                   for(int i =0; i < size-1; i++)
                        if(point.Y>= value[i] && point.Y < value[i+1])
                        {
                            values[i]++;
                            continue;
                        }
                    if (point.Y > value[size - 1])
                        values[size - 1]++;
                }
                
                for(int i = 0; i < size; i++)
                {
                    HSeries.Points.AddXY(Math.Round(value[i],2) + size/4, values[i]);
                }
                this.Histogram.ChartAreas[0].AxisY.Maximum = values.Max(r => r);
                this.Histogram.ChartAreas[0].AxisX.Maximum = value.Max(r => r)+size; 
                this.Histogram.ChartAreas[0].AxisX.Minimum = value.Min(r => r) ; 


                foreach (Series s in Histogram.Series)
                    s.CustomProperties = "PointWidth = 1";

            }
        }

        private void Plot_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void drawPlot(Signal signal)
        {
            //Drawing Plot

            this.Plot.Series.Clear();
            this.Plot.Titles.Clear();
            this.Plot.Titles.Add(this.SignalSelect.SelectedItem.ToString());

            Series series = this.Plot.Series.Add(this.SignalSelect.SelectedItem.ToString());
            if (signal.Rodzaj.Equals(Types.Ciagly))
                series.ChartType = SeriesChartType.Line;
            else series.ChartType = SeriesChartType.Point;

            foreach (Point point in signal.PointList)
                series.Points.AddXY(point.X, point.Y);


        }

        private void SetVariables(Signal signal)
        {
            if (this.AmplitudaInput.Enabled == true) {
                double A = Double.Parse(this.AmplitudaInput.Text.ToString());
                signal.Amplituda = A;
            }
            if (this.CzestotliwoscInput.Enabled == true)
            {
                double f = Double.Parse(this.CzestotliwoscInput.Text.ToString());
                signal.CzestotliwoscProbkowania = f;
            }
            if (this.CzasPoczatkowyInput.Enabled == true)
            {
                double t1 = Double.Parse(this.CzasPoczatkowyInput.Text.ToString());
                signal.CzasPoczatkowy = t1;
            }
            if (this.CzasTrwaniaSygnaluInput.Enabled == true)
            {
                double d = Double.Parse(this.CzasTrwaniaSygnaluInput.Text.ToString());
                signal.CzasTrwaniaSygnalu = d;
            }
            if (this.OkresSygnaluInput.Enabled == true)
            {
                double T = Double.Parse(this.OkresSygnaluInput.Text.ToString());
                signal.OkresPodstawowy = T;

                       }
            if (this.SkokCzasowyInput.Enabled == true)
            {
                double ts = Double.Parse(this.SkokCzasowyInput.Text.ToString());
                signal.SkokCzasowy = ts;

            }
            if (this.WspolczynnikWypelnieniaInput.Enabled == true)
            {
                //  double kw = Double.Parse(this.WspolczynnikWypelnieniaInput.Text.ToString());
                double kw = Convert.ToDouble(this.WspolczynnikWypelnieniaInput.Text.ToString());

                signal.WspolczynnikWypelnienia = kw;

            }


            if (this.NumerPierwszejProbkiInput.Enabled == true)
            {
                //  double kw = Double.Parse(this.WspolczynnikWypelnieniaInput.Text.ToString());
                double n0 = Convert.ToDouble(this.NumerPierwszejProbkiInput.Text.ToString());

                signal.NrPierwszejProbki = n0;

            }
            if (this.NumerProbkiSkokuInput.Enabled == true)
            {
                //  double kw = Double.Parse(this.WspolczynnikWypelnieniaInput.Text.ToString());
                double ns = Convert.ToDouble(this.NumerProbkiSkokuInput.Text.ToString());

                signal.NrProbki = ns;

            }
            if (this.PrawdopodobienstwoAInput.Enabled == true)
            {
                //  double kw = Double.Parse(this.WspolczynnikWypelnieniaInput.Text.ToString());
                double p = Convert.ToDouble(this.PrawdopodobienstwoAInput.Text.ToString());

                signal.PrawopodobienstwoA = p;

            }


            signal.GenerateSignal();

        }
    }
        
}
