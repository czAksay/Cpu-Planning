namespace CPUPlanning
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.pnlParameters = new System.Windows.Forms.TableLayoutPanel();
            this.lblIntensivity = new System.Windows.Forms.Label();
            this.numIntensivity = new System.Windows.Forms.NumericUpDown();
            this.lblMaxInterval = new System.Windows.Forms.Label();
            this.lblPrDiapazon = new System.Windows.Forms.Label();
            this.lblPrGrowing = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.numPrDiapason = new System.Windows.Forms.NumericUpDown();
            this.lblQuant = new System.Windows.Forms.Label();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            this.numCountOfRes = new System.Windows.Forms.NumericUpDown();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbShowMessages = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.lbStats = new System.Windows.Forms.ListBox();
            this.pnlScreens = new System.Windows.Forms.TableLayoutPanel();
            this.gbRes3 = new System.Windows.Forms.GroupBox();
            this.lbRes3 = new System.Windows.Forms.ListBox();
            this.gbCpu = new System.Windows.Forms.GroupBox();
            this.lbCpu = new System.Windows.Forms.ListBox();
            this.gbQueue = new System.Windows.Forms.GroupBox();
            this.lbQueue = new System.Windows.Forms.ListBox();
            this.gbResQu1 = new System.Windows.Forms.GroupBox();
            this.lbResQu1 = new System.Windows.Forms.ListBox();
            this.gbResQu2 = new System.Windows.Forms.GroupBox();
            this.lbResQu2 = new System.Windows.Forms.ListBox();
            this.gbRes1 = new System.Windows.Forms.GroupBox();
            this.lbRes1 = new System.Windows.Forms.ListBox();
            this.gbRes2 = new System.Windows.Forms.GroupBox();
            this.lbRes2 = new System.Windows.Forms.ListBox();
            this.gbResQu3 = new System.Windows.Forms.GroupBox();
            this.lbResQu3 = new System.Windows.Forms.ListBox();
            this.numLayers = new System.Windows.Forms.NumericUpDown();
            this.numBitSize = new System.Windows.Forms.NumericUpDown();
            this.lblBitSize = new System.Windows.Forms.Label();
            this.pnlMemory = new System.Windows.Forms.TableLayoutPanel();
            this.lblLayers = new System.Windows.Forms.Label();
            this.gbMemory = new System.Windows.Forms.GroupBox();
            this.lbMemory = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntensivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrDiapason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfRes)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbStats.SuspendLayout();
            this.pnlScreens.SuspendLayout();
            this.gbRes3.SuspendLayout();
            this.gbCpu.SuspendLayout();
            this.gbQueue.SuspendLayout();
            this.gbResQu1.SuspendLayout();
            this.gbResQu2.SuspendLayout();
            this.gbRes1.SuspendLayout();
            this.gbRes2.SuspendLayout();
            this.gbResQu3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitSize)).BeginInit();
            this.pnlMemory.SuspendLayout();
            this.gbMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.gbParameters, 0, 0);
            this.pnlMain.Controls.Add(this.pnlButtons, 0, 2);
            this.pnlMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.82258F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.17742F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.pnlMain.Size = new System.Drawing.Size(966, 632);
            this.pnlMain.TabIndex = 0;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.pnlParameters);
            this.gbParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbParameters.Location = new System.Drawing.Point(6, 6);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(954, 146);
            this.gbParameters.TabIndex = 0;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Параметры модели";
            // 
            // pnlParameters
            // 
            this.pnlParameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.pnlParameters.ColumnCount = 5;
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlParameters.Controls.Add(this.lblIntensivity, 0, 0);
            this.pnlParameters.Controls.Add(this.numIntensivity, 0, 1);
            this.pnlParameters.Controls.Add(this.lblMaxInterval, 1, 0);
            this.pnlParameters.Controls.Add(this.lblPrDiapazon, 2, 0);
            this.pnlParameters.Controls.Add(this.lblPrGrowing, 3, 0);
            this.pnlParameters.Controls.Add(this.numInterval, 1, 1);
            this.pnlParameters.Controls.Add(this.numPrDiapason, 2, 1);
            this.pnlParameters.Controls.Add(this.lblQuant, 4, 0);
            this.pnlParameters.Controls.Add(this.numQuant, 4, 1);
            this.pnlParameters.Controls.Add(this.numCountOfRes, 3, 1);
            this.pnlParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParameters.Location = new System.Drawing.Point(3, 20);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.RowCount = 2;
            this.pnlParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.90292F));
            this.pnlParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.09709F));
            this.pnlParameters.Size = new System.Drawing.Size(948, 123);
            this.pnlParameters.TabIndex = 0;
            // 
            // lblIntensivity
            // 
            this.lblIntensivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIntensivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIntensivity.Location = new System.Drawing.Point(6, 3);
            this.lblIntensivity.Name = "lblIntensivity";
            this.lblIntensivity.Size = new System.Drawing.Size(180, 79);
            this.lblIntensivity.TabIndex = 1;
            this.lblIntensivity.Text = "Порог интенсивность поступления процессов";
            this.lblIntensivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numIntensivity
            // 
            this.numIntensivity.DecimalPlaces = 2;
            this.numIntensivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numIntensivity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numIntensivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numIntensivity.Location = new System.Drawing.Point(6, 88);
            this.numIntensivity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntensivity.Name = "numIntensivity";
            this.numIntensivity.Size = new System.Drawing.Size(180, 22);
            this.numIntensivity.TabIndex = 1;
            this.numIntensivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIntensivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // lblMaxInterval
            // 
            this.lblMaxInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxInterval.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxInterval.Location = new System.Drawing.Point(195, 3);
            this.lblMaxInterval.Name = "lblMaxInterval";
            this.lblMaxInterval.Size = new System.Drawing.Size(180, 79);
            this.lblMaxInterval.TabIndex = 1;
            this.lblMaxInterval.Text = "Максимальная величина интервала обслуживания";
            this.lblMaxInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrDiapazon
            // 
            this.lblPrDiapazon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrDiapazon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrDiapazon.Location = new System.Drawing.Point(384, 3);
            this.lblPrDiapazon.Name = "lblPrDiapazon";
            this.lblPrDiapazon.Size = new System.Drawing.Size(180, 79);
            this.lblPrDiapazon.TabIndex = 1;
            this.lblPrDiapazon.Text = "Диапазон представления приоритетов";
            this.lblPrDiapazon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrGrowing
            // 
            this.lblPrGrowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrGrowing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrGrowing.Location = new System.Drawing.Point(573, 3);
            this.lblPrGrowing.Name = "lblPrGrowing";
            this.lblPrGrowing.Size = new System.Drawing.Size(180, 79);
            this.lblPrGrowing.TabIndex = 1;
            this.lblPrGrowing.Text = "Количество активных ресурсов";
            this.lblPrGrowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInterval
            // 
            this.numInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numInterval.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numInterval.Location = new System.Drawing.Point(195, 88);
            this.numInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(180, 22);
            this.numInterval.TabIndex = 1;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numInterval.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numPrDiapason
            // 
            this.numPrDiapason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrDiapason.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPrDiapason.Location = new System.Drawing.Point(384, 88);
            this.numPrDiapason.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numPrDiapason.Name = "numPrDiapason";
            this.numPrDiapason.Size = new System.Drawing.Size(180, 22);
            this.numPrDiapason.TabIndex = 1;
            this.numPrDiapason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrDiapason.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblQuant
            // 
            this.lblQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuant.Location = new System.Drawing.Point(762, 3);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(180, 79);
            this.lblQuant.TabIndex = 1;
            this.lblQuant.Text = "Величина кванта времени";
            this.lblQuant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuant
            // 
            this.numQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuant.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numQuant.Location = new System.Drawing.Point(762, 88);
            this.numQuant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(180, 22);
            this.numQuant.TabIndex = 1;
            this.numQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuant.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numCountOfRes
            // 
            this.numCountOfRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCountOfRes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCountOfRes.Location = new System.Drawing.Point(573, 88);
            this.numCountOfRes.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCountOfRes.Name = "numCountOfRes";
            this.numCountOfRes.Size = new System.Drawing.Size(180, 22);
            this.numCountOfRes.TabIndex = 1;
            this.numCountOfRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCountOfRes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 4;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlButtons.Controls.Add(this.btnStart, 1, 0);
            this.pnlButtons.Controls.Add(this.btnNext, 2, 0);
            this.pnlButtons.Controls.Add(this.btnStop, 3, 0);
            this.pnlButtons.Controls.Add(this.btnHelp, 3, 1);
            this.pnlButtons.Controls.Add(this.cbShowMessages, 0, 1);
            this.pnlButtons.Location = new System.Drawing.Point(6, 560);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(954, 66);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(527, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 27);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(670, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 27);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Следующий";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(813, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 27);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(813, 36);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(138, 27);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cbShowMessages
            // 
            this.cbShowMessages.AutoSize = true;
            this.cbShowMessages.Checked = true;
            this.cbShowMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMessages.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbShowMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowMessages.Location = new System.Drawing.Point(326, 36);
            this.cbShowMessages.Name = "cbShowMessages";
            this.cbShowMessages.Size = new System.Drawing.Size(195, 27);
            this.cbShowMessages.TabIndex = 2;
            this.cbShowMessages.Text = "Показывать сообщения";
            this.cbShowMessages.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.45702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.54298F));
            this.tableLayoutPanel1.Controls.Add(this.gbStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlScreens, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 390);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.lbStats);
            this.gbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStats.Location = new System.Drawing.Point(637, 3);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(314, 384);
            this.gbStats.TabIndex = 11;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Статистика";
            // 
            // lbStats
            // 
            this.lbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStats.FormattingEnabled = true;
            this.lbStats.ItemHeight = 15;
            this.lbStats.Location = new System.Drawing.Point(3, 17);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(308, 364);
            this.lbStats.TabIndex = 0;
            // 
            // pnlScreens
            // 
            this.pnlScreens.ColumnCount = 2;
            this.pnlScreens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScreens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScreens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlScreens.Controls.Add(this.gbRes3, 0, 3);
            this.pnlScreens.Controls.Add(this.gbCpu, 1, 0);
            this.pnlScreens.Controls.Add(this.gbQueue, 0, 0);
            this.pnlScreens.Controls.Add(this.gbResQu1, 0, 1);
            this.pnlScreens.Controls.Add(this.gbResQu2, 0, 2);
            this.pnlScreens.Controls.Add(this.gbRes1, 1, 1);
            this.pnlScreens.Controls.Add(this.gbRes2, 1, 2);
            this.pnlScreens.Controls.Add(this.gbResQu3, 0, 3);
            this.pnlScreens.Location = new System.Drawing.Point(3, 3);
            this.pnlScreens.Name = "pnlScreens";
            this.pnlScreens.RowCount = 4;
            this.pnlScreens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlScreens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlScreens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlScreens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlScreens.Size = new System.Drawing.Size(628, 384);
            this.pnlScreens.TabIndex = 2;
            // 
            // gbRes3
            // 
            this.gbRes3.Controls.Add(this.lbRes3);
            this.gbRes3.Enabled = false;
            this.gbRes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRes3.Location = new System.Drawing.Point(317, 291);
            this.gbRes3.Name = "gbRes3";
            this.gbRes3.Size = new System.Drawing.Size(308, 90);
            this.gbRes3.TabIndex = 9;
            this.gbRes3.TabStop = false;
            this.gbRes3.Text = "Ресурс 3";
            // 
            // lbRes3
            // 
            this.lbRes3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRes3.FormattingEnabled = true;
            this.lbRes3.ItemHeight = 15;
            this.lbRes3.Location = new System.Drawing.Point(3, 17);
            this.lbRes3.Name = "lbRes3";
            this.lbRes3.Size = new System.Drawing.Size(302, 70);
            this.lbRes3.TabIndex = 0;
            // 
            // gbCpu
            // 
            this.gbCpu.Controls.Add(this.lbCpu);
            this.gbCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCpu.Location = new System.Drawing.Point(317, 3);
            this.gbCpu.Name = "gbCpu";
            this.gbCpu.Size = new System.Drawing.Size(308, 90);
            this.gbCpu.TabIndex = 1;
            this.gbCpu.TabStop = false;
            this.gbCpu.Text = "Центральный процессор";
            // 
            // lbCpu
            // 
            this.lbCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCpu.FormattingEnabled = true;
            this.lbCpu.ItemHeight = 15;
            this.lbCpu.Location = new System.Drawing.Point(3, 17);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(302, 70);
            this.lbCpu.TabIndex = 0;
            // 
            // gbQueue
            // 
            this.gbQueue.Controls.Add(this.lbQueue);
            this.gbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbQueue.Location = new System.Drawing.Point(3, 3);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Size = new System.Drawing.Size(308, 90);
            this.gbQueue.TabIndex = 0;
            this.gbQueue.TabStop = false;
            this.gbQueue.Text = "Очередь к процессору";
            // 
            // lbQueue
            // 
            this.lbQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQueue.FormattingEnabled = true;
            this.lbQueue.ItemHeight = 15;
            this.lbQueue.Location = new System.Drawing.Point(3, 17);
            this.lbQueue.Name = "lbQueue";
            this.lbQueue.Size = new System.Drawing.Size(302, 70);
            this.lbQueue.TabIndex = 0;
            // 
            // gbResQu1
            // 
            this.gbResQu1.Controls.Add(this.lbResQu1);
            this.gbResQu1.Enabled = false;
            this.gbResQu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbResQu1.Location = new System.Drawing.Point(3, 99);
            this.gbResQu1.Name = "gbResQu1";
            this.gbResQu1.Size = new System.Drawing.Size(308, 90);
            this.gbResQu1.TabIndex = 2;
            this.gbResQu1.TabStop = false;
            this.gbResQu1.Text = "Очередь к ресурсу 1";
            // 
            // lbResQu1
            // 
            this.lbResQu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResQu1.FormattingEnabled = true;
            this.lbResQu1.ItemHeight = 15;
            this.lbResQu1.Location = new System.Drawing.Point(3, 17);
            this.lbResQu1.Name = "lbResQu1";
            this.lbResQu1.Size = new System.Drawing.Size(302, 70);
            this.lbResQu1.TabIndex = 0;
            // 
            // gbResQu2
            // 
            this.gbResQu2.Controls.Add(this.lbResQu2);
            this.gbResQu2.Enabled = false;
            this.gbResQu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbResQu2.Location = new System.Drawing.Point(3, 195);
            this.gbResQu2.Name = "gbResQu2";
            this.gbResQu2.Size = new System.Drawing.Size(308, 90);
            this.gbResQu2.TabIndex = 3;
            this.gbResQu2.TabStop = false;
            this.gbResQu2.Text = "Очередь к ресурсу 2";
            // 
            // lbResQu2
            // 
            this.lbResQu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResQu2.FormattingEnabled = true;
            this.lbResQu2.ItemHeight = 15;
            this.lbResQu2.Location = new System.Drawing.Point(3, 17);
            this.lbResQu2.Name = "lbResQu2";
            this.lbResQu2.Size = new System.Drawing.Size(302, 70);
            this.lbResQu2.TabIndex = 0;
            // 
            // gbRes1
            // 
            this.gbRes1.Controls.Add(this.lbRes1);
            this.gbRes1.Enabled = false;
            this.gbRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRes1.Location = new System.Drawing.Point(317, 99);
            this.gbRes1.Name = "gbRes1";
            this.gbRes1.Size = new System.Drawing.Size(308, 90);
            this.gbRes1.TabIndex = 5;
            this.gbRes1.TabStop = false;
            this.gbRes1.Text = "Ресурс 1";
            // 
            // lbRes1
            // 
            this.lbRes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRes1.FormattingEnabled = true;
            this.lbRes1.ItemHeight = 15;
            this.lbRes1.Location = new System.Drawing.Point(3, 17);
            this.lbRes1.Name = "lbRes1";
            this.lbRes1.Size = new System.Drawing.Size(302, 70);
            this.lbRes1.TabIndex = 0;
            // 
            // gbRes2
            // 
            this.gbRes2.Controls.Add(this.lbRes2);
            this.gbRes2.Enabled = false;
            this.gbRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRes2.Location = new System.Drawing.Point(317, 195);
            this.gbRes2.Name = "gbRes2";
            this.gbRes2.Size = new System.Drawing.Size(308, 90);
            this.gbRes2.TabIndex = 6;
            this.gbRes2.TabStop = false;
            this.gbRes2.Text = "Ресурс 2";
            // 
            // lbRes2
            // 
            this.lbRes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRes2.FormattingEnabled = true;
            this.lbRes2.ItemHeight = 15;
            this.lbRes2.Location = new System.Drawing.Point(3, 17);
            this.lbRes2.Name = "lbRes2";
            this.lbRes2.Size = new System.Drawing.Size(302, 70);
            this.lbRes2.TabIndex = 0;
            // 
            // gbResQu3
            // 
            this.gbResQu3.Controls.Add(this.lbResQu3);
            this.gbResQu3.Enabled = false;
            this.gbResQu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbResQu3.Location = new System.Drawing.Point(3, 291);
            this.gbResQu3.Name = "gbResQu3";
            this.gbResQu3.Size = new System.Drawing.Size(308, 90);
            this.gbResQu3.TabIndex = 4;
            this.gbResQu3.TabStop = false;
            this.gbResQu3.Text = "Очередь к ресурсу 3";
            // 
            // lbResQu3
            // 
            this.lbResQu3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResQu3.FormattingEnabled = true;
            this.lbResQu3.ItemHeight = 15;
            this.lbResQu3.Location = new System.Drawing.Point(3, 17);
            this.lbResQu3.Name = "lbResQu3";
            this.lbResQu3.Size = new System.Drawing.Size(302, 70);
            this.lbResQu3.TabIndex = 0;
            // 
            // numLayers
            // 
            this.numLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLayers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numLayers.Location = new System.Drawing.Point(6, 85);
            this.numLayers.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.Name = "numLayers";
            this.numLayers.Size = new System.Drawing.Size(135, 22);
            this.numLayers.TabIndex = 3;
            this.numLayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLayers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numBitSize
            // 
            this.numBitSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBitSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBitSize.Location = new System.Drawing.Point(150, 85);
            this.numBitSize.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numBitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBitSize.Name = "numBitSize";
            this.numBitSize.Size = new System.Drawing.Size(136, 22);
            this.numBitSize.TabIndex = 5;
            this.numBitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBitSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblBitSize
            // 
            this.lblBitSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBitSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBitSize.Location = new System.Drawing.Point(150, 3);
            this.lblBitSize.Name = "lblBitSize";
            this.lblBitSize.Size = new System.Drawing.Size(136, 76);
            this.lblBitSize.TabIndex = 4;
            this.lblBitSize.Text = "Максимальный размер процесса в битовой карте (бит)";
            this.lblBitSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMemory
            // 
            this.pnlMemory.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.pnlMemory.ColumnCount = 2;
            this.pnlMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMemory.Controls.Add(this.lblLayers, 0, 0);
            this.pnlMemory.Controls.Add(this.numBitSize, 1, 1);
            this.pnlMemory.Controls.Add(this.lblBitSize, 1, 0);
            this.pnlMemory.Controls.Add(this.numLayers, 0, 1);
            this.pnlMemory.Location = new System.Drawing.Point(963, 26);
            this.pnlMemory.Name = "pnlMemory";
            this.pnlMemory.RowCount = 2;
            this.pnlMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.pnlMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.pnlMemory.Size = new System.Drawing.Size(292, 123);
            this.pnlMemory.TabIndex = 6;
            // 
            // lblLayers
            // 
            this.lblLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLayers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLayers.Location = new System.Drawing.Point(6, 3);
            this.lblLayers.Name = "lblLayers";
            this.lblLayers.Size = new System.Drawing.Size(135, 76);
            this.lblLayers.TabIndex = 3;
            this.lblLayers.Text = "Количество слоев битовой карты";
            this.lblLayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbMemory
            // 
            this.gbMemory.Controls.Add(this.lbMemory);
            this.gbMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMemory.Location = new System.Drawing.Point(969, 161);
            this.gbMemory.Name = "gbMemory";
            this.gbMemory.Size = new System.Drawing.Size(280, 471);
            this.gbMemory.TabIndex = 8;
            this.gbMemory.TabStop = false;
            this.gbMemory.Text = "Размещение в памяти";
            // 
            // lbMemory
            // 
            this.lbMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMemory.FormattingEnabled = true;
            this.lbMemory.ItemHeight = 20;
            this.lbMemory.Location = new System.Drawing.Point(3, 17);
            this.lbMemory.Name = "lbMemory";
            this.lbMemory.Size = new System.Drawing.Size(274, 451);
            this.lbMemory.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 632);
            this.Controls.Add(this.gbMemory);
            this.Controls.Add(this.pnlMemory);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм работы центрального процессора";
            this.pnlMain.ResumeLayout(false);
            this.gbParameters.ResumeLayout(false);
            this.pnlParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numIntensivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrDiapason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfRes)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbStats.ResumeLayout(false);
            this.pnlScreens.ResumeLayout(false);
            this.gbRes3.ResumeLayout(false);
            this.gbCpu.ResumeLayout(false);
            this.gbQueue.ResumeLayout(false);
            this.gbResQu1.ResumeLayout(false);
            this.gbResQu2.ResumeLayout(false);
            this.gbRes1.ResumeLayout(false);
            this.gbRes2.ResumeLayout(false);
            this.gbResQu3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitSize)).EndInit();
            this.pnlMemory.ResumeLayout(false);
            this.gbMemory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.TableLayoutPanel pnlParameters;
        private System.Windows.Forms.Label lblIntensivity;
        private System.Windows.Forms.Label lblMaxInterval;
        private System.Windows.Forms.Label lblPrDiapazon;
        private System.Windows.Forms.Label lblPrGrowing;
        private System.Windows.Forms.NumericUpDown numIntensivity;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.NumericUpDown numPrDiapason;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.NumericUpDown numQuant;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.ListBox lbStats;
        private System.Windows.Forms.TableLayoutPanel pnlScreens;
        private System.Windows.Forms.GroupBox gbRes3;
        private System.Windows.Forms.ListBox lbRes3;
        private System.Windows.Forms.GroupBox gbCpu;
        private System.Windows.Forms.ListBox lbCpu;
        private System.Windows.Forms.GroupBox gbQueue;
        private System.Windows.Forms.ListBox lbQueue;
        private System.Windows.Forms.GroupBox gbResQu1;
        private System.Windows.Forms.ListBox lbResQu1;
        private System.Windows.Forms.GroupBox gbResQu2;
        private System.Windows.Forms.ListBox lbResQu2;
        private System.Windows.Forms.GroupBox gbRes1;
        private System.Windows.Forms.ListBox lbRes1;
        private System.Windows.Forms.GroupBox gbRes2;
        private System.Windows.Forms.ListBox lbRes2;
        private System.Windows.Forms.GroupBox gbResQu3;
        private System.Windows.Forms.ListBox lbResQu3;
        private System.Windows.Forms.NumericUpDown numCountOfRes;
        private System.Windows.Forms.NumericUpDown numLayers;
        private System.Windows.Forms.NumericUpDown numBitSize;
        private System.Windows.Forms.Label lblBitSize;
        private System.Windows.Forms.TableLayoutPanel pnlMemory;
        private System.Windows.Forms.Label lblLayers;
        private System.Windows.Forms.GroupBox gbMemory;
        private System.Windows.Forms.ListBox lbMemory;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbShowMessages;
    }
}

