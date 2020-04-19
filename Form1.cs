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
        public CPS()
        {
            InitializeComponent();
        }

        private void SignalSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Signal signal;
            if (SignalSelect.SelectedIndex == 0)
            {
                signal = new S2();
                //  this.HistogramInput.Text = "5";

                //  this.SkokCzasowyInput.Text = signal.;
                //  this.OkresSygnaluInput.Text = "";
                this.CzasTrwaniaSygnaluInput.Text = signal.CzasTrwaniaSygnalu.ToString();
                this.CzasPoczatkowyInput.Text = signal.PoczatekSygnalu.ToString();
                this.AmplitudaInput.Text = signal.Amplituda.ToString();
                this.CzestotliwoscInput.Text = signal.CzestotliwoscProbkowania.ToString();
                this.WspolczynnikWypelnieniaInput.Text = signal.WspolczynnikWypelnienia.ToString();


                //Calculating
                this.MocSredniaOutput.Text = signal.CalculateMocSrednia().ToString();
                this.WariacjaOutput.Text = signal.CalculateWariacje().ToString();
                this.WartoscSkutecznaOutput.Text = signal.CalculateWartoscSkuteczna().ToString();
                this.WartoscSredniaBezwzglednaOutpu.Text = signal.CalculateSredniaWartoscBezwzgledna().ToString();
                this.WartoscSredniaOutput.Text = signal.CalculateWartoscSrednia().ToString();


                //Drawing Plot

                if (signal.Rodzaj.Equals(Types.Ciagly))
                {
                    this.Plot.Series.Clear();
                    this.Plot.Titles.Clear();
                    this.Plot.Titles.Add(this.SignalSelect.SelectedItem.ToString());

                    Series series = this.Plot.Series.Add(this.SignalSelect.SelectedItem.ToString());
                    series.ChartType = SeriesChartType.Line;
                    foreach (Point point in signal.PointList)
                        series.Points.AddXY(point.X, point.Y);

                }

                //Drawing Histogram
                this.Histogram.Series.Clear();
                this.Histogram.Titles.Clear();
                this.Histogram.Titles.Add(this.SignalSelect.SelectedItem.ToString());
                int size = Int32.Parse(this.HistogramSelect.SelectedItem.ToString());
                int[] values = new int[size];
                double[] value = new double[size];
                double skip = 2 * signal.Amplituda / size;
                value[0] = -signal.Amplituda;
                for (int i = 1; i < size; i++)
                {
                    value[i] = value[i - 1] + skip;
                }
                //value[size-1] = signal.Amplituda;


                Series HSeries = this.Histogram.Series.Add(this.SignalSelect.SelectedItem.ToString());
                //HSeries.ChartType = SeriesChartType.
                foreach (Point point in signal.PointList)
                {
                   for(int i =0; i < size-1; i++)
                        if(point.Y>= value[i] && point.Y <= value[i+1])
                        {
                            values[i]++;
                            continue;
                        }
                    if (point.Y > value[size - 1])
                        values[size - 1]++;
                }
                
                for(int i = 0; i < size; i++)
                {
                    HSeries.Points.AddXY(value[i], values[i]);
                  //  Histogram.Series[i].CustomProperties = "PointWidth = 1";
                }
                foreach(Series s in Histogram.Series)
                    s.CustomProperties = "PointWidth = 1";

            }
        }

        private void Plot_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
        
}
