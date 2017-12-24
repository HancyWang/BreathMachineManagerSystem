namespace BreathingMachine
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模式选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程师模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_TimeSet = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label_endTime = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.dateTimePicker_Begin = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_BasicInfo = new System.Windows.Forms.TabPage();
            this.groupBox_workingParam = new System.Windows.Forms.GroupBox();
            this.label_setAdaultChild_Value = new System.Windows.Forms.Label();
            this.label_setAtomizTime_Value = new System.Windows.Forms.Label();
            this.label_setAtmoizLevel_Value = new System.Windows.Forms.Label();
            this.label_setAdaultChild = new System.Windows.Forms.Label();
            this.label_setAtomizTime = new System.Windows.Forms.Label();
            this.label_setHighOxyContAlarm_Value = new System.Windows.Forms.Label();
            this.label_setAtmoizLevel = new System.Windows.Forms.Label();
            this.label_setLowOxyContAlarm = new System.Windows.Forms.Label();
            this.label_setLowOxyContAlarm_Value = new System.Windows.Forms.Label();
            this.label_setHighOxyContAlarm = new System.Windows.Forms.Label();
            this.label_setFlow_Value = new System.Windows.Forms.Label();
            this.label_setTmp_Value = new System.Windows.Forms.Label();
            this.label_setFlow = new System.Windows.Forms.Label();
            this.label_setTmp = new System.Windows.Forms.Label();
            this.label_runningMode_value = new System.Windows.Forms.Label();
            this.label_runningMode = new System.Windows.Forms.Label();
            this.groupBox_time = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_dateTo_Value = new System.Windows.Forms.Label();
            this.label_dateFrom_Value = new System.Windows.Forms.Label();
            this.groupBox_equipInfo = new System.Windows.Forms.GroupBox();
            this.label_SN_Value = new System.Windows.Forms.Label();
            this.label_softwarVer_Value = new System.Windows.Forms.Label();
            this.label_equipType_Value = new System.Windows.Forms.Label();
            this.label_SN = new System.Windows.Forms.Label();
            this.label_softwarVer = new System.Windows.Forms.Label();
            this.label_equipType = new System.Windows.Forms.Label();
            this.tabPage_workDataChart = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_workData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_alarmList = new System.Windows.Forms.TabPage();
            this.listView_alarmInfo = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RunningMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlarmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlarmInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlarmData1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlarmData2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_workdatalist = new System.Windows.Forms.TabPage();
            this.listView_workData = new System.Windows.Forms.ListView();
            this._No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._runningmode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_tmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_flow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_highOxyAlarm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_lowOxyAlarm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_AtomizLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_AtomizTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._set_adaultChild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_patientTmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_airOutletTmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_heatingPlateTmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_EnvTmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_DriveBoardTmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_flow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_OxyContentration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_airPressure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_loopType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._data_alarmState12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog_selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_saveFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.groupBox_TimeSet.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_BasicInfo.SuspendLayout();
            this.groupBox_workingParam.SuspendLayout();
            this.groupBox_time.SuspendLayout();
            this.groupBox_equipInfo.SuspendLayout();
            this.tabPage_workDataChart.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_workData)).BeginInit();
            this.tabPage_alarmList.SuspendLayout();
            this.tabPage_workdatalist.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.模式选择ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(965, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言设置ToolStripMenuItem,
            this.导入数据ToolStripMenuItem,
            this.导出数据ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 语言设置ToolStripMenuItem
            // 
            this.语言设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.语言设置ToolStripMenuItem.Name = "语言设置ToolStripMenuItem";
            this.语言设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.语言设置ToolStripMenuItem.Text = "语言设置";
            this.语言设置ToolStripMenuItem.Click += new System.EventHandler(this.语言ToolStripMenuItem_Click);
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // 英文ToolStripMenuItem
            // 
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.英文ToolStripMenuItem.Text = "英文";
            this.英文ToolStripMenuItem.Click += new System.EventHandler(this.英文ToolStripMenuItem_Click);
            // 
            // 导入数据ToolStripMenuItem
            // 
            this.导入数据ToolStripMenuItem.Name = "导入数据ToolStripMenuItem";
            this.导入数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入数据ToolStripMenuItem.Text = "导入数据";
            this.导入数据ToolStripMenuItem.Click += new System.EventHandler(this.导入数据ToolStripMenuItem_Click);
            // 
            // 导出数据ToolStripMenuItem
            // 
            this.导出数据ToolStripMenuItem.Name = "导出数据ToolStripMenuItem";
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出数据ToolStripMenuItem.Text = "导出数据";
            this.导出数据ToolStripMenuItem.Click += new System.EventHandler(this.导出数据ToolStripMenuItem_Click);
            // 
            // 模式选择ToolStripMenuItem
            // 
            this.模式选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户模式ToolStripMenuItem,
            this.工程师模式ToolStripMenuItem});
            this.模式选择ToolStripMenuItem.Name = "模式选择ToolStripMenuItem";
            this.模式选择ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.模式选择ToolStripMenuItem.Text = "模式选择";
            // 
            // 用户模式ToolStripMenuItem
            // 
            this.用户模式ToolStripMenuItem.Name = "用户模式ToolStripMenuItem";
            this.用户模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.用户模式ToolStripMenuItem.Text = "用户模式";
            this.用户模式ToolStripMenuItem.Click += new System.EventHandler(this.用户模式ToolStripMenuItem_Click);
            // 
            // 工程师模式ToolStripMenuItem
            // 
            this.工程师模式ToolStripMenuItem.Name = "工程师模式ToolStripMenuItem";
            this.工程师模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.工程师模式ToolStripMenuItem.Text = "工程师模式";
            this.工程师模式ToolStripMenuItem.Click += new System.EventHandler(this.工程师模式ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.软件版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 软件版本ToolStripMenuItem
            // 
            this.软件版本ToolStripMenuItem.Name = "软件版本ToolStripMenuItem";
            this.软件版本ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.软件版本ToolStripMenuItem.Text = "软件版本";
            // 
            // groupBox_TimeSet
            // 
            this.groupBox_TimeSet.Controls.Add(this.dateTimePicker_End);
            this.groupBox_TimeSet.Controls.Add(this.label_endTime);
            this.groupBox_TimeSet.Controls.Add(this.label_startTime);
            this.groupBox_TimeSet.Controls.Add(this.dateTimePicker_Begin);
            this.groupBox_TimeSet.Location = new System.Drawing.Point(3, 3);
            this.groupBox_TimeSet.Name = "groupBox_TimeSet";
            this.groupBox_TimeSet.Size = new System.Drawing.Size(177, 159);
            this.groupBox_TimeSet.TabIndex = 1;
            this.groupBox_TimeSet.TabStop = false;
            this.groupBox_TimeSet.Text = "时段设置";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(7, 126);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(164, 21);
            this.dateTimePicker_End.TabIndex = 3;
            this.dateTimePicker_End.ValueChanged += new System.EventHandler(this.dateTimePicker_End_ValueChanged);
            // 
            // label_endTime
            // 
            this.label_endTime.AutoSize = true;
            this.label_endTime.Location = new System.Drawing.Point(6, 104);
            this.label_endTime.Name = "label_endTime";
            this.label_endTime.Size = new System.Drawing.Size(65, 12);
            this.label_endTime.TabIndex = 2;
            this.label_endTime.Text = "结束时间：";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Location = new System.Drawing.Point(5, 35);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(65, 12);
            this.label_startTime.TabIndex = 1;
            this.label_startTime.Text = "开始时间：";
            // 
            // dateTimePicker_Begin
            // 
            this.dateTimePicker_Begin.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Begin.Location = new System.Drawing.Point(6, 57);
            this.dateTimePicker_Begin.Name = "dateTimePicker_Begin";
            this.dateTimePicker_Begin.Size = new System.Drawing.Size(165, 21);
            this.dateTimePicker_Begin.TabIndex = 0;
            this.dateTimePicker_Begin.ValueChanged += new System.EventHandler(this.dateTimePicker_Begin_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_BasicInfo);
            this.tabControl1.Controls.Add(this.tabPage_workDataChart);
            this.tabControl1.Controls.Add(this.tabPage_alarmList);
            this.tabControl1.Controls.Add(this.tabPage_workdatalist);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 418);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_BasicInfo
            // 
            this.tabPage_BasicInfo.Controls.Add(this.groupBox_workingParam);
            this.tabPage_BasicInfo.Controls.Add(this.groupBox_time);
            this.tabPage_BasicInfo.Controls.Add(this.groupBox_equipInfo);
            this.tabPage_BasicInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BasicInfo.Name = "tabPage_BasicInfo";
            this.tabPage_BasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BasicInfo.Size = new System.Drawing.Size(762, 392);
            this.tabPage_BasicInfo.TabIndex = 0;
            this.tabPage_BasicInfo.Text = "基本信息";
            this.tabPage_BasicInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox_workingParam
            // 
            this.groupBox_workingParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_workingParam.Controls.Add(this.label_setAdaultChild_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setAtomizTime_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setAtmoizLevel_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setAdaultChild);
            this.groupBox_workingParam.Controls.Add(this.label_setAtomizTime);
            this.groupBox_workingParam.Controls.Add(this.label_setHighOxyContAlarm_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setAtmoizLevel);
            this.groupBox_workingParam.Controls.Add(this.label_setLowOxyContAlarm);
            this.groupBox_workingParam.Controls.Add(this.label_setLowOxyContAlarm_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setHighOxyContAlarm);
            this.groupBox_workingParam.Controls.Add(this.label_setFlow_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setTmp_Value);
            this.groupBox_workingParam.Controls.Add(this.label_setFlow);
            this.groupBox_workingParam.Controls.Add(this.label_setTmp);
            this.groupBox_workingParam.Controls.Add(this.label_runningMode_value);
            this.groupBox_workingParam.Controls.Add(this.label_runningMode);
            this.groupBox_workingParam.Location = new System.Drawing.Point(3, 176);
            this.groupBox_workingParam.Name = "groupBox_workingParam";
            this.groupBox_workingParam.Size = new System.Drawing.Size(753, 155);
            this.groupBox_workingParam.TabIndex = 3;
            this.groupBox_workingParam.TabStop = false;
            this.groupBox_workingParam.Text = "工作参数：";
            // 
            // label_setAdaultChild_Value
            // 
            this.label_setAdaultChild_Value.AutoSize = true;
            this.label_setAdaultChild_Value.Location = new System.Drawing.Point(654, 109);
            this.label_setAdaultChild_Value.Name = "label_setAdaultChild_Value";
            this.label_setAdaultChild_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setAdaultChild_Value.TabIndex = 16;
            this.label_setAdaultChild_Value.Text = "NA";
            // 
            // label_setAtomizTime_Value
            // 
            this.label_setAtomizTime_Value.AutoSize = true;
            this.label_setAtomizTime_Value.Location = new System.Drawing.Point(654, 82);
            this.label_setAtomizTime_Value.Name = "label_setAtomizTime_Value";
            this.label_setAtomizTime_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setAtomizTime_Value.TabIndex = 15;
            this.label_setAtomizTime_Value.Text = "NA";
            // 
            // label_setAtmoizLevel_Value
            // 
            this.label_setAtmoizLevel_Value.AutoSize = true;
            this.label_setAtmoizLevel_Value.Location = new System.Drawing.Point(654, 55);
            this.label_setAtmoizLevel_Value.Name = "label_setAtmoizLevel_Value";
            this.label_setAtmoizLevel_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setAtmoizLevel_Value.TabIndex = 14;
            this.label_setAtmoizLevel_Value.Text = "NA";
            // 
            // label_setAdaultChild
            // 
            this.label_setAdaultChild.AutoSize = true;
            this.label_setAdaultChild.Location = new System.Drawing.Point(433, 109);
            this.label_setAdaultChild.Name = "label_setAdaultChild";
            this.label_setAdaultChild.Size = new System.Drawing.Size(113, 12);
            this.label_setAdaultChild.TabIndex = 13;
            this.label_setAdaultChild.Text = "设定成人儿童模式：";
            // 
            // label_setAtomizTime
            // 
            this.label_setAtomizTime.AutoSize = true;
            this.label_setAtomizTime.Location = new System.Drawing.Point(433, 82);
            this.label_setAtomizTime.Name = "label_setAtomizTime";
            this.label_setAtomizTime.Size = new System.Drawing.Size(89, 12);
            this.label_setAtomizTime.TabIndex = 12;
            this.label_setAtomizTime.Text = "设定雾化时间：";
            // 
            // label_setHighOxyContAlarm_Value
            // 
            this.label_setHighOxyContAlarm_Value.AutoSize = true;
            this.label_setHighOxyContAlarm_Value.Location = new System.Drawing.Point(228, 109);
            this.label_setHighOxyContAlarm_Value.Name = "label_setHighOxyContAlarm_Value";
            this.label_setHighOxyContAlarm_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setHighOxyContAlarm_Value.TabIndex = 11;
            this.label_setHighOxyContAlarm_Value.Text = "NA";
            // 
            // label_setAtmoizLevel
            // 
            this.label_setAtmoizLevel.AutoSize = true;
            this.label_setAtmoizLevel.Location = new System.Drawing.Point(433, 55);
            this.label_setAtmoizLevel.Name = "label_setAtmoizLevel";
            this.label_setAtmoizLevel.Size = new System.Drawing.Size(89, 12);
            this.label_setAtmoizLevel.TabIndex = 10;
            this.label_setAtmoizLevel.Text = "设定雾化档位：";
            // 
            // label_setLowOxyContAlarm
            // 
            this.label_setLowOxyContAlarm.AutoSize = true;
            this.label_setLowOxyContAlarm.Location = new System.Drawing.Point(433, 25);
            this.label_setLowOxyContAlarm.Name = "label_setLowOxyContAlarm";
            this.label_setLowOxyContAlarm.Size = new System.Drawing.Size(113, 12);
            this.label_setLowOxyContAlarm.TabIndex = 9;
            this.label_setLowOxyContAlarm.Text = "设定低氧浓度报警：";
            // 
            // label_setLowOxyContAlarm_Value
            // 
            this.label_setLowOxyContAlarm_Value.AutoSize = true;
            this.label_setLowOxyContAlarm_Value.Location = new System.Drawing.Point(654, 25);
            this.label_setLowOxyContAlarm_Value.Name = "label_setLowOxyContAlarm_Value";
            this.label_setLowOxyContAlarm_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setLowOxyContAlarm_Value.TabIndex = 8;
            this.label_setLowOxyContAlarm_Value.Text = "NA";
            // 
            // label_setHighOxyContAlarm
            // 
            this.label_setHighOxyContAlarm.AutoSize = true;
            this.label_setHighOxyContAlarm.Location = new System.Drawing.Point(9, 109);
            this.label_setHighOxyContAlarm.Name = "label_setHighOxyContAlarm";
            this.label_setHighOxyContAlarm.Size = new System.Drawing.Size(113, 12);
            this.label_setHighOxyContAlarm.TabIndex = 7;
            this.label_setHighOxyContAlarm.Text = "设定高氧浓度报警：";
            // 
            // label_setFlow_Value
            // 
            this.label_setFlow_Value.AutoSize = true;
            this.label_setFlow_Value.Location = new System.Drawing.Point(227, 82);
            this.label_setFlow_Value.Name = "label_setFlow_Value";
            this.label_setFlow_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setFlow_Value.TabIndex = 6;
            this.label_setFlow_Value.Text = "NA";
            // 
            // label_setTmp_Value
            // 
            this.label_setTmp_Value.AutoSize = true;
            this.label_setTmp_Value.Location = new System.Drawing.Point(227, 55);
            this.label_setTmp_Value.Name = "label_setTmp_Value";
            this.label_setTmp_Value.Size = new System.Drawing.Size(17, 12);
            this.label_setTmp_Value.TabIndex = 5;
            this.label_setTmp_Value.Text = "NA";
            // 
            // label_setFlow
            // 
            this.label_setFlow.AutoSize = true;
            this.label_setFlow.Location = new System.Drawing.Point(9, 82);
            this.label_setFlow.Name = "label_setFlow";
            this.label_setFlow.Size = new System.Drawing.Size(65, 12);
            this.label_setFlow.TabIndex = 4;
            this.label_setFlow.Text = "设定流量：";
            // 
            // label_setTmp
            // 
            this.label_setTmp.AutoSize = true;
            this.label_setTmp.Location = new System.Drawing.Point(9, 55);
            this.label_setTmp.Name = "label_setTmp";
            this.label_setTmp.Size = new System.Drawing.Size(65, 12);
            this.label_setTmp.TabIndex = 3;
            this.label_setTmp.Text = "设定温度：";
            // 
            // label_runningMode_value
            // 
            this.label_runningMode_value.AutoSize = true;
            this.label_runningMode_value.Location = new System.Drawing.Point(227, 25);
            this.label_runningMode_value.Name = "label_runningMode_value";
            this.label_runningMode_value.Size = new System.Drawing.Size(17, 12);
            this.label_runningMode_value.TabIndex = 1;
            this.label_runningMode_value.Text = "NA";
            // 
            // label_runningMode
            // 
            this.label_runningMode.AutoSize = true;
            this.label_runningMode.Location = new System.Drawing.Point(9, 25);
            this.label_runningMode.Name = "label_runningMode";
            this.label_runningMode.Size = new System.Drawing.Size(65, 12);
            this.label_runningMode.TabIndex = 0;
            this.label_runningMode.Text = "运行模式：";
            // 
            // groupBox_time
            // 
            this.groupBox_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_time.Controls.Add(this.label5);
            this.groupBox_time.Controls.Add(this.label_dateTo_Value);
            this.groupBox_time.Controls.Add(this.label_dateFrom_Value);
            this.groupBox_time.Location = new System.Drawing.Point(4, 110);
            this.groupBox_time.Name = "groupBox_time";
            this.groupBox_time.Size = new System.Drawing.Size(759, 57);
            this.groupBox_time.TabIndex = 2;
            this.groupBox_time.TabStop = false;
            this.groupBox_time.Text = "使用时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "---";
            // 
            // label_dateTo_Value
            // 
            this.label_dateTo_Value.AutoSize = true;
            this.label_dateTo_Value.Location = new System.Drawing.Point(432, 31);
            this.label_dateTo_Value.Name = "label_dateTo_Value";
            this.label_dateTo_Value.Size = new System.Drawing.Size(17, 12);
            this.label_dateTo_Value.TabIndex = 1;
            this.label_dateTo_Value.Text = "NA";
            // 
            // label_dateFrom_Value
            // 
            this.label_dateFrom_Value.AutoSize = true;
            this.label_dateFrom_Value.Location = new System.Drawing.Point(168, 31);
            this.label_dateFrom_Value.Name = "label_dateFrom_Value";
            this.label_dateFrom_Value.Size = new System.Drawing.Size(17, 12);
            this.label_dateFrom_Value.TabIndex = 0;
            this.label_dateFrom_Value.Text = "NA";
            // 
            // groupBox_equipInfo
            // 
            this.groupBox_equipInfo.Controls.Add(this.label_SN_Value);
            this.groupBox_equipInfo.Controls.Add(this.label_softwarVer_Value);
            this.groupBox_equipInfo.Controls.Add(this.label_equipType_Value);
            this.groupBox_equipInfo.Controls.Add(this.label_SN);
            this.groupBox_equipInfo.Controls.Add(this.label_softwarVer);
            this.groupBox_equipInfo.Controls.Add(this.label_equipType);
            this.groupBox_equipInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_equipInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBox_equipInfo.Name = "groupBox_equipInfo";
            this.groupBox_equipInfo.Size = new System.Drawing.Size(756, 91);
            this.groupBox_equipInfo.TabIndex = 0;
            this.groupBox_equipInfo.TabStop = false;
            this.groupBox_equipInfo.Text = "设备信息：";
            // 
            // label_SN_Value
            // 
            this.label_SN_Value.AutoSize = true;
            this.label_SN_Value.Location = new System.Drawing.Point(505, 41);
            this.label_SN_Value.Name = "label_SN_Value";
            this.label_SN_Value.Size = new System.Drawing.Size(17, 12);
            this.label_SN_Value.TabIndex = 5;
            this.label_SN_Value.Text = "NA";
            // 
            // label_softwarVer_Value
            // 
            this.label_softwarVer_Value.AutoSize = true;
            this.label_softwarVer_Value.Location = new System.Drawing.Point(227, 57);
            this.label_softwarVer_Value.Name = "label_softwarVer_Value";
            this.label_softwarVer_Value.Size = new System.Drawing.Size(17, 12);
            this.label_softwarVer_Value.TabIndex = 4;
            this.label_softwarVer_Value.Text = "NA";
            // 
            // label_equipType_Value
            // 
            this.label_equipType_Value.AutoSize = true;
            this.label_equipType_Value.Location = new System.Drawing.Point(227, 29);
            this.label_equipType_Value.Name = "label_equipType_Value";
            this.label_equipType_Value.Size = new System.Drawing.Size(17, 12);
            this.label_equipType_Value.TabIndex = 3;
            this.label_equipType_Value.Text = "NA";
            // 
            // label_SN
            // 
            this.label_SN.AutoSize = true;
            this.label_SN.Location = new System.Drawing.Point(433, 41);
            this.label_SN.Name = "label_SN";
            this.label_SN.Size = new System.Drawing.Size(29, 12);
            this.label_SN.TabIndex = 2;
            this.label_SN.Text = "SN：";
            // 
            // label_softwarVer
            // 
            this.label_softwarVer.AutoSize = true;
            this.label_softwarVer.Location = new System.Drawing.Point(7, 57);
            this.label_softwarVer.Name = "label_softwarVer";
            this.label_softwarVer.Size = new System.Drawing.Size(65, 12);
            this.label_softwarVer.TabIndex = 1;
            this.label_softwarVer.Text = "软件版本：";
            // 
            // label_equipType
            // 
            this.label_equipType.AutoSize = true;
            this.label_equipType.Location = new System.Drawing.Point(7, 29);
            this.label_equipType.Name = "label_equipType";
            this.label_equipType.Size = new System.Drawing.Size(65, 12);
            this.label_equipType.TabIndex = 0;
            this.label_equipType.Text = "设备型号：";
            // 
            // tabPage_workDataChart
            // 
            this.tabPage_workDataChart.Controls.Add(this.panel2);
            this.tabPage_workDataChart.Location = new System.Drawing.Point(4, 22);
            this.tabPage_workDataChart.Name = "tabPage_workDataChart";
            this.tabPage_workDataChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_workDataChart.Size = new System.Drawing.Size(762, 392);
            this.tabPage_workDataChart.TabIndex = 1;
            this.tabPage_workDataChart.Text = "图表";
            this.tabPage_workDataChart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.chart_workData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 386);
            this.panel2.TabIndex = 1;
            // 
            // chart_workData
            // 
            chartArea1.AxisY.IsReversed = true;
            chartArea1.Name = "ChartArea1";
            this.chart_workData.ChartAreas.Add(chartArea1);
            this.chart_workData.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart_workData.Legends.Add(legend1);
            this.chart_workData.Location = new System.Drawing.Point(0, 0);
            this.chart_workData.Name = "chart_workData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Legend = "Legend1";
            series1.Name = "usage";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart_workData.Series.Add(series1);
            this.chart_workData.Size = new System.Drawing.Size(756, 233);
            this.chart_workData.TabIndex = 0;
            this.chart_workData.Text = "chart_usage";
            // 
            // tabPage_alarmList
            // 
            this.tabPage_alarmList.Controls.Add(this.listView_alarmInfo);
            this.tabPage_alarmList.Location = new System.Drawing.Point(4, 22);
            this.tabPage_alarmList.Name = "tabPage_alarmList";
            this.tabPage_alarmList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_alarmList.Size = new System.Drawing.Size(762, 392);
            this.tabPage_alarmList.TabIndex = 2;
            this.tabPage_alarmList.Text = "报警信息";
            this.tabPage_alarmList.UseVisualStyleBackColor = true;
            // 
            // listView_alarmInfo
            // 
            this.listView_alarmInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Date,
            this.RunningMode,
            this.AlarmCode,
            this.AlarmInfo,
            this.AlarmData1,
            this.AlarmData2});
            this.listView_alarmInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_alarmInfo.Location = new System.Drawing.Point(3, 3);
            this.listView_alarmInfo.Name = "listView_alarmInfo";
            this.listView_alarmInfo.Size = new System.Drawing.Size(756, 386);
            this.listView_alarmInfo.TabIndex = 0;
            this.listView_alarmInfo.UseCompatibleStateImageBehavior = false;
            this.listView_alarmInfo.VirtualMode = true;
            // 
            // No
            // 
            this.No.Text = "No.";
            // 
            // Date
            // 
            this.Date.Text = "时间";
            this.Date.Width = 180;
            // 
            // RunningMode
            // 
            this.RunningMode.Text = "运行模式";
            // 
            // AlarmCode
            // 
            this.AlarmCode.Text = "报警码";
            // 
            // AlarmInfo
            // 
            this.AlarmInfo.Text = "报警信息";
            this.AlarmInfo.Width = 180;
            // 
            // AlarmData1
            // 
            this.AlarmData1.Text = "报警数据1";
            // 
            // AlarmData2
            // 
            this.AlarmData2.Text = "报警数据2";
            // 
            // tabPage_workdatalist
            // 
            this.tabPage_workdatalist.Controls.Add(this.listView_workData);
            this.tabPage_workdatalist.Location = new System.Drawing.Point(4, 22);
            this.tabPage_workdatalist.Name = "tabPage_workdatalist";
            this.tabPage_workdatalist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_workdatalist.Size = new System.Drawing.Size(762, 392);
            this.tabPage_workdatalist.TabIndex = 3;
            this.tabPage_workdatalist.Text = "工作信息";
            this.tabPage_workdatalist.UseVisualStyleBackColor = true;
            // 
            // listView_workData
            // 
            this.listView_workData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._No,
            this._time,
            this._runningmode,
            this._set_tmp,
            this._set_flow,
            this._set_highOxyAlarm,
            this._set_lowOxyAlarm,
            this._set_AtomizLevel,
            this._set_AtomizTime,
            this._set_adaultChild,
            this._data_patientTmp,
            this._data_airOutletTmp,
            this._data_heatingPlateTmp,
            this._data_EnvTmp,
            this._data_DriveBoardTmp,
            this._data_flow,
            this._data_OxyContentration,
            this._data_airPressure,
            this._data_loopType,
            this._data_alarmState1,
            this._data_alarmState2,
            this._data_alarmState3,
            this._data_alarmState4,
            this._data_alarmState5,
            this._data_alarmState6,
            this._data_alarmState7,
            this._data_alarmState8,
            this._data_alarmState9,
            this._data_alarmState10,
            this._data_alarmState11,
            this._data_alarmState12});
            this.listView_workData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_workData.Location = new System.Drawing.Point(3, 3);
            this.listView_workData.Name = "listView_workData";
            this.listView_workData.Size = new System.Drawing.Size(756, 386);
            this.listView_workData.TabIndex = 0;
            this.listView_workData.UseCompatibleStateImageBehavior = false;
            this.listView_workData.VirtualMode = true;
            // 
            // _No
            // 
            this._No.Text = "No.";
            this._No.Width = 30;
            // 
            // _time
            // 
            this._time.Text = "日期";
            // 
            // _runningmode
            // 
            this._runningmode.Text = "运行模式";
            // 
            // _set_tmp
            // 
            this._set_tmp.Text = "设定温度";
            // 
            // _set_flow
            // 
            this._set_flow.Text = "设定流量";
            // 
            // _set_highOxyAlarm
            // 
            this._set_highOxyAlarm.Text = "设定高氧浓度报警";
            // 
            // _set_lowOxyAlarm
            // 
            this._set_lowOxyAlarm.Text = "设定低氧浓度报警";
            // 
            // _set_AtomizLevel
            // 
            this._set_AtomizLevel.Text = "设定雾化量档位";
            // 
            // _set_AtomizTime
            // 
            this._set_AtomizTime.Text = "设定雾化时间";
            // 
            // _set_adaultChild
            // 
            this._set_adaultChild.Text = "设定儿童成人模式";
            // 
            // _data_patientTmp
            // 
            this._data_patientTmp.Text = "患者端温度";
            // 
            // _data_airOutletTmp
            // 
            this._data_airOutletTmp.Text = "出气口温度";
            // 
            // _data_heatingPlateTmp
            // 
            this._data_heatingPlateTmp.Text = "加热盘温度";
            // 
            // _data_EnvTmp
            // 
            this._data_EnvTmp.Text = "环境温度";
            // 
            // _data_DriveBoardTmp
            // 
            this._data_DriveBoardTmp.Text = "驱动板温度";
            // 
            // _data_flow
            // 
            this._data_flow.Text = "流量";
            // 
            // _data_OxyContentration
            // 
            this._data_OxyContentration.Text = "氧浓度";
            // 
            // _data_airPressure
            // 
            this._data_airPressure.Text = "气道压力";
            // 
            // _data_loopType
            // 
            this._data_loopType.Text = "回路类型";
            // 
            // _data_alarmState1
            // 
            this._data_alarmState1.Text = "故障1";
            // 
            // _data_alarmState2
            // 
            this._data_alarmState2.Text = "故障2";
            // 
            // _data_alarmState3
            // 
            this._data_alarmState3.Text = "故障3";
            // 
            // _data_alarmState4
            // 
            this._data_alarmState4.Text = "故障4";
            // 
            // _data_alarmState5
            // 
            this._data_alarmState5.Text = "故障5";
            // 
            // _data_alarmState6
            // 
            this._data_alarmState6.Text = "故障6";
            // 
            // _data_alarmState7
            // 
            this._data_alarmState7.Text = "故障7";
            // 
            // _data_alarmState8
            // 
            this._data_alarmState8.Text = "故障8";
            // 
            // _data_alarmState9
            // 
            this._data_alarmState9.Text = "故障9";
            // 
            // _data_alarmState10
            // 
            this._data_alarmState10.Text = "故障10";
            // 
            // _data_alarmState11
            // 
            this._data_alarmState11.Text = "故障11";
            // 
            // _data_alarmState12
            // 
            this._data_alarmState12.Text = "故障12";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_TimeSet, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 424);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(186, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(770, 418);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(965, 444);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox5_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 469);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vincent Medical";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_TimeSet.ResumeLayout(false);
            this.groupBox_TimeSet.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_BasicInfo.ResumeLayout(false);
            this.groupBox_workingParam.ResumeLayout(false);
            this.groupBox_workingParam.PerformLayout();
            this.groupBox_time.ResumeLayout(false);
            this.groupBox_time.PerformLayout();
            this.groupBox_equipInfo.ResumeLayout(false);
            this.groupBox_equipInfo.PerformLayout();
            this.tabPage_workDataChart.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_workData)).EndInit();
            this.tabPage_alarmList.ResumeLayout(false);
            this.tabPage_workdatalist.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_TimeSet;
        private System.Windows.Forms.ToolStripMenuItem 语言设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件版本ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label_endTime;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Begin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_BasicInfo;
        private System.Windows.Forms.TabPage tabPage_workDataChart;
        private System.Windows.Forms.TabPage tabPage_alarmList;
        private System.Windows.Forms.TabPage tabPage_workdatalist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_selectFolder;
        private System.Windows.Forms.ListView listView_alarmInfo;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader RunningMode;
        private System.Windows.Forms.ColumnHeader AlarmCode;
        private System.Windows.Forms.ColumnHeader AlarmInfo;
        private System.Windows.Forms.ColumnHeader AlarmData1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_workData;
        private System.Windows.Forms.GroupBox groupBox_equipInfo;
        private System.Windows.Forms.Label label_softwarVer;
        private System.Windows.Forms.Label label_equipType;
        private System.Windows.Forms.GroupBox groupBox_time;
        private System.Windows.Forms.Label label_dateTo_Value;
        private System.Windows.Forms.Label label_dateFrom_Value;
        private System.Windows.Forms.ListView listView_workData;
        private System.Windows.Forms.ColumnHeader _No;
        private System.Windows.Forms.ColumnHeader _time;
        private System.Windows.Forms.ColumnHeader _runningmode;
        private System.Windows.Forms.ColumnHeader _set_tmp;
        private System.Windows.Forms.ColumnHeader _set_flow;
        private System.Windows.Forms.ColumnHeader _set_highOxyAlarm;
        private System.Windows.Forms.ColumnHeader _set_lowOxyAlarm;
        private System.Windows.Forms.ColumnHeader _set_AtomizLevel;
        private System.Windows.Forms.ColumnHeader _set_AtomizTime;
        private System.Windows.Forms.ColumnHeader _set_adaultChild;
        private System.Windows.Forms.ColumnHeader _data_patientTmp;
        private System.Windows.Forms.ColumnHeader _data_airOutletTmp;
        private System.Windows.Forms.ColumnHeader _data_heatingPlateTmp;
        private System.Windows.Forms.ColumnHeader _data_EnvTmp;
        private System.Windows.Forms.ColumnHeader _data_DriveBoardTmp;
        private System.Windows.Forms.ColumnHeader _data_flow;
        private System.Windows.Forms.ColumnHeader _data_OxyContentration;
        private System.Windows.Forms.ColumnHeader _data_airPressure;
        private System.Windows.Forms.ColumnHeader _data_loopType;
        private System.Windows.Forms.ColumnHeader _data_alarmState1;
        private System.Windows.Forms.ColumnHeader _data_alarmState2;
        private System.Windows.Forms.ColumnHeader _data_alarmState3;
        private System.Windows.Forms.ColumnHeader _data_alarmState4;
        private System.Windows.Forms.ColumnHeader _data_alarmState5;
        private System.Windows.Forms.ColumnHeader _data_alarmState6;
        private System.Windows.Forms.ColumnHeader _data_alarmState7;
        private System.Windows.Forms.ColumnHeader _data_alarmState8;
        private System.Windows.Forms.ColumnHeader _data_alarmState9;
        private System.Windows.Forms.ColumnHeader _data_alarmState10;
        private System.Windows.Forms.ColumnHeader _data_alarmState11;
        private System.Windows.Forms.ColumnHeader _data_alarmState12;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_saveFiles;
        private System.Windows.Forms.GroupBox groupBox_workingParam;
        private System.Windows.Forms.Label label_runningMode_value;
        private System.Windows.Forms.Label label_runningMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_setFlow_Value;
        private System.Windows.Forms.Label label_setTmp_Value;
        private System.Windows.Forms.Label label_setFlow;
        private System.Windows.Forms.Label label_setTmp;
        private System.Windows.Forms.Label label_setAdaultChild_Value;
        private System.Windows.Forms.Label label_setAtomizTime_Value;
        private System.Windows.Forms.Label label_setAtmoizLevel_Value;
        private System.Windows.Forms.Label label_setAdaultChild;
        private System.Windows.Forms.Label label_setAtomizTime;
        private System.Windows.Forms.Label label_setHighOxyContAlarm_Value;
        private System.Windows.Forms.Label label_setAtmoizLevel;
        private System.Windows.Forms.Label label_setLowOxyContAlarm;
        private System.Windows.Forms.Label label_setLowOxyContAlarm_Value;
        private System.Windows.Forms.Label label_setHighOxyContAlarm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader AlarmData2;
        private System.Windows.Forms.Label label_SN;
        private System.Windows.Forms.Label label_SN_Value;
        private System.Windows.Forms.Label label_softwarVer_Value;
        private System.Windows.Forms.Label label_equipType_Value;
        private System.Windows.Forms.ToolStripMenuItem 模式选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程师模式ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;


    }
}

