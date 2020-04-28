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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Data = new System.Windows.Forms.SplitContainer();
            this.ObliczButton = new System.Windows.Forms.Button();
            this.OperacjeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WgrajButton = new System.Windows.Forms.Button();
            this.DodatkowySygnal = new System.Windows.Forms.Label();
            this.PrawdopodobienstwoAInput = new System.Windows.Forms.TextBox();
            this.PrawdopodobieństwoA = new System.Windows.Forms.Label();
            this.NumerProbkiSkokuInput = new System.Windows.Forms.TextBox();
            this.NumerProbkiSkoku = new System.Windows.Forms.Label();
            this.NumerPierwszejProbkiInput = new System.Windows.Forms.TextBox();
            this.NumerPierwszejProbki = new System.Windows.Forms.Label();
            this.WspolczynnikWypelnieniaInput = new System.Windows.Forms.TextBox();
            this.WspolczynnikWypelnienia = new System.Windows.Forms.Label();
            this.HistogramSelect = new System.Windows.Forms.ComboBox();
            this.HistogramInput = new System.Windows.Forms.Label();
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
            this.Czestotliwosc = new System.Windows.Forms.Label();
            this.SignalSelect = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CzestotliwoscInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TabController = new System.Windows.Forms.TabControl();
            this.ObliczeniaTab = new System.Windows.Forms.TabPage();
            this.MocSredniaOutput = new System.Windows.Forms.Label();
            this.WartoscSrednia = new System.Windows.Forms.Label();
            this.WartoscSredniaOutput = new System.Windows.Forms.Label();
            this.MocSrednia = new System.Windows.Forms.Label();
            this.WariacjaOutput = new System.Windows.Forms.Label();
            this.Wariacja = new System.Windows.Forms.Label();
            this.WartoscSkuteczna = new System.Windows.Forms.Label();
            this.WartoscSkutecznaOutput = new System.Windows.Forms.Label();
            this.WartoscSredniaBezwzglednaOutpu = new System.Windows.Forms.Label();
            this.WartoscSredniaBezwzgledna = new System.Windows.Forms.Label();
            this.ACTab = new System.Windows.Forms.TabPage();
            this.AC2Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CzestotliwoscProbkowania2Input = new System.Windows.Forms.TextBox();
            this.SamplingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SamplingFreq = new System.Windows.Forms.Label();
            this.SamplingFreqInput = new System.Windows.Forms.TextBox();
            this.CATab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.Data.Panel1.SuspendLayout();
            this.Data.Panel2.SuspendLayout();
            this.Data.SuspendLayout();
            this.TabController.SuspendLayout();
            this.ObliczeniaTab.SuspendLayout();
            this.ACTab.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
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
            this.importujToolStripMenuItem.Click += new System.EventHandler(this.importujToolStripMenuItem_Click);
            // 
            // exportujToolStripMenuItem
            // 
            this.exportujToolStripMenuItem.Name = "exportujToolStripMenuItem";
            this.exportujToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exportujToolStripMenuItem.Text = "Exportuj";
            this.exportujToolStripMenuItem.Click += new System.EventHandler(this.exportujToolStripMenuItem_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(893, 698);
            this.splitContainer1.SplitterDistance = 272;
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
            this.Data.Panel1.Controls.Add(this.ObliczButton);
            this.Data.Panel1.Controls.Add(this.OperacjeSelect);
            this.Data.Panel1.Controls.Add(this.label1);
            this.Data.Panel1.Controls.Add(this.WgrajButton);
            this.Data.Panel1.Controls.Add(this.DodatkowySygnal);
            this.Data.Panel1.Controls.Add(this.PrawdopodobienstwoAInput);
            this.Data.Panel1.Controls.Add(this.PrawdopodobieństwoA);
            this.Data.Panel1.Controls.Add(this.NumerProbkiSkokuInput);
            this.Data.Panel1.Controls.Add(this.NumerProbkiSkoku);
            this.Data.Panel1.Controls.Add(this.NumerPierwszejProbkiInput);
            this.Data.Panel1.Controls.Add(this.NumerPierwszejProbki);
            this.Data.Panel1.Controls.Add(this.WspolczynnikWypelnieniaInput);
            this.Data.Panel1.Controls.Add(this.WspolczynnikWypelnienia);
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
            this.Data.Panel1.Controls.Add(this.Czestotliwosc);
            this.Data.Panel1.Controls.Add(this.SignalSelect);
            this.Data.Panel1.Controls.Add(this.textBox3);
            this.Data.Panel1.Controls.Add(this.textBox4);
            this.Data.Panel1.Controls.Add(this.label4);
            this.Data.Panel1.Controls.Add(this.textBox5);
            this.Data.Panel1.Controls.Add(this.label5);
            this.Data.Panel1.Controls.Add(this.textBox6);
            this.Data.Panel1.Controls.Add(this.label7);
            this.Data.Panel1.Controls.Add(this.textBox7);
            this.Data.Panel1.Controls.Add(this.label8);
            this.Data.Panel1.Controls.Add(this.textBox8);
            this.Data.Panel1.Controls.Add(this.label9);
            this.Data.Panel1.Controls.Add(this.textBox9);
            this.Data.Panel1.Controls.Add(this.label10);
            this.Data.Panel1.Controls.Add(this.textBox10);
            this.Data.Panel1.Controls.Add(this.label11);
            this.Data.Panel1.Controls.Add(this.CzestotliwoscInput);
            this.Data.Panel1.Controls.Add(this.label12);
            this.Data.Panel1.Controls.Add(this.comboBox2);
            // 
            // Data.Panel2
            // 
            this.Data.Panel2.Controls.Add(this.TabController);
            this.Data.Size = new System.Drawing.Size(272, 698);
            this.Data.SplitterDistance = 387;
            this.Data.TabIndex = 0;
            // 
            // ObliczButton
            // 
            this.ObliczButton.Location = new System.Drawing.Point(137, 340);
            this.ObliczButton.Name = "ObliczButton";
            this.ObliczButton.Size = new System.Drawing.Size(75, 23);
            this.ObliczButton.TabIndex = 28;
            this.ObliczButton.Text = "Oblicz";
            this.ObliczButton.UseVisualStyleBackColor = true;
            this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
            // 
            // OperacjeSelect
            // 
            this.OperacjeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperacjeSelect.FormattingEnabled = true;
            this.OperacjeSelect.Items.AddRange(new object[] {
            "Dodawanie",
            "Odejmowanie",
            "Mnożenie",
            "Dzielenie"});
            this.OperacjeSelect.Location = new System.Drawing.Point(5, 340);
            this.OperacjeSelect.Name = "OperacjeSelect";
            this.OperacjeSelect.Size = new System.Drawing.Size(121, 21);
            this.OperacjeSelect.TabIndex = 27;
            this.OperacjeSelect.SelectedIndexChanged += new System.EventHandler(this.OperacjeSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "nie wgrany";
            // 
            // WgrajButton
            // 
            this.WgrajButton.Location = new System.Drawing.Point(104, 311);
            this.WgrajButton.Name = "WgrajButton";
            this.WgrajButton.Size = new System.Drawing.Size(75, 23);
            this.WgrajButton.TabIndex = 25;
            this.WgrajButton.Text = "Wgraj";
            this.WgrajButton.UseVisualStyleBackColor = true;
            this.WgrajButton.Click += new System.EventHandler(this.WgrajButton_Click);
            // 
            // DodatkowySygnal
            // 
            this.DodatkowySygnal.AutoSize = true;
            this.DodatkowySygnal.Location = new System.Drawing.Point(2, 316);
            this.DodatkowySygnal.Name = "DodatkowySygnal";
            this.DodatkowySygnal.Size = new System.Drawing.Size(96, 13);
            this.DodatkowySygnal.TabIndex = 24;
            this.DodatkowySygnal.Text = "Dodatkowy sygnał";
            // 
            // PrawdopodobienstwoAInput
            // 
            this.PrawdopodobienstwoAInput.Location = new System.Drawing.Point(231, 238);
            this.PrawdopodobienstwoAInput.Name = "PrawdopodobienstwoAInput";
            this.PrawdopodobienstwoAInput.Size = new System.Drawing.Size(35, 20);
            this.PrawdopodobienstwoAInput.TabIndex = 23;
            this.PrawdopodobienstwoAInput.Text = "50";
            // 
            // PrawdopodobieństwoA
            // 
            this.PrawdopodobieństwoA.AutoSize = true;
            this.PrawdopodobieństwoA.Location = new System.Drawing.Point(-2, 240);
            this.PrawdopodobieństwoA.Name = "PrawdopodobieństwoA";
            this.PrawdopodobieństwoA.Size = new System.Drawing.Size(228, 13);
            this.PrawdopodobieństwoA.TabIndex = 22;
            this.PrawdopodobieństwoA.Text = "Prawdopodobnieństwo  wystąpienia wartości A";
            // 
            // NumerProbkiSkokuInput
            // 
            this.NumerProbkiSkokuInput.Location = new System.Drawing.Point(66, 217);
            this.NumerProbkiSkokuInput.Name = "NumerProbkiSkokuInput";
            this.NumerProbkiSkokuInput.Size = new System.Drawing.Size(199, 20);
            this.NumerProbkiSkokuInput.TabIndex = 21;
            this.NumerProbkiSkokuInput.Text = "15";
            // 
            // NumerProbkiSkoku
            // 
            this.NumerProbkiSkoku.AutoSize = true;
            this.NumerProbkiSkoku.Location = new System.Drawing.Point(-3, 219);
            this.NumerProbkiSkoku.Name = "NumerProbkiSkoku";
            this.NumerProbkiSkoku.Size = new System.Drawing.Size(65, 13);
            this.NumerProbkiSkoku.TabIndex = 20;
            this.NumerProbkiSkoku.Text = "Ilość próbek";
            // 
            // NumerPierwszejProbkiInput
            // 
            this.NumerPierwszejProbkiInput.Location = new System.Drawing.Point(116, 191);
            this.NumerPierwszejProbkiInput.Name = "NumerPierwszejProbkiInput";
            this.NumerPierwszejProbkiInput.Size = new System.Drawing.Size(150, 20);
            this.NumerPierwszejProbkiInput.TabIndex = 19;
            this.NumerPierwszejProbkiInput.Text = "0";
            // 
            // NumerPierwszejProbki
            // 
            this.NumerPierwszejProbki.AutoSize = true;
            this.NumerPierwszejProbki.Location = new System.Drawing.Point(-2, 193);
            this.NumerPierwszejProbki.Name = "NumerPierwszejProbki";
            this.NumerPierwszejProbki.Size = new System.Drawing.Size(116, 13);
            this.NumerPierwszejProbki.TabIndex = 18;
            this.NumerPierwszejProbki.Text = "Numer pierwszej próbki";
            // 
            // WspolczynnikWypelnieniaInput
            // 
            this.WspolczynnikWypelnieniaInput.Location = new System.Drawing.Point(137, 165);
            this.WspolczynnikWypelnieniaInput.Name = "WspolczynnikWypelnieniaInput";
            this.WspolczynnikWypelnieniaInput.Size = new System.Drawing.Size(129, 20);
            this.WspolczynnikWypelnieniaInput.TabIndex = 17;
            this.WspolczynnikWypelnieniaInput.Text = "0,5";
            // 
            // WspolczynnikWypelnienia
            // 
            this.WspolczynnikWypelnienia.AutoSize = true;
            this.WspolczynnikWypelnienia.Location = new System.Drawing.Point(-2, 167);
            this.WspolczynnikWypelnienia.Name = "WspolczynnikWypelnienia";
            this.WspolczynnikWypelnienia.Size = new System.Drawing.Size(135, 13);
            this.WspolczynnikWypelnienia.TabIndex = 16;
            this.WspolczynnikWypelnienia.Text = "Współczynnik wypełnienia";
            this.WspolczynnikWypelnienia.Click += new System.EventHandler(this.label1_Click);
            // 
            // HistogramSelect
            // 
            this.HistogramSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HistogramSelect.FormattingEnabled = true;
            this.HistogramSelect.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "40"});
            this.HistogramSelect.Location = new System.Drawing.Point(147, 258);
            this.HistogramSelect.Name = "HistogramSelect";
            this.HistogramSelect.Size = new System.Drawing.Size(51, 21);
            this.HistogramSelect.TabIndex = 15;
            // 
            // HistogramInput
            // 
            this.HistogramInput.AutoSize = true;
            this.HistogramInput.Location = new System.Drawing.Point(-2, 261);
            this.HistogramInput.Name = "HistogramInput";
            this.HistogramInput.Size = new System.Drawing.Size(143, 13);
            this.HistogramInput.TabIndex = 14;
            this.HistogramInput.Text = "Ilość przedziałów histogramu";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(89, 285);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Stworz";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SkokCzasowyInput
            // 
            this.SkokCzasowyInput.Location = new System.Drawing.Point(79, 139);
            this.SkokCzasowyInput.Name = "SkokCzasowyInput";
            this.SkokCzasowyInput.Size = new System.Drawing.Size(187, 20);
            this.SkokCzasowyInput.TabIndex = 12;
            this.SkokCzasowyInput.Text = "1";
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
            this.OkresSygnaluInput.Text = "2";
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
            this.CzasTrwaniaSygnaluInput.Text = "10";
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
            this.CzasPoczatkowyInput.Text = "0";
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
            this.AmplitudaInput.Text = "10";
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
            this.SignalSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.SignalSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "Szum o rozkładzie jednostajnym",
            "Szum gaussowski",
            "Sygnał sinusoidalny",
            "Sygnał sinosoidalny wyprostowany jednopołówkowo",
            "Sygnał sinusoidalny wyprostowany dwupołówkowo",
            "Sygnał prostokątny",
            "Sygnał symetryczny",
            "Sygnał trójkątny",
            "Skok jednostkowy",
            "Impuls jednostkowy",
            "Szum impulsowy"});
            this.SignalSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignalSelect.Items.AddRange(new object[] {
            "Szum o rozkładzie jednostajnym",
            "Szum gaussowski",
            "Sygnał sinusoidalny",
            "Sygnał sinosoidalny wyprostowany jednopołówkowo",
            "Sygnał sinusoidalny wyprostowany dwupołówkowo",
            "Sygnał prostokątny",
            "Sygnał symetryczny",
            "Sygnał trójkątny",
            "Skok jednostkowy",
            "Impuls jednostkowy",
            "Szum impulsowy"});
            this.SignalSelect.Location = new System.Drawing.Point(5, 3);
            this.SignalSelect.Name = "SignalSelect";
            this.SignalSelect.Size = new System.Drawing.Size(259, 21);
            this.SignalSelect.TabIndex = 0;
            this.SignalSelect.SelectedIndexChanged += new System.EventHandler(this.SignalSelect_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(230, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Numer pierwszej próbki";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 165);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Współczynnik wypełnienia";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(79, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Skok czasowy";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(79, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Okres sygnału";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(116, 91);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Czas trwania sygnału";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(89, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(177, 20);
            this.textBox9.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Czas początkowy";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(79, 46);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(187, 20);
            this.textBox10.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Amplituda";
            // 
            // CzestotliwoscInput
            // 
            this.CzestotliwoscInput.Location = new System.Drawing.Point(79, 24);
            this.CzestotliwoscInput.Name = "CzestotliwoscInput";
            this.CzestotliwoscInput.Size = new System.Drawing.Size(187, 20);
            this.CzestotliwoscInput.TabIndex = 2;
            this.CzestotliwoscInput.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Częstotliwość";
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Szum o rozkładzie jednostajnym",
            "Szum gaussowski",
            "Sygnał sinusoidalny",
            "Sygnał sinosoidalny wyprostowany jednopołówkowo",
            "Sygnał sinusoidalny wyprostowany dwupołówkowo",
            "Sygnał prostokątny",
            "Sygnał symetryczny",
            "Sygnał trójkątny",
            "Skok jednostkowy",
            "Impuls jednostkowy",
            "Szum impulsowy"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "Szum o rozkładzie jednostajnym",
            "Szum gaussowski",
            "Sygnał sinusoidalny",
            "Sygnał sinosoidalny wyprostowany jednopołówkowo",
            "Sygnał sinusoidalny wyprostowany dwupołówkowo",
            "Sygnał prostokątny",
            "Sygnał symetryczny",
            "Sygnał trójkątny",
            "Skok jednostkowy",
            "Impuls jednostkowy",
            "Szum impulsowy"});
            this.comboBox2.Location = new System.Drawing.Point(5, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // TabController
            // 
            this.TabController.AllowDrop = true;
            this.TabController.Controls.Add(this.ObliczeniaTab);
            this.TabController.Controls.Add(this.ACTab);
            this.TabController.Controls.Add(this.CATab);
            this.TabController.Location = new System.Drawing.Point(2, 3);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(260, 292);
            this.TabController.TabIndex = 0;
            // 
            // ObliczeniaTab
            // 
            this.ObliczeniaTab.Controls.Add(this.MocSredniaOutput);
            this.ObliczeniaTab.Controls.Add(this.WartoscSrednia);
            this.ObliczeniaTab.Controls.Add(this.WartoscSredniaOutput);
            this.ObliczeniaTab.Controls.Add(this.MocSrednia);
            this.ObliczeniaTab.Controls.Add(this.WariacjaOutput);
            this.ObliczeniaTab.Controls.Add(this.Wariacja);
            this.ObliczeniaTab.Controls.Add(this.WartoscSkuteczna);
            this.ObliczeniaTab.Controls.Add(this.WartoscSkutecznaOutput);
            this.ObliczeniaTab.Controls.Add(this.WartoscSredniaBezwzglednaOutpu);
            this.ObliczeniaTab.Controls.Add(this.WartoscSredniaBezwzgledna);
            this.ObliczeniaTab.Location = new System.Drawing.Point(4, 22);
            this.ObliczeniaTab.Name = "ObliczeniaTab";
            this.ObliczeniaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ObliczeniaTab.Size = new System.Drawing.Size(252, 266);
            this.ObliczeniaTab.TabIndex = 0;
            this.ObliczeniaTab.Text = "Obliczenia";
            this.ObliczeniaTab.UseVisualStyleBackColor = true;
            // 
            // MocSredniaOutput
            // 
            this.MocSredniaOutput.AutoSize = true;
            this.MocSredniaOutput.Location = new System.Drawing.Point(79, 107);
            this.MocSredniaOutput.Name = "MocSredniaOutput";
            this.MocSredniaOutput.Size = new System.Drawing.Size(35, 13);
            this.MocSredniaOutput.TabIndex = 9;
            this.MocSredniaOutput.Text = "label5";
            // 
            // WartoscSrednia
            // 
            this.WartoscSrednia.AutoSize = true;
            this.WartoscSrednia.Location = new System.Drawing.Point(8, 13);
            this.WartoscSrednia.Name = "WartoscSrednia";
            this.WartoscSrednia.Size = new System.Drawing.Size(84, 13);
            this.WartoscSrednia.TabIndex = 0;
            this.WartoscSrednia.Text = "Wartość średnia";
            // 
            // WartoscSredniaOutput
            // 
            this.WartoscSredniaOutput.AutoSize = true;
            this.WartoscSredniaOutput.Location = new System.Drawing.Point(98, 13);
            this.WartoscSredniaOutput.Name = "WartoscSredniaOutput";
            this.WartoscSredniaOutput.Size = new System.Drawing.Size(35, 13);
            this.WartoscSredniaOutput.TabIndex = 5;
            this.WartoscSredniaOutput.Text = "label1";
            // 
            // MocSrednia
            // 
            this.MocSrednia.AutoSize = true;
            this.MocSrednia.Location = new System.Drawing.Point(8, 107);
            this.MocSrednia.Name = "MocSrednia";
            this.MocSrednia.Size = new System.Drawing.Size(65, 13);
            this.MocSrednia.TabIndex = 4;
            this.MocSrednia.Text = "Moc średnia";
            // 
            // WariacjaOutput
            // 
            this.WariacjaOutput.AutoSize = true;
            this.WariacjaOutput.Location = new System.Drawing.Point(63, 84);
            this.WariacjaOutput.Name = "WariacjaOutput";
            this.WariacjaOutput.Size = new System.Drawing.Size(35, 13);
            this.WariacjaOutput.TabIndex = 8;
            this.WariacjaOutput.Text = "label4";
            // 
            // Wariacja
            // 
            this.Wariacja.AutoSize = true;
            this.Wariacja.Location = new System.Drawing.Point(8, 84);
            this.Wariacja.Name = "Wariacja";
            this.Wariacja.Size = new System.Drawing.Size(49, 13);
            this.Wariacja.TabIndex = 3;
            this.Wariacja.Text = "Wariacja";
            // 
            // WartoscSkuteczna
            // 
            this.WartoscSkuteczna.AutoSize = true;
            this.WartoscSkuteczna.Location = new System.Drawing.Point(8, 60);
            this.WartoscSkuteczna.Name = "WartoscSkuteczna";
            this.WartoscSkuteczna.Size = new System.Drawing.Size(99, 13);
            this.WartoscSkuteczna.TabIndex = 2;
            this.WartoscSkuteczna.Text = "Wartość skuteczna";
            // 
            // WartoscSkutecznaOutput
            // 
            this.WartoscSkutecznaOutput.AutoSize = true;
            this.WartoscSkutecznaOutput.Location = new System.Drawing.Point(113, 60);
            this.WartoscSkutecznaOutput.Name = "WartoscSkutecznaOutput";
            this.WartoscSkutecznaOutput.Size = new System.Drawing.Size(35, 13);
            this.WartoscSkutecznaOutput.TabIndex = 7;
            this.WartoscSkutecznaOutput.Text = "label3";
            // 
            // WartoscSredniaBezwzglednaOutpu
            // 
            this.WartoscSredniaBezwzglednaOutpu.AutoSize = true;
            this.WartoscSredniaBezwzglednaOutpu.Location = new System.Drawing.Point(163, 36);
            this.WartoscSredniaBezwzglednaOutpu.Name = "WartoscSredniaBezwzglednaOutpu";
            this.WartoscSredniaBezwzglednaOutpu.Size = new System.Drawing.Size(35, 13);
            this.WartoscSredniaBezwzglednaOutpu.TabIndex = 6;
            this.WartoscSredniaBezwzglednaOutpu.Text = "label2";
            // 
            // WartoscSredniaBezwzgledna
            // 
            this.WartoscSredniaBezwzgledna.AutoSize = true;
            this.WartoscSredniaBezwzgledna.Location = new System.Drawing.Point(8, 36);
            this.WartoscSredniaBezwzgledna.Name = "WartoscSredniaBezwzgledna";
            this.WartoscSredniaBezwzgledna.Size = new System.Drawing.Size(149, 13);
            this.WartoscSredniaBezwzgledna.TabIndex = 1;
            this.WartoscSredniaBezwzgledna.Text = "Wartość średnia bezwzględna";
            // 
            // ACTab
            // 
            this.ACTab.Controls.Add(this.AC2Button);
            this.ACTab.Controls.Add(this.label13);
            this.ACTab.Controls.Add(this.label14);
            this.ACTab.Controls.Add(this.CzestotliwoscProbkowania2Input);
            this.ACTab.Controls.Add(this.SamplingButton);
            this.ACTab.Controls.Add(this.label2);
            this.ACTab.Controls.Add(this.SamplingFreq);
            this.ACTab.Controls.Add(this.SamplingFreqInput);
            this.ACTab.Location = new System.Drawing.Point(4, 22);
            this.ACTab.Name = "ACTab";
            this.ACTab.Padding = new System.Windows.Forms.Padding(3);
            this.ACTab.Size = new System.Drawing.Size(252, 266);
            this.ACTab.TabIndex = 1;
            this.ACTab.Text = "A/C";
            this.ACTab.UseVisualStyleBackColor = true;
            // 
            // AC2Button
            // 
            this.AC2Button.Location = new System.Drawing.Point(73, 139);
            this.AC2Button.Name = "AC2Button";
            this.AC2Button.Size = new System.Drawing.Size(90, 23);
            this.AC2Button.TabIndex = 14;
            this.AC2Button.Text = "Konwertuj";
            this.AC2Button.UseVisualStyleBackColor = true;
            this.AC2Button.Click += new System.EventHandler(this.AC2Button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = " Kwantyzacja równomierna z zaokrągleniem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Częstotliwość próbkowania";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CzestotliwoscProbkowania2Input
            // 
            this.CzestotliwoscProbkowania2Input.Location = new System.Drawing.Point(154, 113);
            this.CzestotliwoscProbkowania2Input.Name = "CzestotliwoscProbkowania2Input";
            this.CzestotliwoscProbkowania2Input.Size = new System.Drawing.Size(92, 20);
            this.CzestotliwoscProbkowania2Input.TabIndex = 10;
            // 
            // SamplingButton
            // 
            this.SamplingButton.Location = new System.Drawing.Point(73, 46);
            this.SamplingButton.Name = "SamplingButton";
            this.SamplingButton.Size = new System.Drawing.Size(90, 23);
            this.SamplingButton.TabIndex = 8;
            this.SamplingButton.Text = "Konwertuj";
            this.SamplingButton.UseVisualStyleBackColor = true;
            this.SamplingButton.Click += new System.EventHandler(this.SamplingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Próbkowanie równomierne";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SamplingFreq
            // 
            this.SamplingFreq.AutoSize = true;
            this.SamplingFreq.Location = new System.Drawing.Point(6, 23);
            this.SamplingFreq.Name = "SamplingFreq";
            this.SamplingFreq.Size = new System.Drawing.Size(135, 13);
            this.SamplingFreq.TabIndex = 3;
            this.SamplingFreq.Text = "Częstotliwość próbkowania";
            // 
            // SamplingFreqInput
            // 
            this.SamplingFreqInput.Location = new System.Drawing.Point(154, 20);
            this.SamplingFreqInput.Name = "SamplingFreqInput";
            this.SamplingFreqInput.Size = new System.Drawing.Size(92, 20);
            this.SamplingFreqInput.TabIndex = 4;
            // 
            // CATab
            // 
            this.CATab.Location = new System.Drawing.Point(4, 22);
            this.CATab.Name = "CATab";
            this.CATab.Padding = new System.Windows.Forms.Padding(3);
            this.CATab.Size = new System.Drawing.Size(252, 266);
            this.CATab.TabIndex = 2;
            this.CATab.Text = "C/A";
            this.CATab.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Size = new System.Drawing.Size(617, 698);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 0;
            // 
            // Plot
            // 
            chartArea1.Name = "ChartArea1";
            this.Plot.ChartAreas.Add(chartArea1);
            this.Plot.Location = new System.Drawing.Point(6, 3);
            this.Plot.Name = "Plot";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.Plot.Series.Add(series1);
            this.Plot.Size = new System.Drawing.Size(608, 324);
            this.Plot.TabIndex = 0;
            this.Plot.Text = " ";
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // Histogram
            // 
            chartArea2.Name = "ChartArea1";
            this.Histogram.ChartAreas.Add(chartArea2);
            this.Histogram.Location = new System.Drawing.Point(2, 1);
            this.Histogram.Margin = new System.Windows.Forms.Padding(0);
            this.Histogram.Name = "Histogram";
            this.Histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.Histogram.Series.Add(series2);
            this.Histogram.Size = new System.Drawing.Size(612, 363);
            this.Histogram.TabIndex = 0;
            this.Histogram.Text = "chart2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CPS
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 722);
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
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.Data.ResumeLayout(false);
            this.TabController.ResumeLayout(false);
            this.ObliczeniaTab.ResumeLayout(false);
            this.ObliczeniaTab.PerformLayout();
            this.ACTab.ResumeLayout(false);
            this.ACTab.PerformLayout();
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
        private System.Windows.Forms.Label WspolczynnikWypelnienia;
        private System.Windows.Forms.TextBox WspolczynnikWypelnieniaInput;
        private System.Windows.Forms.TextBox PrawdopodobienstwoAInput;
        private System.Windows.Forms.Label PrawdopodobieństwoA;
        private System.Windows.Forms.TextBox NumerProbkiSkokuInput;
        private System.Windows.Forms.Label NumerProbkiSkoku;
        private System.Windows.Forms.TextBox NumerPierwszejProbkiInput;
        private System.Windows.Forms.Label NumerPierwszejProbki;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CzestotliwoscInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ObliczButton;
        private System.Windows.Forms.ComboBox OperacjeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WgrajButton;
        private System.Windows.Forms.Label DodatkowySygnal;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage ObliczeniaTab;
        private System.Windows.Forms.TabPage ACTab;
        private System.Windows.Forms.Label SamplingFreq;
        private System.Windows.Forms.TextBox SamplingFreqInput;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage CATab;
        private System.Windows.Forms.Button AC2Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CzestotliwoscProbkowania2Input;
        private System.Windows.Forms.Button SamplingButton;
        private System.Windows.Forms.Label label2;
    }
}

