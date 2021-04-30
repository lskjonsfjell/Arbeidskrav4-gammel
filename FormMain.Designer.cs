﻿
namespace Arbeidskrav1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label area_numberLabel;
            System.Windows.Forms.Label manufactor_IdLabel;
            System.Windows.Forms.Label computer_IdLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lIGHT_MEASURE1DataSet = new Arbeidskrav1.LIGHT_MEASURE1DataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatusRead = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerChartadd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialRecieve = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogCsv = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerChartScaled = new System.Windows.Forms.Timer(this.components);
            this.timerRecievedScaled = new System.Windows.Forms.Timer(this.components);
            this.timerWrite2Device = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogChart = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogScaled = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new Arbeidskrav1.LIGHT_MEASURE1DataSetTableAdapters.TableAdapterManager();
            this.bindingSourceMeasureAI = new System.Windows.Forms.BindingSource(this.components);
            this.lIGHT_MEASURE1DataSet1 = new Arbeidskrav1.LIGHT_MEASURE1DataSet1();
            this.bindingSourceInstrumentCinfig = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new Arbeidskrav1.LIGHT_MEASURE1DataSetTableAdapters.AreaTableAdapter();
            this.manufactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactorTableAdapter = new Arbeidskrav1.LIGHT_MEASURE1DataSetTableAdapters.ManufactorTableAdapter();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTableAdapter = new Arbeidskrav1.LIGHT_MEASURE1DataSetTableAdapters.DeviceTableAdapter();
            this.tabPage_CurrentValues = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSaveScaled = new System.Windows.Forms.Button();
            this.buttonSaveChart = new System.Windows.Forms.Button();
            this.listBoxScaled = new System.Windows.Forms.ListBox();
            this.checkBoxRawVals = new System.Windows.Forms.CheckBox();
            this.checkBoxScaledVals = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSaveCsv = new System.Windows.Forms.Button();
            this.buttonStopAuto = new System.Windows.Forms.Button();
            this.buttonStartAuto = new System.Windows.Forms.Button();
            this.listBoxRaw = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_InstrumentConfig = new System.Windows.Forms.TabPage();
            this.comboBoxManufactor = new System.Windows.Forms.ComboBox();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxUpdateFrequency = new System.Windows.Forms.TextBox();
            this.textBoxReadVals = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSave2DB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonWrite2Device = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonReadStatus = new System.Windows.Forms.Button();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveConfig2File = new System.Windows.Forms.Button();
            this.tabPage_SerialPortConfig = new System.Windows.Forms.TabPage();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BitRate = new System.Windows.Forms.ComboBox();
            this.comboBox_ComPorts = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            area_numberLabel = new System.Windows.Forms.Label();
            manufactor_IdLabel = new System.Windows.Forms.Label();
            computer_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGHT_MEASURE1DataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMeasureAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGHT_MEASURE1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstrumentCinfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.tabPage_CurrentValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage_InstrumentConfig.SuspendLayout();
            this.tabPage_SerialPortConfig.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // area_numberLabel
            // 
            area_numberLabel.AutoSize = true;
            area_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_numberLabel.Location = new System.Drawing.Point(195, 286);
            area_numberLabel.Name = "area_numberLabel";
            area_numberLabel.Size = new System.Drawing.Size(33, 13);
            area_numberLabel.TabIndex = 511;
            area_numberLabel.Text = "Area";
            // 
            // manufactor_IdLabel
            // 
            manufactor_IdLabel.AutoSize = true;
            manufactor_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel.Location = new System.Drawing.Point(157, 316);
            manufactor_IdLabel.Name = "manufactor_IdLabel";
            manufactor_IdLabel.Size = new System.Drawing.Size(71, 13);
            manufactor_IdLabel.TabIndex = 514;
            manufactor_IdLabel.Text = "Manufactor";
            // 
            // computer_IdLabel
            // 
            computer_IdLabel.AutoSize = true;
            computer_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            computer_IdLabel.Location = new System.Drawing.Point(181, 349);
            computer_IdLabel.Name = "computer_IdLabel";
            computer_IdLabel.Size = new System.Drawing.Size(47, 13);
            computer_IdLabel.TabIndex = 513;
            computer_IdLabel.Text = "Device";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.lIGHT_MEASURE1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // lIGHT_MEASURE1DataSet
            // 
            this.lIGHT_MEASURE1DataSet.DataSetName = "LIGHT_MEASURE1DataSet";
            this.lIGHT_MEASURE1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelStatusRead});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripStatusLabelStatusRead
            // 
            this.toolStripStatusLabelStatusRead.Name = "toolStripStatusLabelStatusRead";
            this.toolStripStatusLabelStatusRead.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelStatusRead.Text = "toolStripStatusLabel3";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ssc";
            // 
            // timerChartadd
            // 
            this.timerChartadd.Interval = 1000;
            this.timerChartadd.Tick += new System.EventHandler(this.timerChartadd_Tick);
            // 
            // timerSerialRecieve
            // 
            this.timerSerialRecieve.Interval = 1000;
            this.timerSerialRecieve.Tick += new System.EventHandler(this.timerSerialRecieve_Tick);
            // 
            // saveFileDialogCsv
            // 
            this.saveFileDialogCsv.DefaultExt = "csv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ssc";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerChartScaled
            // 
            this.timerChartScaled.Interval = 1000;
            this.timerChartScaled.Tick += new System.EventHandler(this.timerChartScaled_Tick);
            // 
            // timerRecievedScaled
            // 
            this.timerRecievedScaled.Interval = 1000;
            this.timerRecievedScaled.Tick += new System.EventHandler(this.timerRecievedScaled_Tick);
            // 
            // timerWrite2Device
            // 
            this.timerWrite2Device.Interval = 1000;
            this.timerWrite2Device.Tick += new System.EventHandler(this.timerWrite2Device_Tick);
            // 
            // saveFileDialogScaled
            // 
            this.saveFileDialogScaled.DefaultExt = "csv";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComputerTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Device1TableAdapter = null;
            this.tableAdapterManager.Device2TableAdapter = null;
            this.tableAdapterManager.Device3TableAdapter = null;
            this.tableAdapterManager.DeviceTableAdapter = null;
            this.tableAdapterManager.Instrument_ConfigurationTableAdapter = null;
            this.tableAdapterManager.ManufactorTableAdapter = null;
            this.tableAdapterManager.Measurment_AITableAdapter = null;
            this.tableAdapterManager.Measurment_AOTableAdapter = null;
            this.tableAdapterManager.Measurment_DITableAdapter = null;
            this.tableAdapterManager.Measurment_DOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Arbeidskrav1.LIGHT_MEASURE1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSourceMeasureAI
            // 
            this.bindingSourceMeasureAI.DataSource = this.lIGHT_MEASURE1DataSet1;
            this.bindingSourceMeasureAI.Position = 0;
            // 
            // lIGHT_MEASURE1DataSet1
            // 
            this.lIGHT_MEASURE1DataSet1.DataSetName = "LIGHT_MEASURE1DataSet1";
            this.lIGHT_MEASURE1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceInstrumentCinfig
            // 
            this.bindingSourceInstrumentCinfig.DataSource = this.lIGHT_MEASURE1DataSet1;
            this.bindingSourceInstrumentCinfig.Position = 0;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.lIGHT_MEASURE1DataSet;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // manufactorBindingSource
            // 
            this.manufactorBindingSource.DataMember = "Manufactor";
            this.manufactorBindingSource.DataSource = this.lIGHT_MEASURE1DataSet;
            // 
            // manufactorTableAdapter
            // 
            this.manufactorTableAdapter.ClearBeforeFill = true;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.lIGHT_MEASURE1DataSet;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_CurrentValues
            // 
            this.tabPage_CurrentValues.Controls.Add(this.chart2);
            this.tabPage_CurrentValues.Controls.Add(this.buttonSaveScaled);
            this.tabPage_CurrentValues.Controls.Add(this.buttonSaveChart);
            this.tabPage_CurrentValues.Controls.Add(this.listBoxScaled);
            this.tabPage_CurrentValues.Controls.Add(this.checkBoxRawVals);
            this.tabPage_CurrentValues.Controls.Add(this.checkBoxScaledVals);
            this.tabPage_CurrentValues.Controls.Add(this.label12);
            this.tabPage_CurrentValues.Controls.Add(this.label11);
            this.tabPage_CurrentValues.Controls.Add(this.buttonSaveCsv);
            this.tabPage_CurrentValues.Controls.Add(this.buttonStopAuto);
            this.tabPage_CurrentValues.Controls.Add(this.buttonStartAuto);
            this.tabPage_CurrentValues.Controls.Add(this.listBoxRaw);
            this.tabPage_CurrentValues.Controls.Add(this.chart1);
            this.tabPage_CurrentValues.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CurrentValues.Name = "tabPage_CurrentValues";
            this.tabPage_CurrentValues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CurrentValues.Size = new System.Drawing.Size(792, 468);
            this.tabPage_CurrentValues.TabIndex = 2;
            this.tabPage_CurrentValues.Text = "Current Values";
            this.tabPage_CurrentValues.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(400, 17);
            this.chart2.Name = "chart2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Scaled data";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(363, 306);
            this.chart2.TabIndex = 501;
            this.chart2.TabStop = false;
            this.chart2.Text = "chart2";
            title2.DockedToChartArea = "ChartArea1";
            title2.Name = "Title1";
            this.chart2.Titles.Add(title2);
            // 
            // buttonSaveScaled
            // 
            this.buttonSaveScaled.Location = new System.Drawing.Point(319, 70);
            this.buttonSaveScaled.Name = "buttonSaveScaled";
            this.buttonSaveScaled.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveScaled.TabIndex = 5;
            this.buttonSaveScaled.Text = "Save scaled values";
            this.buttonSaveScaled.UseVisualStyleBackColor = true;
            this.buttonSaveScaled.Click += new System.EventHandler(this.buttonSaveScaled_Click);
            // 
            // buttonSaveChart
            // 
            this.buttonSaveChart.Location = new System.Drawing.Point(167, 223);
            this.buttonSaveChart.Name = "buttonSaveChart";
            this.buttonSaveChart.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveChart.TabIndex = 4;
            this.buttonSaveChart.Text = "Save chart";
            this.buttonSaveChart.UseVisualStyleBackColor = true;
            this.buttonSaveChart.Click += new System.EventHandler(this.buttonSaveChart_Click);
            // 
            // listBoxScaled
            // 
            this.listBoxScaled.FormatString = "N2";
            this.listBoxScaled.FormattingEnabled = true;
            this.listBoxScaled.Location = new System.Drawing.Point(235, 33);
            this.listBoxScaled.Name = "listBoxScaled";
            this.listBoxScaled.Size = new System.Drawing.Size(78, 95);
            this.listBoxScaled.TabIndex = 22;
            this.listBoxScaled.TabStop = false;
            // 
            // checkBoxRawVals
            // 
            this.checkBoxRawVals.AutoSize = true;
            this.checkBoxRawVals.Location = new System.Drawing.Point(110, 134);
            this.checkBoxRawVals.Name = "checkBoxRawVals";
            this.checkBoxRawVals.Size = new System.Drawing.Size(82, 17);
            this.checkBoxRawVals.TabIndex = 0;
            this.checkBoxRawVals.Text = "Raw values";
            this.checkBoxRawVals.UseVisualStyleBackColor = true;
            // 
            // checkBoxScaledVals
            // 
            this.checkBoxScaledVals.AutoSize = true;
            this.checkBoxScaledVals.Location = new System.Drawing.Point(235, 134);
            this.checkBoxScaledVals.Name = "checkBoxScaledVals";
            this.checkBoxScaledVals.Size = new System.Drawing.Size(93, 17);
            this.checkBoxScaledVals.TabIndex = 1;
            this.checkBoxScaledVals.Text = "Scaled values";
            this.checkBoxScaledVals.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Raw values";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(232, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Scaled values";
            // 
            // buttonSaveCsv
            // 
            this.buttonSaveCsv.Location = new System.Drawing.Point(31, 70);
            this.buttonSaveCsv.Name = "buttonSaveCsv";
            this.buttonSaveCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCsv.TabIndex = 6;
            this.buttonSaveCsv.Text = "Save raw values";
            this.buttonSaveCsv.UseVisualStyleBackColor = true;
            this.buttonSaveCsv.Click += new System.EventHandler(this.buttonSaveCsv_Click);
            // 
            // buttonStopAuto
            // 
            this.buttonStopAuto.Location = new System.Drawing.Point(167, 194);
            this.buttonStopAuto.Name = "buttonStopAuto";
            this.buttonStopAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAuto.TabIndex = 3;
            this.buttonStopAuto.Text = "Stop";
            this.buttonStopAuto.UseVisualStyleBackColor = true;
            this.buttonStopAuto.Click += new System.EventHandler(this.buttonStopAuto_Click);
            // 
            // buttonStartAuto
            // 
            this.buttonStartAuto.Location = new System.Drawing.Point(167, 165);
            this.buttonStartAuto.Name = "buttonStartAuto";
            this.buttonStartAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAuto.TabIndex = 2;
            this.buttonStartAuto.Text = "Start Auto";
            this.buttonStartAuto.UseVisualStyleBackColor = true;
            this.buttonStartAuto.Click += new System.EventHandler(this.buttonStartAuto_Click);
            // 
            // listBoxRaw
            // 
            this.listBoxRaw.FormattingEnabled = true;
            this.listBoxRaw.Location = new System.Drawing.Point(112, 33);
            this.listBoxRaw.Name = "listBoxRaw";
            this.listBoxRaw.Size = new System.Drawing.Size(80, 95);
            this.listBoxRaw.TabIndex = 500;
            this.listBoxRaw.TabStop = false;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(400, 17);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 10;
            series4.Name = "Raw data";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(363, 300);
            this.chart1.TabIndex = 0;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // tabPage_InstrumentConfig
            // 
            this.tabPage_InstrumentConfig.Controls.Add(this.comboBoxManufactor);
            this.tabPage_InstrumentConfig.Controls.Add(this.comboBoxDevice);
            this.tabPage_InstrumentConfig.Controls.Add(computer_IdLabel);
            this.tabPage_InstrumentConfig.Controls.Add(manufactor_IdLabel);
            this.tabPage_InstrumentConfig.Controls.Add(this.comboBoxArea);
            this.tabPage_InstrumentConfig.Controls.Add(area_numberLabel);
            this.tabPage_InstrumentConfig.Controls.Add(this.label14);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxUnit);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxDescription);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxUpdateFrequency);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxReadVals);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxLRV);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxURV);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxAlarmLow);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxAlarmHigh);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxTagName);
            this.tabPage_InstrumentConfig.Controls.Add(this.label13);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonSave2DB);
            this.tabPage_InstrumentConfig.Controls.Add(this.label10);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonWrite2Device);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonLoadFromFile);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonReadStatus);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonReadData);
            this.tabPage_InstrumentConfig.Controls.Add(this.label7);
            this.tabPage_InstrumentConfig.Controls.Add(this.label6);
            this.tabPage_InstrumentConfig.Controls.Add(this.label5);
            this.tabPage_InstrumentConfig.Controls.Add(this.label4);
            this.tabPage_InstrumentConfig.Controls.Add(this.label3);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonSaveConfig2File);
            this.tabPage_InstrumentConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_InstrumentConfig.Name = "tabPage_InstrumentConfig";
            this.tabPage_InstrumentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_InstrumentConfig.Size = new System.Drawing.Size(792, 468);
            this.tabPage_InstrumentConfig.TabIndex = 1;
            this.tabPage_InstrumentConfig.Text = "Instrument Configuration";
            this.tabPage_InstrumentConfig.UseVisualStyleBackColor = true;
            // 
            // comboBoxManufactor
            // 
            this.comboBoxManufactor.DataSource = this.manufactorBindingSource;
            this.comboBoxManufactor.DisplayMember = "Name";
            this.comboBoxManufactor.FormattingEnabled = true;
            this.comboBoxManufactor.Location = new System.Drawing.Point(234, 313);
            this.comboBoxManufactor.Name = "comboBoxManufactor";
            this.comboBoxManufactor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxManufactor.TabIndex = 14;
            this.comboBoxManufactor.ValueMember = "Manufactor_Id";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.DataSource = this.deviceBindingSource;
            this.comboBoxDevice.DisplayMember = "Description";
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(234, 346);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDevice.TabIndex = 15;
            this.comboBoxDevice.ValueMember = "Device_Id";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.DataSource = this.areaBindingSource;
            this.comboBoxArea.DisplayMember = "Description";
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(234, 283);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(100, 21);
            this.comboBoxArea.TabIndex = 13;
            this.comboBoxArea.ValueMember = "Area_number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(121, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 510;
            this.label14.Text = "Measurement unit";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(234, 229);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnit.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(234, 203);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // textBoxUpdateFrequency
            // 
            this.textBoxUpdateFrequency.Location = new System.Drawing.Point(234, 255);
            this.textBoxUpdateFrequency.Name = "textBoxUpdateFrequency";
            this.textBoxUpdateFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateFrequency.TabIndex = 12;
            // 
            // textBoxReadVals
            // 
            this.textBoxReadVals.Location = new System.Drawing.Point(373, 63);
            this.textBoxReadVals.Multiline = true;
            this.textBoxReadVals.Name = "textBoxReadVals";
            this.textBoxReadVals.ReadOnly = true;
            this.textBoxReadVals.Size = new System.Drawing.Size(141, 124);
            this.textBoxReadVals.TabIndex = 15;
            this.textBoxReadVals.TabStop = false;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(234, 78);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxLRV.TabIndex = 6;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(234, 111);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(100, 20);
            this.textBoxURV.TabIndex = 7;
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.Location = new System.Drawing.Point(234, 144);
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmLow.TabIndex = 8;
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(234, 177);
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmHigh.TabIndex = 9;
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(234, 45);
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTagName.TabIndex = 5;
            this.textBoxTagName.MouseHover += new System.EventHandler(this.textBoxTagName_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(157, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 507;
            this.label13.Text = "Description";
            // 
            // buttonSave2DB
            // 
            this.buttonSave2DB.Location = new System.Drawing.Point(373, 311);
            this.buttonSave2DB.Name = "buttonSave2DB";
            this.buttonSave2DB.Size = new System.Drawing.Size(170, 23);
            this.buttonSave2DB.TabIndex = 4;
            this.buttonSave2DB.Text = "Add/Update instrument to DB";
            this.buttonSave2DB.UseVisualStyleBackColor = true;
            this.buttonSave2DB.Click += new System.EventHandler(this.buttonSave2DB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 504;
            this.label10.Text = "Update frequency [s]";
            // 
            // buttonWrite2Device
            // 
            this.buttonWrite2Device.Location = new System.Drawing.Point(373, 223);
            this.buttonWrite2Device.Name = "buttonWrite2Device";
            this.buttonWrite2Device.Size = new System.Drawing.Size(170, 23);
            this.buttonWrite2Device.TabIndex = 0;
            this.buttonWrite2Device.Text = "Write to device";
            this.buttonWrite2Device.UseVisualStyleBackColor = true;
            this.buttonWrite2Device.Click += new System.EventHandler(this.buttonWrite2Device_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(520, 81);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(74, 23);
            this.buttonLoadFromFile.TabIndex = 46;
            this.buttonLoadFromFile.Text = "Load file";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // buttonReadStatus
            // 
            this.buttonReadStatus.Location = new System.Drawing.Point(373, 281);
            this.buttonReadStatus.Name = "buttonReadStatus";
            this.buttonReadStatus.Size = new System.Drawing.Size(170, 23);
            this.buttonReadStatus.TabIndex = 3;
            this.buttonReadStatus.Text = "Read status";
            this.buttonReadStatus.UseVisualStyleBackColor = true;
            this.buttonReadStatus.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReadData
            // 
            this.buttonReadData.Location = new System.Drawing.Point(373, 252);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(170, 23);
            this.buttonReadData.TabIndex = 2;
            this.buttonReadData.Text = "Read Config";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Alarm high";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alarm low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Upper Range Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lower Range Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // buttonSaveConfig2File
            // 
            this.buttonSaveConfig2File.Location = new System.Drawing.Point(520, 114);
            this.buttonSaveConfig2File.Name = "buttonSaveConfig2File";
            this.buttonSaveConfig2File.Size = new System.Drawing.Size(74, 23);
            this.buttonSaveConfig2File.TabIndex = 4;
            this.buttonSaveConfig2File.Text = "Save to file";
            this.buttonSaveConfig2File.UseVisualStyleBackColor = true;
            this.buttonSaveConfig2File.Click += new System.EventHandler(this.buttonSaveConfig2File_Click);
            // 
            // tabPage_SerialPortConfig
            // 
            this.tabPage_SerialPortConfig.Controls.Add(this.buttonAbout);
            this.tabPage_SerialPortConfig.Controls.Add(this.buttonConnect);
            this.tabPage_SerialPortConfig.Controls.Add(this.buttonDisconnect);
            this.tabPage_SerialPortConfig.Controls.Add(this.label2);
            this.tabPage_SerialPortConfig.Controls.Add(this.label1);
            this.tabPage_SerialPortConfig.Controls.Add(this.comboBox_BitRate);
            this.tabPage_SerialPortConfig.Controls.Add(this.comboBox_ComPorts);
            this.tabPage_SerialPortConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SerialPortConfig.Name = "tabPage_SerialPortConfig";
            this.tabPage_SerialPortConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SerialPortConfig.Size = new System.Drawing.Size(792, 468);
            this.tabPage_SerialPortConfig.TabIndex = 0;
            this.tabPage_SerialPortConfig.Text = "Serial Port Configuration";
            this.tabPage_SerialPortConfig.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(452, 27);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(152, 128);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(152, 167);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select port for device";
            // 
            // comboBox_BitRate
            // 
            this.comboBox_BitRate.FormattingEnabled = true;
            this.comboBox_BitRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800",
            "153600"});
            this.comboBox_BitRate.Location = new System.Drawing.Point(221, 73);
            this.comboBox_BitRate.Name = "comboBox_BitRate";
            this.comboBox_BitRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BitRate.TabIndex = 1;
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM7"});
            this.comboBox_ComPorts.Location = new System.Drawing.Point(37, 73);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ComPorts.TabIndex = 0;
            this.comboBox_ComPorts.Enter += new System.EventHandler(this.comboBox_ComPorts_Enter);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage_SerialPortConfig);
            this.tabControlMain.Controls.Add(this.tabPage_InstrumentConfig);
            this.tabControlMain.Controls.Add(this.tabPage_CurrentValues);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 494);
            this.tabControlMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "SoftSenseConf";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGHT_MEASURE1DataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMeasureAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGHT_MEASURE1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstrumentCinfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.tabPage_CurrentValues.ResumeLayout(false);
            this.tabPage_CurrentValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage_InstrumentConfig.ResumeLayout(false);
            this.tabPage_InstrumentConfig.PerformLayout();
            this.tabPage_SerialPortConfig.ResumeLayout(false);
            this.tabPage_SerialPortConfig.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerChartadd;
        private System.Windows.Forms.Timer timerSerialRecieve;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCsv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timerChartScaled;
        private System.Windows.Forms.Timer timerRecievedScaled;
        private System.Windows.Forms.Timer timerWrite2Device;
        private System.Windows.Forms.SaveFileDialog saveFileDialogChart;
        private System.Windows.Forms.SaveFileDialog saveFileDialogScaled;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LIGHT_MEASURE1DataSet lIGHT_MEASURE1DataSet;
        private LIGHT_MEASURE1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSourceMeasureAI;
        private LIGHT_MEASURE1DataSet1 lIGHT_MEASURE1DataSet1;
        private System.Windows.Forms.BindingSource bindingSourceInstrumentCinfig;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatusRead;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private LIGHT_MEASURE1DataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource manufactorBindingSource;
        private LIGHT_MEASURE1DataSetTableAdapters.ManufactorTableAdapter manufactorTableAdapter;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private LIGHT_MEASURE1DataSetTableAdapters.DeviceTableAdapter deviceTableAdapter;
        private System.Windows.Forms.TabPage tabPage_CurrentValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonSaveScaled;
        private System.Windows.Forms.Button buttonSaveChart;
        private System.Windows.Forms.ListBox listBoxScaled;
        private System.Windows.Forms.CheckBox checkBoxRawVals;
        private System.Windows.Forms.CheckBox checkBoxScaledVals;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSaveCsv;
        private System.Windows.Forms.Button buttonStopAuto;
        private System.Windows.Forms.Button buttonStartAuto;
        private System.Windows.Forms.ListBox listBoxRaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage_InstrumentConfig;
        private System.Windows.Forms.ComboBox comboBoxManufactor;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxUpdateFrequency;
        private System.Windows.Forms.TextBox textBoxReadVals;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxAlarmLow;
        private System.Windows.Forms.TextBox textBoxAlarmHigh;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSave2DB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonWrite2Device;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonReadStatus;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveConfig2File;
        private System.Windows.Forms.TabPage tabPage_SerialPortConfig;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BitRate;
        private System.Windows.Forms.ComboBox comboBox_ComPorts;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

