using Cyfrowe.Logic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cyfrowe
{
    partial class Form1
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
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            this.importujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importujToolStripMenuItem.Text = "Importuj";
            // 
            // exportujToolStripMenuItem
            // 
            this.exportujToolStripMenuItem.Name = "exportujToolStripMenuItem";
            this.exportujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportujToolStripMenuItem.Text = "Exportuj";
            // 
            // Wykres
            // 
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(298, 27);
            this.Wykres.Name = "Wykres";
            this.Wykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            //series1.ChartArea = "ChartArea1";
            //series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //series1.Legend = "Legend1";
            //series1.Name = "Series1";
            this.Wykres.Series.Add(WykresSeries());
            this.Wykres.Size = new System.Drawing.Size(481, 244);
            this.Wykres.TabIndex = 1;
            this.Wykres.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(298, 321);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(481, 244);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 611);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportujToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;



        public Series WykresSeries()
        {

            Logic.Signals.S1 noisesignal = new Logic.Signals.S1();
            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.Legend = "Legend1";
            series.Name = "Series1";
          
            foreach(Point point in noisesignal.PointList)
            {
                series.Points.AddXY(point.X, point.Y);
            }

            return series;

           
            

        }
    }
}

