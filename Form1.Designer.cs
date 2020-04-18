using Cyfrowe.Logic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cyfrowe
{
    partial class CPS
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Data = new System.Windows.Forms.SplitContainer();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SkokCzasowyInput = new System.Windows.Forms.TextBox();
            this.SkokCzasowy = new System.Windows.Forms.Label();
            this.OkresSygnaluInput = new System.Windows.Forms.TextBox();
            this.OkresSygnalu = new System.Windows.Forms.Label();
            this.CzasTrwaniaSygnaluInput = new System.Windows.Forms.TextBox();
            this.CzasTrwaniaSygnału = new System.Windows.Forms.Label();
            this.CzasPoczatkowyInput = new System.Windows.Forms.TextBox();
            this.CzasPoczatkowy = new System.Windows.Forms.Label();
            this.AmplitudaInput = new System.Windows.Forms.TextBox();
            this.Amplituda = new System.Windows.Forms.Label();
            this.CzestotliwoscInput = new System.Windows.Forms.TextBox();
            this.Czestotliwosc = new System.Windows.Forms.Label();
            this.SignalSelect = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramInput = new System.Windows.Forms.Label();
            this.HistogramSelect = new System.Windows.Forms.ComboBox();
            this.WartoscSrednia = new System.Windows.Forms.Label();
            this.WartoscSredniaBezwzgledna = new System.Windows.Forms.Label();
            this.WartoscSkuteczna = new System.Windows.Forms.Label();
            this.Wariacja = new System.Windows.Forms.Label();
            this.MocSrednia = new System.Windows.Forms.Label();
            this.WartoscSredniaOutput = new System.Windows.Forms.Label();
            this.WartoscSredniaBezwzglednaOutpu = new System.Windows.Forms.Label();
            this.WartoscSkutecznaOutput = new System.Windows.Forms.Label();
            this.WariacjaOutput = new System.Windows.Forms.Label();
            this.MocSredniaOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.Data.Panel1.SuspendLayout();
            this.Data.Panel2.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importujToolStripMenuItem,
            this.exportujToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // importujToolStripMenuItem
            // 
            this.importujToolStripMenuItem.Name = "importujToolStripMenuItem";
            this.importujToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importujToolStripMenuItem.Text = "Importuj";
            // 
            // exportujToolStripMenuItem
            // 
            this.exportujToolStripMenuItem.Name = "exportujToolStripMenuItem";
            this.exportujToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exportujToolStripMenuItem.Text = "Exportuj";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Data);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(797, 587);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 0);
            this.Data.Name = "Data";
            this.Data.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Data.Panel1
            // 
            this.Data.Panel1.Controls.Add(this.HistogramSelect);
            this.Data.Panel1.Controls.Add(this.HistogramInput);
            this.Data.Panel1.Controls.Add(this.CreateButton);
            this.Data.Panel1.Controls.Add(this.SkokCzasowyInput);
            this.Data.Panel1.Controls.Add(this.SkokCzasowy);
            this.Data.Panel1.Controls.Add(this.OkresSygnaluInput);
            this.Data.Panel1.Controls.Add(this.OkresSygnalu);
            this.Data.Panel1.Controls.Add(this.CzasTrwaniaSygnaluInput);
            this.Data.Panel1.Controls.Add(this.CzasTrwaniaSygnału);
            this.Data.Panel1.Controls.Add(this.CzasPoczatkowyInput);
            this.Data.Panel1.Controls.Add(this.CzasPoczatkowy);
            this.Data.Panel1.Controls.Add(this.AmplitudaInput);
            this.Data.Panel1.Controls.Add(this.Amplituda);
            this.Data.Panel1.Controls.Add(this.CzestotliwoscInput);
            this.Data.Panel1.Controls.Add(this.Czestotliwosc);
            this.Data.Panel1.Controls.Add(this.SignalSelect);
            // 
            // Data.Panel2
            // 
            this.Data.Panel2.Controls.Add(this.MocSredniaOutput);
            this.Data.Panel2.Controls.Add(this.WariacjaOutput);
            this.Data.Panel2.Controls.Add(this.WartoscSkutecznaOutput);
            this.Data.Panel2.Controls.Add(this.WartoscSredniaBezwzglednaOutpu);
            this.Data.Panel2.Controls.Add(this.WartoscSredniaOutput);
            this.Data.Panel2.Controls.Add(this.MocSrednia);
            this.Data.Panel2.Controls.Add(this.Wariacja);
            this.Data.Panel2.Controls.Add(this.WartoscSkuteczna);
            this.Data.Panel2.Controls.Add(this.WartoscSredniaBezwzgledna);
            this.Data.Panel2.Controls.Add(this.WartoscSrednia);
            this.Data.Size = new System.Drawing.Size(265, 587);
            this.Data.SplitterDistance = 277;
            this.Data.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(98, 235);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Stworz";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // SkokCzasowyInput
            // 
            this.SkokCzasowyInput.Location = new System.Drawing.Point(79, 139);
            this.SkokCzasowyInput.Name = "SkokCzasowyInput";
            this.SkokCzasowyInput.Size = new System.Drawing.Size(187, 20);
            this.SkokCzasowyInput.TabIndex = 12;
            // 
            // SkokCzasowy
            // 
            this.SkokCzasowy.AutoSize = true;
            this.SkokCzasowy.Location = new System.Drawing.Point(2, 142);
            this.SkokCzasowy.Name = "SkokCzasowy";
            this.SkokCzasowy.Size = new System.Drawing.Size(76, 13);
            this.SkokCzasowy.TabIndex = 11;
            this.SkokCzasowy.Text = "Skok czasowy";
            // 
            // OkresSygnaluInput
            // 
            this.OkresSygnaluInput.Location = new System.Drawing.Point(79, 115);
            this.OkresSygnaluInput.Name = "OkresSygnaluInput";
            this.OkresSygnaluInput.Size = new System.Drawing.Size(187, 20);
            this.OkresSygnaluInput.TabIndex = 10;
            // 
            // OkresSygnalu
            // 
            this.OkresSygnalu.AutoSize = true;
            this.OkresSygnalu.Location = new System.Drawing.Point(2, 118);
            this.OkresSygnalu.Name = "OkresSygnalu";
            this.OkresSygnalu.Size = new System.Drawing.Size(76, 13);
            this.OkresSygnalu.TabIndex = 9;
            this.OkresSygnalu.Text = "Okres sygnału";
            // 
            // CzasTrwaniaSygnaluInput
            // 
            this.CzasTrwaniaSygnaluInput.Location = new System.Drawing.Point(116, 91);
            this.CzasTrwaniaSygnaluInput.Name = "CzasTrwaniaSygnaluInput";
            this.CzasTrwaniaSygnaluInput.Size = new System.Drawing.Size(150, 20);
            this.CzasTrwaniaSygnaluInput.TabIndex = 8;
            // 
            // CzasTrwaniaSygnału
            // 
            this.CzasTrwaniaSygnału.AutoSize = true;
            this.CzasTrwaniaSygnału.Location = new System.Drawing.Point(2, 94);
            this.CzasTrwaniaSygnału.Name = "CzasTrwaniaSygnału";
            this.CzasTrwaniaSygnału.Size = new System.Drawing.Size(108, 13);
            this.CzasTrwaniaSygnału.TabIndex = 7;
            this.CzasTrwaniaSygnału.Text = "Czas trwania sygnału";
            // 
            // CzasPoczatkowyInput
            // 
            this.CzasPoczatkowyInput.Location = new System.Drawing.Point(89, 69);
            this.CzasPoczatkowyInput.Name = "CzasPoczatkowyInput";
            this.CzasPoczatkowyInput.Size = new System.Drawing.Size(177, 20);
            this.CzasPoczatkowyInput.TabIndex = 6;
            // 
            // CzasPoczatkowy
            // 
            this.CzasPoczatkowy.AutoSize = true;
            this.CzasPoczatkowy.Location = new System.Drawing.Point(2, 72);
            this.CzasPoczatkowy.Name = "CzasPoczatkowy";
            this.CzasPoczatkowy.Size = new System.Drawing.Size(90, 13);
            this.CzasPoczatkowy.TabIndex = 5;
            this.CzasPoczatkowy.Text = "Czas początkowy";
            // 
            // AmplitudaInput
            // 
            this.AmplitudaInput.Location = new System.Drawing.Point(79, 46);
            this.AmplitudaInput.Name = "AmplitudaInput";
            this.AmplitudaInput.Size = new System.Drawing.Size(187, 20);
            this.AmplitudaInput.TabIndex = 4;
            // 
            // Amplituda
            // 
            this.Amplituda.AutoSize = true;
            this.Amplituda.Location = new System.Drawing.Point(2, 49);
            this.Amplituda.Name = "Amplituda";
            this.Amplituda.Size = new System.Drawing.Size(53, 13);
            this.Amplituda.TabIndex = 3;
            this.Amplituda.Text = "Amplituda";
            // 
            // CzestotliwoscInput
            // 
            this.CzestotliwoscInput.Location = new System.Drawing.Point(79, 24);
            this.CzestotliwoscInput.Name = "CzestotliwoscInput";
            this.CzestotliwoscInput.Size = new System.Drawing.Size(187, 20);
            this.CzestotliwoscInput.TabIndex = 2;
            // 
            // Czestotliwosc
            // 
            this.Czestotliwosc.AutoSize = true;
            this.Czestotliwosc.Location = new System.Drawing.Point(2, 27);
            this.Czestotliwosc.Name = "Czestotliwosc";
            this.Czestotliwosc.Size = new System.Drawing.Size(71, 13);
            this.Czestotliwosc.TabIndex = 1;
            this.Czestotliwosc.Text = "Częstotliwość";
            // 
            // SignalSelect
            // 
            this.SignalSelect.FormattingEnabled = true;
            this.SignalSelect.Location = new System.Drawing.Point(5, 3);
            this.SignalSelect.Name = "SignalSelect";
            this.SignalSelect.Size = new System.Drawing.Size(259, 21);
            this.SignalSelect.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.Plot);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Histogram);
            this.splitContainer2.Size = new System.Drawing.Size(528, 587);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.TabIndex = 0;
            // 
            // Plot
            // 
            chartArea1.Name = "ChartArea1";
            this.Plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Plot.Legends.Add(legend1);
            this.Plot.Location = new System.Drawing.Point(3, 3);
            this.Plot.Name = "Plot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Plot.Series.Add(series1);
            this.Plot.Size = new System.Drawing.Size(522, 274);
            this.Plot.TabIndex = 0;
            this.Plot.Text = "chart1";
            // 
            // Histogram
            // 
            chartArea2.Name = "ChartArea1";
            this.Histogram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Histogram.Legends.Add(legend2);
            this.Histogram.Location = new System.Drawing.Point(2, 1);
            this.Histogram.Name = "Histogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Histogram.Series.Add(series2);
            this.Histogram.Size = new System.Drawing.Size(526, 304);
            this.Histogram.TabIndex = 0;
            this.Histogram.Text = "chart2";
            // 
            // HistogramInput
            // 
            this.HistogramInput.AutoSize = true;
            this.HistogramInput.Location = new System.Drawing.Point(2, 211);
            this.HistogramInput.Name = "HistogramInput";
            this.HistogramInput.Size = new System.Drawing.Size(143, 13);
            this.HistogramInput.TabIndex = 14;
            this.HistogramInput.Text = "Ilość przedziałów histogramu";
            // 
            // HistogramSelect
            // 
            this.HistogramSelect.FormattingEnabled = true;
            this.HistogramSelect.Location = new System.Drawing.Point(145, 208);
            this.HistogramSelect.Name = "HistogramSelect";
            this.HistogramSelect.Size = new System.Drawing.Size(51, 21);
            this.HistogramSelect.TabIndex = 15;
            // 
            // WartoscSrednia
            // 
            this.WartoscSrednia.AutoSize = true;
            this.WartoscSrednia.Location = new System.Drawing.Point(8, 21);
            this.WartoscSrednia.Name = "WartoscSrednia";
            this.WartoscSrednia.Size = new System.Drawing.Size(84, 13);
            this.WartoscSrednia.TabIndex = 0;
            this.WartoscSrednia.Text = "Wartość średnia";
            // 
            // WartoscSredniaBezwzgledna
            // 
            this.WartoscSredniaBezwzgledna.AutoSize = true;
            this.WartoscSredniaBezwzgledna.Location = new System.Drawing.Point(8, 44);
            this.WartoscSredniaBezwzgledna.Name = "WartoscSredniaBezwzgledna";
            this.WartoscSredniaBezwzgledna.Size = new System.Drawing.Size(149, 13);
            this.WartoscSredniaBezwzgledna.TabIndex = 1;
            this.WartoscSredniaBezwzgledna.Text = "Wartość średnia bezwzględna";
            // 
            // WartoscSkuteczna
            // 
            this.WartoscSkuteczna.AutoSize = true;
            this.WartoscSkuteczna.Location = new System.Drawing.Point(8, 68);
            this.WartoscSkuteczna.Name = "WartoscSkuteczna";
            this.WartoscSkuteczna.Size = new System.Drawing.Size(99, 13);
            this.WartoscSkuteczna.TabIndex = 2;
            this.WartoscSkuteczna.Text = "Wartość skuteczna";
            // 
            // Wariacja
            // 
            this.Wariacja.AutoSize = true;
            this.Wariacja.Location = new System.Drawing.Point(8, 92);
            this.Wariacja.Name = "Wariacja";
            this.Wariacja.Size = new System.Drawing.Size(49, 13);
            this.Wariacja.TabIndex = 3;
            this.Wariacja.Text = "Wariacja";
            // 
            // MocSrednia
            // 
            this.MocSrednia.AutoSize = true;
            this.MocSrednia.Location = new System.Drawing.Point(8, 115);
            this.MocSrednia.Name = "MocSrednia";
            this.MocSrednia.Size = new System.Drawing.Size(65, 13);
            this.MocSrednia.TabIndex = 4;
            this.MocSrednia.Text = "Moc średnia";
            this.MocSrednia.Click += new System.EventHandler(this.label5_Click);
            // 
            // WartoscSredniaOutput
            // 
            this.WartoscSredniaOutput.AutoSize = true;
            this.WartoscSredniaOutput.Location = new System.Drawing.Point(98, 21);
            this.WartoscSredniaOutput.Name = "WartoscSredniaOutput";
            this.WartoscSredniaOutput.Size = new System.Drawing.Size(35, 13);
            this.WartoscSredniaOutput.TabIndex = 5;
            this.WartoscSredniaOutput.Text = "label1";
            // 
            // WartoscSredniaBezwzglednaOutpu
            // 
            this.WartoscSredniaBezwzglednaOutpu.AutoSize = true;
            this.WartoscSredniaBezwzglednaOutpu.Location = new System.Drawing.Point(163, 44);
            this.WartoscSredniaBezwzglednaOutpu.Name = "WartoscSredniaBezwzglednaOutpu";
            this.WartoscSredniaBezwzglednaOutpu.Size = new System.Drawing.Size(35, 13);
            this.WartoscSredniaBezwzglednaOutpu.TabIndex = 6;
            this.WartoscSredniaBezwzglednaOutpu.Text = "label2";
            // 
            // WartoscSkutecznaOutput
            // 
            this.WartoscSkutecznaOutput.AutoSize = true;
            this.WartoscSkutecznaOutput.Location = new System.Drawing.Point(113, 68);
            this.WartoscSkutecznaOutput.Name = "WartoscSkutecznaOutput";
            this.WartoscSkutecznaOutput.Size = new System.Drawing.Size(35, 13);
            this.WartoscSkutecznaOutput.TabIndex = 7;
            this.WartoscSkutecznaOutput.Text = "label3";
            // 
            // WariacjaOutput
            // 
            this.WariacjaOutput.AutoSize = true;
            this.WariacjaOutput.Location = new System.Drawing.Point(63, 92);
            this.WariacjaOutput.Name = "WariacjaOutput";
            this.WariacjaOutput.Size = new System.Drawing.Size(35, 13);
            this.WariacjaOutput.TabIndex = 8;
            this.WariacjaOutput.Text = "label4";
            // 
            // MocSredniaOutput
            // 
            this.MocSredniaOutput.AutoSize = true;
            this.MocSredniaOutput.Location = new System.Drawing.Point(79, 115);
            this.MocSredniaOutput.Name = "MocSredniaOutput";
            this.MocSredniaOutput.Size = new System.Drawing.Size(35, 13);
            this.MocSredniaOutput.TabIndex = 9;
            this.MocSredniaOutput.Text = "label5";
            // 
            // CPS
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CPS";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Data.Panel1.ResumeLayout(false);
            this.Data.Panel1.PerformLayout();
            this.Data.Panel2.ResumeLayout(false);
            this.Data.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.Data.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportujToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer Data;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox SkokCzasowyInput;
        private System.Windows.Forms.Label SkokCzasowy;
        private System.Windows.Forms.TextBox OkresSygnaluInput;
        private System.Windows.Forms.Label OkresSygnalu;
        private System.Windows.Forms.TextBox CzasTrwaniaSygnaluInput;
        private System.Windows.Forms.Label CzasTrwaniaSygnału;
        private System.Windows.Forms.TextBox CzasPoczatkowyInput;
        private System.Windows.Forms.Label CzasPoczatkowy;
        private System.Windows.Forms.TextBox AmplitudaInput;
        private System.Windows.Forms.Label Amplituda;
        private System.Windows.Forms.TextBox CzestotliwoscInput;
        private System.Windows.Forms.Label Czestotliwosc;
        private System.Windows.Forms.ComboBox SignalSelect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Chart Plot;
        private Chart Histogram;
        private System.Windows.Forms.ComboBox HistogramSelect;
        private System.Windows.Forms.Label HistogramInput;
        private System.Windows.Forms.Label MocSrednia;
        private System.Windows.Forms.Label Wariacja;
        private System.Windows.Forms.Label WartoscSkuteczna;
        private System.Windows.Forms.Label WartoscSredniaBezwzgledna;
        private System.Windows.Forms.Label WartoscSrednia;
        private System.Windows.Forms.Label MocSredniaOutput;
        private System.Windows.Forms.Label WariacjaOutput;
        private System.Windows.Forms.Label WartoscSkutecznaOutput;
        private System.Windows.Forms.Label WartoscSredniaBezwzglednaOutpu;
        private System.Windows.Forms.Label WartoscSredniaOutput;
    }
}

