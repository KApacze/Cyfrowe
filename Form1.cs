using Cyfrowe.Logic;
using Cyfrowe.Logic.Operations;
using Cyfrowe.Logic.Signals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
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
        private Signal SecondarySignal;
        private Signal SampledSignal;
        private Signal ReconstructedSignal;
        private Signal FilteredSignal;
        private Signal TransformedSignal;

        public CPS()
        {
            InitializeComponent();
            this.HistogramSelect.SelectedIndex = 0;
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

            if (SignalSelect.SelectedIndex >= 0 && SignalSelect.SelectedIndex <= 11)
            {

                //Display current setting
                displayCurrentSettings(signal);


                //Calculating
                calculateAll(signal);

                drawPlot(signal);
                drawHistogram(signal);
            }


        }


        private void drawPlot(Signal signal)
        {
            //Drawing Plot

            this.Plot.Series.Clear();
            this.Plot.Titles.Clear();
            this.Plot.Titles.Add(signal.Nazwa);

            Series series = this.Plot.Series.Add(signal.Nazwa);
            if (signal.Rodzaj.Equals(Types.Ciagly))
                series.ChartType = SeriesChartType.Line;
            else series.ChartType = SeriesChartType.Point;

            foreach (Point point in signal.PointList)
                series.Points.AddXY(point.X, point.Y);
            Plot.ChartAreas[0].RecalculateAxesScale();

        }

            private void drawHistogram(Signal signal)
            {
                //Drawing Histogram
                this.Histogram.Series.Clear();
                this.Histogram.Titles.Clear();
                this.Histogram.Titles.Add(signal.Nazwa + " - histogram");
                 int size;
                 if (string.IsNullOrEmpty(this.HistogramSelect.SelectedItem.ToString())) { 
                size = 5;
                 } else 
                size = Int32.Parse(this.HistogramSelect.SelectedItem.ToString());



                if (size == 0) size = 5;
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

                Series HSeries = this.Histogram.Series.Add(signal.Nazwa);
                foreach (Point point in signal.PointList)
                {
                    for (int i = 0; i < size - 1; i++)
                        if (point.Y >= value[i] && point.Y < value[i + 1])
                        {
                            values[i]++;
                            continue;
                        }
                    if (point.Y > value[size - 1])
                        values[size - 1]++;
                }

                for (int i = 0; i < size; i++)
                {
                    HSeries.Points.AddXY(Math.Round(value[i], 2), values[i]);
                }
                //this.Histogram.ChartAreas[0].AxisY.Maximum = values.Max(r => r);
               // this.Histogram.ChartAreas[0].AxisX.Maximum = value.Max(r => r) + size;
                //this.Histogram.ChartAreas[0].AxisX.Minimum = value.Min(r => r);


                foreach (Series s in Histogram.Series)
                    s.CustomProperties = "PointWidth = 1";
            Histogram.ChartAreas[0].RecalculateAxesScale();
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

        private void exportujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export(CurrentSignal);
        }
        private void exportujPróbkowanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export(SampledSignal);
        }

        private void export(Signal signal)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an signal";
            saveFileDialog1.ShowDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    String path = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(path);
                    saveSignal(sw, signal);
                    sw.Close();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Can't Save file");
                }
            }
        }
        private void importujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = import();          
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            Signal signal = new Imported(sr);
            sr.Close();
            drawPlot(signal);
            drawHistogram(signal);
            displayCurrentSettings(signal);
            CurrentSignal = signal;
        }


        private OpenFileDialog import()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            return openFileDialog1;

        }
        private void saveSignal(StreamWriter sw, Signal signal)
        {
            sw.WriteLine(signal.Rodzaj);

            //bools
            sw.WriteLine(signal.CzyAmplituda);
            sw.WriteLine(signal.CzyCzestotliwosc);
            sw.WriteLine(signal.CzyczasPoczatkowy);
            sw.WriteLine(signal.CzyCzasTrwaniaSygnalu);
            sw.WriteLine(signal.CzyOkresSygnalu);
            sw.WriteLine(signal.CzySkokCzasowy);
            sw.WriteLine(signal.CzyWspolczynnikWypelnienia);
            sw.WriteLine(signal.CzyNrPierwszejProbki);
            sw.WriteLine(signal.CzyNrProbki);
            sw.WriteLine(signal.CzyPrawdopodobienstwoA);

            //variables
            sw.WriteLine(signal.Nazwa);
            sw.WriteLine(signal.Amplituda);
            sw.WriteLine(signal.CzasPoczatkowy);
            sw.WriteLine(signal.CzasTrwaniaSygnalu);
            sw.WriteLine(signal.OkresPodstawowy);
            sw.WriteLine(signal.WspolczynnikWypelnienia);
            sw.WriteLine(signal.PoczatekSygnalu);
            sw.WriteLine(signal.CzestotliwoscProbkowania);
            sw.WriteLine(signal.SkokCzasowy);
            sw.WriteLine(signal.NrPierwszejProbki);
            sw.WriteLine(signal.NrProbki);
            sw.WriteLine(signal.PrawopodobienstwoA);

            //Number of points
            sw.WriteLine(signal.PointList.Count);
            //points
            foreach(Point p in signal.PointList)
            {
                sw.WriteLine(p.X+" "+ p.Y);
            }


        }


        private void displayCurrentSettings(Signal signal)
        {
            this.CzasTrwaniaSygnaluInput.Text = signal.CzasTrwaniaSygnalu.ToString();
            this.CzasPoczatkowyInput.Text = signal.PoczatekSygnalu.ToString();
            this.AmplitudaInput.Text = signal.Amplituda.ToString();
            this.CzestotliwoscInput.Text = signal.CzestotliwoscProbkowania.ToString();
            this.WspolczynnikWypelnieniaInput.Text = signal.WspolczynnikWypelnienia.ToString();
            this.OkresSygnaluInput.Text = signal.OkresPodstawowy.ToString();
            this.SkokCzasowyInput.Text = signal.SkokCzasowy.ToString();
            this.NumerPierwszejProbkiInput.Text = signal.NrPierwszejProbki.ToString();
            this.NumerProbkiSkokuInput.Text = signal.NrProbki.ToString();
            this.PrawdopodobienstwoAInput.Text = signal.PrawopodobienstwoA.ToString();

        }

        private void calculateAll(Signal signal)
        {
            this.MocSredniaOutput.Text = signal.CalculateMocSrednia().ToString();
            this.WariacjaOutput.Text = signal.CalculateWariacje().ToString();
            this.WartoscSkutecznaOutput.Text = signal.CalculateWartoscSkuteczna().ToString();
            this.WartoscSredniaBezwzglednaOutpu.Text = signal.CalculateSredniaWartoscBezwzgledna().ToString();
            this.WartoscSredniaOutput.Text = signal.CalculateWartoscSrednia().ToString();
        }

        private void WgrajButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = import();
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            Signal signal = new Imported(sr);
            sr.Close();           
            SecondarySignal = signal;
        }

        private void OperacjeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        #region operations
        private void ObliczButton_Click(object sender, EventArgs e)
        {
            if(CurrentSignal != null && SecondarySignal != null)
            {
                Signal signal;
                if(OperacjeSelect.SelectedIndex == 0)
                {
                    signal = Logic.Operations.Add.Dodaj(CurrentSignal,
                                                  SecondarySignal);
                }
                else if (OperacjeSelect.SelectedIndex == 1)
                {
                    signal = Logic.Operations.Substract.Odejmij(CurrentSignal,
                                                  SecondarySignal);
                }
                else if (OperacjeSelect.SelectedIndex == 2)
                {
                    signal = Logic.Operations.Multiply.Mnoz(CurrentSignal,
                                                  SecondarySignal);
                }
                else if(OperacjeSelect.SelectedIndex == 3)
                {
                    signal = Logic.Operations.Divide.Dziel(CurrentSignal,
                                                  SecondarySignal);
                } 
                else if (OperacjeSelect.SelectedIndex == 4)
                {
                    
                     signal = Logic.Operations.Weave.Splot(SampledSignal, SecondarySignal);
                }
                else if (OperacjeSelect.SelectedIndex == 5)
                {

                    signal = Correlation.Korelacja(SampledSignal, SecondarySignal);
                } else
                {
                    signal = Correlation.KorelacjaZUzyciemSplotu(SampledSignal, SecondarySignal);
                }

                drawPlot(signal);
                drawHistogram(signal);

                CurrentSignal = signal;

            }
        }


        private void SamplingButton_Click(object sender, EventArgs e)
        {
      
            Signal signal= Logic.Conversions.S1.ProbkowanieRownomierne(CurrentSignal, Double.Parse(this.SamplingFreqInput.Text));
            AddACToPlot(signal);
 
        }
           
        private void AddACToPlot(Signal signal)
        {
            if (Plot.Series.Count > 1) Plot.Series.RemoveAt(1);
            if (Plot.Series.Count > 1) Plot.Series.RemoveAt(1);
            Series series = this.Plot.Series.Add("A/C");
            series.ChartType = SeriesChartType.Point;
            foreach (Point point in signal.PointList)
                series.Points.AddXY(point.X, point.Y);

            SampledSignal = signal;


        }


        private void AC2Button_Click(object sender, EventArgs e)
        {
            double f = Double.Parse(this.CzestotliwoscProbkowania2Input.Text);
            Signal signal = Logic.Conversions.Q2.KwantyzacjaRownomierna(CurrentSignal, f);
            AddACToPlot(signal);
            //Plot.Series[1].ChartType = SeriesChartType.Line;
        }


        private void R1Button_Click(object sender, EventArgs e)
        {
            double f = Double.Parse(this.CzestotliowscR1Input.Text);
            Signal signal = Logic.Conversions.R1.ExtrapolaciaZerowegoRzedu(SampledSignal, f);
            AddCAToPlot(signal);
            CalcDifference(CurrentSignal, signal,f);


        }
        private void AddCAToPlot(Signal signal)
        {
            if (Plot.Series.Count > 1) Plot.Series.RemoveAt(1);
            Series series = this.Plot.Series.Add("C/A");
            series.ChartType = SeriesChartType.Line;
            foreach (Point point in signal.PointList)
                series.Points.AddXY(point.X, point.Y);
            Plot.Series[1].Color = Color.Red;

            ReconstructedSignal = signal;

        }

        private void R2Button_Click(object sender, EventArgs e)
        {
            double f = Double.Parse(this.CzestotliwoscR2Input.Text);
            Signal signal = Logic.Conversions.R2.InterpolacjaPierwszegoRzedu(SampledSignal, f);
            //TODO
            AddCAToPlot(SampledSignal);
            CalcDifference(CurrentSignal, signal, f);

        }

        private void R3Button_Click(object sender, EventArgs e)
        {
            double f = Double.Parse(this.CzestotliwoscR3Input.Text);
            Signal signal = Logic.Conversions.R3.RekonstrukcjaWOparciuOSinc(SampledSignal, f);
            AddCAToPlot(signal);
            CalcDifference(CurrentSignal, signal, f);
        }


        private void CalcDifference(Signal originalSignal, Signal newSignal, double frequency) {
            this.MSEOutput.Text = Logic.Conversions.Measures.CalculateMSE(originalSignal,newSignal,frequency).ToString() ;
            this.SNROutput.Text = Logic.Conversions.Measures.CalculateSNR(originalSignal, newSignal, frequency).ToString();
            this.MROutput.Text = Logic.Conversions.Measures.CalculateMD(originalSignal, newSignal, frequency).ToString();
        }
        #endregion


        #region filtrowanie
        private void FiltrButton_Click(object sender, EventArgs e)
        {
            Signal signal = (Signal)CurrentSignal.CreateShallowCopy();
            int M =  Int16.Parse(this.RzadOdcieciaInput.Text);
            double fo = Double.Parse(this.F0Input.Text);
            double fp = Double.Parse(this.CzestotliwoscProbkowaniaInput.Text);
            double K;
            List<double> filterValues = new List<double>();
            if (this.FiltrSelector.SelectedIndex == 0)
            {
                filterValues = Filters.LowFilter(M, fo, fp);
            } else if(this.FiltrSelector.SelectedIndex == 1)
            {
                K = fp / (fp / 4 - fo);
                filterValues = Filters.LowFilter(M, fo, fp, K);
                filterValues = Filters.MediumFilter(filterValues);
            } else if(this.FiltrSelector.SelectedIndex == 2)
            {
                filterValues = Filters.LowFilter(M, fo, fp, fp / (fp / 2 - fo));

                filterValues = Filters.HighFilter(filterValues);
            }

            if(this.OknoSelector.SelectedIndex == 0)
            {
                filterValues = Filters.RectangularWindow(filterValues);
            } else if(this.OknoSelector.SelectedIndex == 1)
            {
                filterValues = Filters.HammingWindow(filterValues);
            } else if (this.OknoSelector.SelectedIndex == 2)
            {
                filterValues = Filters.HanningWindow(filterValues);
            } else if(this.OknoSelector.SelectedIndex == 3)
            {
                filterValues = Filters.BlackmanWindow(filterValues);
            }


            signal = Weave.Splot(CurrentSignal, filterValues);
            drawPlot(signal);
            FilteredSignal = signal;
            Plot.Titles[0].Text = "Filtrowanie";
            Plot.Series[0].ChartType = SeriesChartType.Point;


        }
        #endregion



        private void TransformationButton_Click(object sender, EventArgs e)
        {
            Signal signal = (Signal)CurrentSignal.CreateShallowCopy();
            while((CurrentSignal.PointList.Count & (CurrentSignal.PointList.Count - 1)) != 0)
            {
                signal.PointList.RemoveAt(signal.PointList.Count - 1);
            }
            TransformedSignal = Logic.Transformation.CWT.ContinuousWaveletTransformation(signal);
            DrawW1(TransformedSignal);
        }


        public void DrawW1(Signal signal)
        {
            this.W1Plot1.Series.Clear();
            this.W1Plot2.Series.Clear();
            this.W1Plot1.Titles.Clear();
            this.W1Plot2.Titles.Clear();

            this.W1Plot1.Titles.Add("Część rzeczywista sygnału");
            this.W1Plot2.Titles.Add("Część urojona sygnału");

            Series series1 = this.W1Plot1.Series.Add(signal.Nazwa);
            series1.ChartType = SeriesChartType.Point;
            Series series2 = this.W1Plot2.Series.Add(signal.Nazwa);
            series2.ChartType = SeriesChartType.Point;

            for(int i =0; i != signal.ComplexPointList.Count; i++)
            {
                series1.Points.AddXY(signal.PointList[i].X, signal.ComplexPointList[i].Real);
                series2.Points.AddXY(signal.PointList[i].X, signal.ComplexPointList[i].Imaginary);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signal signal = (Signal)TransformedSignal.CreateShallowCopy();
            while ((signal.PointList.Count & (signal.PointList.Count - 1)) != 0)
            {
                signal.PointList.RemoveAt(signal.PointList.Count - 1);
            }
            signal = Logic.Transformation.CWT.ContinuousWaveletTransformation(signal);
            drawPlot(signal);
            Plot.Series[0].ChartType = SeriesChartType.Point;
            }
    }
        
}
