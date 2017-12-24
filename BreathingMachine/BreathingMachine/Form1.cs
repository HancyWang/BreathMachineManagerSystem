using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Windows.Forms.DataVisualization.Charting;

namespace BreathingMachine
{

    public partial class Form1 : Form
    {
        public static string g_username;
        public static string g_password;
        public bool g_bEngineerMode;
        private List<ListViewItem> myCache;
        private List<ListViewItem> myCache1;
        public Form1()
        {
            InitializeComponent();
            //myCache = new List<ListViewItem>();
            //myCache1 = new List<ListViewItem>();
        }

        public void PaintUsageChart(DateTime tmBegin,DateTime tmEnd)
        {
            DateTime tmFirstDay = DateTime.FromOADate(0); //获取系统默认的第一天，1899/12/30

            DateTime tm_begin = new DateTime(tmBegin.Year, tmBegin.Month, tmBegin.Day, 0, 0, 0);
            DateTime tm_end = new DateTime(tmEnd.Year, tmEnd.Month, tmEnd.Day, 0, 0, 0);

            double day_min = (tm_begin - tmFirstDay).TotalDays-1; //x轴上的最小值 ,-1表示多放前一天，为了图表显示好看
            double day_max = (tm_end - tmFirstDay).TotalDays+1;   //y轴上的最大值,+1表示日期在后推一天

            //画图
            this.chart_workData.Series.Clear();//清除所有图
            this.chart_workData.ChartAreas.Clear();

            Series usage = new Series("usage");
            ChartArea chartArea_usage = new ChartArea("chartArea_usage");
            usage.ChartArea = "chartArea_usage";

            usage.XValueType = ChartValueType.Date;  //设置X,Y轴的坐标类型
            usage.YValueType = ChartValueType.Time;

            usage.ChartType = SeriesChartType.RangeColumn;//设置图标类型

            chartArea_usage.AxisX.LabelStyle.Format = "MM-dd";
            chartArea_usage.AxisY.IsReversed = true;
            chartArea_usage.AxisX.Minimum = day_min;
            chartArea_usage.AxisX.Maximum = day_max;
            chartArea_usage.AxisX.Interval = 1;

            chartArea_usage.AxisY.LabelStyle.Format = "HH:mm";
            chartArea_usage.AxisY.Minimum = 0;
            chartArea_usage.AxisY.Maximum = 1;
            chartArea_usage.AxisY.Interval = 0.125;//00:00-24:00是按0-1来的，0.125等于3个小时

            this.chart_workData.ChartAreas.Add(chartArea_usage);
            this.chart_workData.Series.Add(usage);
            
            //.Series["usage"].Points.DataBindXY(DataMngr.m_usageTable_xAxis_list, DataMngr.m_usageTable_beginTime_list, DataMngr.m_usageTable_endTime_list);
            usage.Points.DataBindXY(DataMngr.m_usageTable_xAxis_list, DataMngr.m_usageTable_beginTime_list, DataMngr.m_usageTable_endTime_list);
        }

        public void ShowAllCharts(DateTime tmBegin,DateTime tmEnd)
        {
            //从FileMngr的Dictionary中得到信息放入DataMngr的链表中
            DataMngr.GetUsageInfo();

            //画usage图
            PaintUsageChart(tmBegin, tmEnd);

            //画其他的图

        }

        public void ShowBasicInfo()
        {
            //var workDataHead = FileMngr.m_lastWorkHead;
            //var workDataMsg = FileMngr.m_lastWorkMsg;

            //workDataHead.MACHINETYPE;
            this.label_runningMode_value.Text = DataMngr.GetRunningMode(FileMngr.m_lastWorkMsg.SET_MODE);
            this.label_setTmp_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_TEMP);
            this.label_setAdaultChild_Value.Text = DataMngr.GetAdaultChildSetting(FileMngr.m_lastWorkMsg.SET_ADULT_OR_CHILDE);

            this.label_setFlow_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_FLOW);
            this.label_setHighOxyContAlarm_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_HIGH_OXYGEN_ALARM);
            this.label_setLowOxyContAlarm_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_LOW_OXYGEN_ALARM);
            this.label_setAtmoizLevel_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_ATOMIZATION_LEVEL);
            this.label_setAtomizTime_Value.Text = DataMngr.GetSetting2Str(FileMngr.m_lastWorkMsg.SET_ATOMIZATION_TIME);

            byte[] head = FileMngr.GetData(FileMngr.m_lastWorkHead);
            this.label_equipType_Value.Text = DataMngr.GetMachineType(head, 1);
            this.label_SN_Value.Text = DataMngr.GetSN(head, 2);
            this.label_softwarVer_Value.Text = DataMngr.GetSoftwareVer(head, 3);
        }




        public void ShowWorkDataList(DateTime TmLow, DateTime TmHigh)
        {
            this.listView_workData.Items.Clear();
            this.listView_workData.BeginUpdate();

            #region
            int i = 1;

            foreach (KeyValuePair<WORK_INFO_HEAD, List<WORK_INFO_MESSAGE>> kv in FileMngr.m_workHead_Msg_Map)
            {
                var list = kv.Value;
                #region
                foreach (var workDataMsg in list)
                {
                    //if(FileMngr.VerifyWorkDataMsg(FileMngr.GetData(workDataMsg)))
                    {
                        DateTime tmFromMsg = new DateTime(100 * Convert.ToInt32(workDataMsg.YEAR1) + Convert.ToInt32(workDataMsg.YEAR2),
                                                         Convert.ToInt32(workDataMsg.MONTH),
                                                         Convert.ToInt32(workDataMsg.DAY),
                                                         Convert.ToInt32(workDataMsg.HOUR),
                                                         Convert.ToInt32(workDataMsg.MINUTE),
                                                         Convert.ToInt32(workDataMsg.SECOND));
                        if (tmFromMsg > TmLow && tmFromMsg < TmHigh)
                        {
                            //解析故障状态位,一共12位
                            int[] faultStates = new int[12];
                            #region
                            byte bt1 = workDataMsg.DATA_FAULT_STATUS_1;
                            byte bt2 = workDataMsg.DATA_FAULT_STATUS_2;

                            for (int j = 0; j < 8; j++)
                            {
                                if (Convert.ToInt32(bt1) % 2 == 1)
                                {
                                    faultStates[j] = 1;
                                }
                                else
                                {
                                    faultStates[j] = 0;
                                }
                                bt1 = (byte)(bt1 >> 1);
                            }

                            for (int j = 0; j < 3; j++)
                            {
                                if (Convert.ToInt32(bt2) % 2 == 1)
                                {
                                    faultStates[j + 8] = 1;
                                }
                                else
                                {
                                    faultStates[j + 8] = 0;
                                }
                                bt1 = (byte)(bt2 >> 1);
                            }
                            #endregion

                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = i.ToString();  //第一列,No.

                            lvi.SubItems.Add(tmFromMsg.ToString("yyyy-MM-dd HH:mm:ss")); //第二列，时间
                            lvi.SubItems.Add(Convert.ToString(Convert.ToBoolean(workDataMsg.SET_MODE) ? "雾化" : "湿化"));  //第三列，运行模式
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_TEMP)));                      //第四列，设定温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_FLOW)));                      //第五列，设定流量
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_HIGH_OXYGEN_ALARM)));                      //第六列，设定高氧浓度报警
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_LOW_OXYGEN_ALARM)));                      //第七列，设定低氧浓度报警
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_ATOMIZATION_LEVEL)));                      //第8列，设定雾化量档位
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_ATOMIZATION_TIME)));                      //第9列，设定雾化时间
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.SET_ADULT_OR_CHILDE)));                      //第10列，设定成人儿童模式
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_PATIENT_TEMP)));                      //第11列，患者端温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_AIR_OUTLET_TEMP)));                      //第12列，出气口温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_ADC_H)));                      //第13列，加热盘温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_ENVIRONMENT_TMP)));                      //第14列，环境温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_DRIVERBOARD_TMP)));                      //第15列，驱动板温度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_FLOW)));                      //第16列，流量
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_OXYGEN_CONCENTRATION)));                      //第17列，氧浓度
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_AIR_PRESSURE)));                      //第18列，气道压力
                            lvi.SubItems.Add(Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_TYPE)));                      //第19列，回路类型
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[0]) ? "yes" : "no");                         //第20列，状态位
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[1]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[2]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[3]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[4]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[5]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[6]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[7]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[8]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[9]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[10]) ? "yes" : "no");
                            lvi.SubItems.Add(Convert.ToBoolean(faultStates[11]) ? "yes" : "no");                      //第31列，状态位







                            //lvi.SubItems.Add(Convert.ToString(FileMngr.AlarmCode2Str(alarmMsg.ALARM_CODE)));            //第五列，设定流量
                            //lvi.SubItems.Add(Convert.ToString(alarmMsg.ALARM_DATA_L));                                      //第六列，数据值
                            ////this.listViewAlarmData.Items.Add(lvi);
                            myCache1.Add(lvi);
                            i++;
                        }
                    }
                }
                #endregion
            }
            #endregion

            this.listView_workData.VirtualListSize = myCache1.Count;
            this.listView_workData.EndUpdate();
        }

        public void ShowAlarmList(DateTime TmLow, DateTime TmHigh)
        {
            this.listView_alarmInfo.Items.Clear();
            this.listView_alarmInfo.BeginUpdate();
            #region
            int i = 1;
            foreach (var alarmMsg in FileMngr.m_alarmMsgList)
            {
                //if(FileMngr.VerifyAlarmMsg(FileMngr.GetData(alarmMsg))) //校验
                {
                    DateTime tmFromMsg = new DateTime(100 * Convert.ToInt32(alarmMsg.YEAR1) + Convert.ToInt32(alarmMsg.YEAR2),
                                                         Convert.ToInt32(alarmMsg.MONTH),
                                                         Convert.ToInt32(alarmMsg.DAY),
                                                         Convert.ToInt32(alarmMsg.HOUR),
                                                         Convert.ToInt32(alarmMsg.MINUTE),
                                                         Convert.ToInt32(alarmMsg.SECOND));
                    if (tmFromMsg > TmLow && tmFromMsg < TmHigh)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = i.ToString();  //第一列,No.

                        lvi.SubItems.Add(tmFromMsg.ToString("yyyy-MM-dd HH:mm:ss")); //第二列，时间
                        lvi.SubItems.Add(Convert.ToString(Convert.ToBoolean(alarmMsg.RUNNIN_MODE) ? "雾化" : "湿化"));  //第三列，运行模式
                        lvi.SubItems.Add(Convert.ToString(Convert.ToString(alarmMsg.ALARM_CODE)));                      //第四列，错误码
                        lvi.SubItems.Add(Convert.ToString(FileMngr.AlarmCode2Str(alarmMsg.ALARM_CODE)));            //第五列，错误描述
                        lvi.SubItems.Add(Convert.ToString(alarmMsg.ALARM_DATA_L));                                      //第六列，数据值
                        lvi.SubItems.Add(Convert.ToString(alarmMsg.ALARM_DATA_H));                                      //第7列，数据值
                        //this.listViewAlarmData.Items.Add(lvi);
                        myCache.Add(lvi);
                        i++;
                    }
                }
            }
            #endregion
            this.listView_alarmInfo.VirtualListSize = myCache.Count;
            this.listView_alarmInfo.EndUpdate();

        }

        private void 语言ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageMngr.m_language = LANGUAGE.CHINA;

            //初始化app上的标签
            #region
            this.设置ToolStripMenuItem.Text = "设置";
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.软件版本ToolStripMenuItem.Text = "软件版本";
            this.语言设置ToolStripMenuItem.Text = "语言设置";
            this.中文ToolStripMenuItem.Text = "中文";
            this.英文ToolStripMenuItem.Text = "英文";
            this.导入数据ToolStripMenuItem.Text = "导入数据";
            this.导出数据ToolStripMenuItem.Text = "导出数据";

            this.模式选择ToolStripMenuItem.Text = "模式选择";
            this.工程师模式ToolStripMenuItem.Text = "工程师模式";
            this.用户模式ToolStripMenuItem.Text = "用户模式";

            this.groupBox_TimeSet.Text = "时段设置";
            this.label_startTime.Text = "开始时间";
            this.label_endTime.Text = "结束时间";
            this.tabControl1.TabPages["tabPage_BasicInfo"].Text = "基本信息";
            this.tabControl1.TabPages["tabPage_workDataChart"].Text = "图表";
            if(this.g_bEngineerMode)
            {
                this.tabControl1.TabPages["tabPage_alarmList"].Text = "报警信息";
                this.tabControl1.TabPages["tabPage_workdatalist"].Text = "工作信息";
            }
            

            this.groupBox_equipInfo.Text = "设备信息";
            this.groupBox_time.Text = "使用时间";
            this.groupBox_workingParam.Text = "工作参数";
            this.label_equipType.Text = "设备型号：";
            this.label_softwarVer.Text = "软件版本：";
            this.label_SN.Text = "SN：";
            this.label_runningMode.Text = "运行模式：";
            this.label_setTmp.Text = "设定温度：";
            this.label_setFlow.Text = "设定流量：";
            this.label_setHighOxyContAlarm.Text = "设定高氧浓度报警：";
            this.label_setLowOxyContAlarm.Text = "设定低氧浓度报警：";
            this.label_setAtmoizLevel.Text = "设定雾化档位：";
            this.label_setAtomizTime.Text = "设定雾化时间：";
            this.label_setAdaultChild.Text = "设定成人儿童模式：";
            #endregion


            this.label_runningMode_value.Text = DataMngr.GetRunningMode(FileMngr.m_lastWorkMsg.SET_MODE);
            this.label_setAdaultChild_Value.Text = DataMngr.GetAdaultChildSetting(FileMngr.m_lastWorkMsg.SET_ADULT_OR_CHILDE);

            byte[] head = FileMngr.GetData(FileMngr.m_lastWorkHead);
            this.label_equipType_Value.Text = DataMngr.GetMachineType(head, 1);
            this.label_SN_Value.Text = DataMngr.GetSN(head, 2);
            this.label_softwarVer_Value.Text = DataMngr.GetSoftwareVer(head, 3);
        }

        private void 英文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageMngr.m_language = LANGUAGE.ENGLISH;

            //初始化app上的标签
            #region
            this.设置ToolStripMenuItem.Text = "Set";
            this.帮助ToolStripMenuItem.Text = "Help";
            this.软件版本ToolStripMenuItem.Text = "Soft Ver";
            this.语言设置ToolStripMenuItem.Text = "Language";
            this.中文ToolStripMenuItem.Text = "Chinese";
            this.英文ToolStripMenuItem.Text = "English";
            this.导入数据ToolStripMenuItem.Text = "ImportData";
            this.导出数据ToolStripMenuItem.Text = "ExportData";

            this.模式选择ToolStripMenuItem.Text = "Mode Select";
            this.工程师模式ToolStripMenuItem.Text = "Engineer Mode";
            this.用户模式ToolStripMenuItem.Text = "User Mode";

            this.groupBox_TimeSet.Text = "Period Setting";
            this.label_startTime.Text = "Staring Date:";
            this.label_endTime.Text = "Ending Date:";
            this.tabControl1.TabPages["tabPage_BasicInfo"].Text = "Basical Info.";
            this.tabControl1.TabPages["tabPage_workDataChart"].Text = "Charts";
            if(this.g_bEngineerMode)
            {
                this.tabControl1.TabPages["tabPage_alarmList"].Text = "Alarm Info.";
                this.tabControl1.TabPages["tabPage_workdatalist"].Text = "Work Info";
            }
            
            this.groupBox_equipInfo.Text = "Equipment Info.";
            this.groupBox_time.Text = "Time Period";
            this.groupBox_workingParam.Text = "Working Parameter";
            this.label_equipType.Text = "Machine Type：";
            this.label_softwarVer.Text = "Software Ver.：";
            this.label_SN.Text = "SN：";
            this.label_runningMode.Text = "Running Mode：";
            this.label_setTmp.Text = "Temperature Setting：";
            this.label_setFlow.Text = "Flow Setting：";
            this.label_setHighOxyContAlarm.Text = "High Oxygen Content Alarm Setting：";
            this.label_setLowOxyContAlarm.Text = "Low Oxygen Content Alarm Setting：";
            this.label_setAtmoizLevel.Text = "Atomizatin Level Setting：";
            this.label_setAtomizTime.Text = "Atomizatin time Setting：";
            this.label_setAdaultChild.Text = "Adault or Child Setting：";
            #endregion

            this.label_runningMode_value.Text = DataMngr.GetRunningMode(FileMngr.m_lastWorkMsg.SET_MODE);
            this.label_setAdaultChild_Value.Text = DataMngr.GetAdaultChildSetting(FileMngr.m_lastWorkMsg.SET_ADULT_OR_CHILDE);

            byte[] head = FileMngr.GetData(FileMngr.m_lastWorkHead);
            this.label_equipType_Value.Text = DataMngr.GetMachineType(head, 1);
            this.label_SN_Value.Text = DataMngr.GetSN(head, 2);
            this.label_softwarVer_Value.Text = DataMngr.GetSoftwareVer(head, 3);
        }

        private void 导入数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //如果重复点击按钮，要先清除之前Msg链表的资源
            #region
            if (FileMngr.m_workFileNameList != null)
            {
                FileMngr.m_workFileNameList.Clear();
            }
            if (FileMngr.m_alarmMsgList != null)
            {
                FileMngr.m_alarmMsgList.Clear();
            }
            if (FileMngr.m_workHead_Msg_Map != null)
            {
                FileMngr.m_workHead_Msg_Map.Clear();
            }
            if (myCache != null)
            {
                myCache.Clear();
            }

            if (myCache1 != null)
            {
                myCache1.Clear();
            }

            #endregion
            //加载文件内容到内存中，存放在FileMngr的链表中
            #region
            if (this.folderBrowserDialog_selectFolder.ShowDialog() == DialogResult.OK)
            {
                string strPath = folderBrowserDialog_selectFolder.SelectedPath;//获取打开的文件路径名
                //判断打开的文件夹是否有效
                if (!FileMngr.IsDirValidate(strPath))
                {
                    MessageBox.Show("请选择正确的文件夹！");
                    return;
                }

                FileMngr.GetAllFilesName(); //获取所有文件的文件名，放入m_alarmFileName和m_workFileNameList中

                //校验文件，并且得到信息头和信息体链表
                
                if (!FileMngr.GetAlarmMsg())
                {
                    MessageBox.Show("获取报警文件信息失败");
                }

                if (!FileMngr.GetWorkMsg())
                {
                    MessageBox.Show("这里填什么好呢？");
                }

                //显示app面板上基本信息的各个数据,显示最新的数据
                ShowBasicInfo();

                #region
                #endregion
            }
            #endregion
            //文件全部加载到内存之后将DateTimePicker激活
            this.dateTimePicker_Begin.Enabled = true;
            this.dateTimePicker_End.Enabled = true;
        }

        private void 导出数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileMngr.m_dirPath == null)
            {
                MessageBox.Show(LanguageMngr.no_data());
                return;
            }
            //MessageBox.Show("请选择要保存文件的文件夹");
            //先将数据到到本地
            string strPath = "";
            if (this.folderBrowserDialog_saveFiles.ShowDialog() == DialogResult.OK)
            {
                strPath = folderBrowserDialog_saveFiles.SelectedPath;//获取打开的文件路径名
            }
            //创建两个文件
            FileStream fs_alarm = new FileStream(strPath + @"\" + "Alarm.csv", FileMode.Create);
            FileStream fs_workData = new FileStream(strPath + @"\" + "WorkData.csv", FileMode.Create);
            StreamWriter sw_alarm = new StreamWriter(fs_alarm, Encoding.GetEncoding("gb2312"));
            StreamWriter sw_workData = new StreamWriter(fs_workData, Encoding.GetEncoding("gb2312"));

            //写数据到两个文件中,先做个.csv格式的
            //先写alarm.csv
            #region
            int i = 1;
            sw_alarm.WriteLine("No." + "," + "日期" + "," + "运行模式" + "," + "报警码" + "," + "报警信息" + "," + "报警数据值1" + "," + "报警数据值2");
            foreach (var alarmMsg in FileMngr.m_alarmMsgList)
            {
                string line = "";
                //if(FileMngr.VerifyAlarmMsg(FileMngr.GetData(alarmMsg))) //校验
                {
                    DateTime tmFromMsg = new DateTime(100 * Convert.ToInt32(alarmMsg.YEAR1) + Convert.ToInt32(alarmMsg.YEAR2),
                                                         Convert.ToInt32(alarmMsg.MONTH),
                                                         Convert.ToInt32(alarmMsg.DAY),
                                                         Convert.ToInt32(alarmMsg.HOUR),
                                                         Convert.ToInt32(alarmMsg.MINUTE),
                                                         Convert.ToInt32(alarmMsg.SECOND));
                    line = i.ToString() + ","
                        + tmFromMsg.ToString("yyyy-MM-dd HH:mm:ss") + ","
                        + Convert.ToString(Convert.ToBoolean(alarmMsg.RUNNIN_MODE) ? "雾化" : "湿化") + ","
                        + Convert.ToString(Convert.ToString(alarmMsg.ALARM_CODE)) + ","
                        + Convert.ToString(FileMngr.AlarmCode2Str(alarmMsg.ALARM_CODE)) + ","
                        + Convert.ToString(alarmMsg.ALARM_DATA_L) + ","
                        + Convert.ToString(alarmMsg.ALARM_DATA_H);
                    sw_alarm.WriteLine(line);
                    i++;
                }
            }
            #endregion

            //在写workdata.csv
            //备注说明:excel2007最多能存1048576行
            #region
            i = 1;
            //写列头
            #region
            sw_workData.WriteLine("No." + ","
                                + "日期" + ","
                                + "运行模式" + ","
                                + "设定温度" + ","
                                + "设定流量" + ","
                                + "设定高氧浓度报警" + ","
                                + "设定低氧浓度报警" + ","
                                + "设定雾化量档位" + ","
                                + "设定雾化时间" + ","
                                + "设定成人儿童模式" + ","
                                + "患者端温度" + ","
                                + "出气口温度" + ","
                                + "加热盘温度" + ","
                                + "环境温度" + ","
                                + "驱动板温度" + ","
                                + "流量" + ","
                                + "氧浓度" + ","
                                + "气道压力" + ","
                                + "回路类型" + ","
                                + "故障1" + ","
                                + "故障2" + ","
                                + "故障3" + ","
                                + "故障4" + ","
                                + "故障5" + ","
                                + "故障6" + ","
                                + "故障7" + ","
                                + "故障8" + ","
                                + "故障9" + ","
                                + "故障10" + ","
                                + "故障11" + ","
                                + "故障12" + ","
                                + "雾化DAC数值L" + ","
                                + "雾化DAC数值H" + ","
                                + "雾化ADC数值L" + ","
                                + "雾化ADC数值H" + ","
                                + "回路加热PWM数值L" + ","
                                + "回路加热PWM数值H" + ","
                                + "回路加热ADC数值L" + ","
                                + "回路加热ADC数值H" + ","
                                + "加热盘加热PWM数值L" + ","
                                + "加热盘加热PWM数值H" + ","
                                + "加热盘加热ADC数值L" + ","
                                + "加热盘加热ADC数值H" + ","
                                + "主马达驱动数值L" + ","
                                + "主马达驱动数值H" + ","
                                + "主马达转速数值L" + ","
                                + "主马达转速数值H" + ","
                                + "压力传感器ADC值L" + ","
                                + "压力传感器ADC值H" + ","
                                + "水位传感器HADC值L" + ","
                                + "水位传感器HADC值H" + ","
                                + "水位传感器LADC值L" + ","
                                + "水位传感器LADC值H" + ","
                                + "散热风扇驱动数值L" + ","
                                + "散热风扇驱动数值H" + ","
                                + "散热风扇转速数值L" + ","
                                + "散热风扇转速数值H" + ","
                                );
            #endregion
            foreach (KeyValuePair<WORK_INFO_HEAD, List<WORK_INFO_MESSAGE>> kv in FileMngr.m_workHead_Msg_Map)
            {
                var list = kv.Value;
                foreach (var workDataMsg in list)
                {
                    int[] faultStates = new int[12];
                    //解析故障状态位
                    #region
                    byte bt1 = workDataMsg.DATA_FAULT_STATUS_1;
                    byte bt2 = workDataMsg.DATA_FAULT_STATUS_2;

                    for (int j = 0; j < 8; j++)
                    {
                        if (Convert.ToInt32(bt1) % 2 == 1)
                        {
                            faultStates[j] = 1;
                        }
                        else
                        {
                            faultStates[j] = 0;
                        }
                        bt1 = (byte)(bt1 >> 1);
                    }

                    for (int j = 0; j < 3; j++)
                    {
                        if (Convert.ToInt32(bt2) % 2 == 1)
                        {
                            faultStates[j + 8] = 1;
                        }
                        else
                        {
                            faultStates[j + 8] = 0;
                        }
                        bt1 = (byte)(bt2 >> 1);
                    }
                    #endregion

                    //将数据写入
                    #region
                    string line = "";
                    DateTime tmFromMsg = new DateTime(100 * Convert.ToInt32(workDataMsg.YEAR1) + Convert.ToInt32(workDataMsg.YEAR2),
                                                         Convert.ToInt32(workDataMsg.MONTH),
                                                         Convert.ToInt32(workDataMsg.DAY),
                                                         Convert.ToInt32(workDataMsg.HOUR),
                                                         Convert.ToInt32(workDataMsg.MINUTE),
                                                         Convert.ToInt32(workDataMsg.SECOND));
                    line = i.ToString() + ","
                        + tmFromMsg.ToString("yyyy-MM-dd HH:mm:ss") + ","
                        + Convert.ToString(Convert.ToBoolean(workDataMsg.SET_MODE) ? "雾化" : "湿化") + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_TEMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_FLOW)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_HIGH_OXYGEN_ALARM)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_LOW_OXYGEN_ALARM)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_ATOMIZATION_LEVEL)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.SET_ATOMIZATION_TIME)) + ","
                        + Convert.ToString(Convert.ToBoolean(workDataMsg.SET_ADULT_OR_CHILDE) ? "成人" : "儿童") + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_PATIENT_TEMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_AIR_OUTLET_TEMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_TMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_ENVIRONMENT_TMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_DRIVERBOARD_TMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_FLOW)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_OXYGEN_CONCENTRATION)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_AIR_OUTLET_TEMP)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_TYPE)) + ","
                        + (Convert.ToBoolean(faultStates[0]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[1]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[2]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[3]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[4]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[5]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[6]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[7]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[8]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[9]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[10]) ? "yes" : "no") + ","
                        + (Convert.ToBoolean(faultStates[11]) ? "yes" : "no") + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_ATOMIZ_DACVALUE_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_ATOMIZ_DACVALUE_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_ATOMIZ_ADCVALUE_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_ATOMIZ_ADCVALUE_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_HEATING_PWM_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_HEATING_PWM_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_HEATING_ADC_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_LOOP_HEATING_ADC_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_PWM_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_PWM_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_ADC_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_HEATING_PLATE_ADC_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_MAIN_MOTOR_DRIVER_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_MAIN_MOTOR_DRIVER_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_MAIN_MOTOR_SPEED_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_MAIN_MOTOR_SPEED_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_PRESS_SENSOR_ADC_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_PRESS_SENSOR_ADC_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_WATERLEVEL_SENSOR_HADC_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_WATERLEVEL_SENSOR_HADC_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_WATERLEVEL_SENSOR_LADC_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_WATERLEVEL_SENSOR_LADC_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_FAN_DRIVER_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_FAN_DRIVER_H)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_FAN_SPEED_L)) + ","
                        + Convert.ToString(Convert.ToString(workDataMsg.DATA_FAN_SPEED_H)) + ",";
                    #endregion

                    sw_workData.WriteLine(line);
                    i++;
                }
            }
            #endregion

            sw_alarm.Close();
            sw_workData.Close();
            fs_workData.Close();
            fs_alarm.Close();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化工程师模式
            this.g_bEngineerMode = false;
            //this.g_flag_alreadyInEngMode = false;
            //初始化，默认用户模式按钮不能点
            this.用户模式ToolStripMenuItem.Enabled = false;
            //初始化语言
            LanguageMngr.m_language = LANGUAGE.CHINA;

            //初始化基本信息中的各个参数值,都为空
            #region
            this.label_equipType_Value.Text = "";
            this.label_runningMode_value.Text = "";
            this.label_setAtmoizLevel_Value.Text = "";
            this.label_setAtomizTime_Value.Text = "";
            this.label_setFlow_Value.Text = "";
            this.label_setHighOxyContAlarm_Value.Text = "";
            this.label_setLowOxyContAlarm_Value.Text = "";
            this.label_setTmp_Value.Text = "";
            this.label_SN_Value.Text = "";
            this.label_softwarVer_Value.Text = "";
            this.label_setAdaultChild_Value.Text = "";
            #endregion

            //初始化FileMngr中的链表
            FileMngr.m_workFileNameList = new List<string>();
            FileMngr.m_alarmMsgList = new List<ALARM_INFO_MESSAGE>();
            FileMngr.m_workHead_Msg_Map = new Dictionary<WORK_INFO_HEAD, List<WORK_INFO_MESSAGE>>();

            //listview虚列表初始化
            this.listView_alarmInfo.View = View.Details;
            this.listView_alarmInfo.VirtualMode = true;
            this.listView_alarmInfo.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listViewAlarmData_RetrieveVirtualItem);

            this.listView_workData.View = View.Details;
            this.listView_workData.VirtualMode = true;
            this.listView_workData.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listViewWorkData_RetrieveVirtualItem);

        }
        private void listViewAlarmData_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (this.myCache == null || this.myCache.Count == 0)
            {
                return;
            }

            e.Item = this.myCache[e.ItemIndex];
            if (e.ItemIndex == this.myCache.Count)
            {
                this.myCache = null;
            }
        }

        private void listViewWorkData_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (this.myCache1 == null || this.myCache1.Count == 0)
            {
                return;
            }

            e.Item = this.myCache1[e.ItemIndex];
            if (e.ItemIndex == this.myCache1.Count)
            {
                this.myCache1 = null;
            }
        }

        private void dateTimePicker_Begin_ValueChanged(object sender, EventArgs e)
        {
            //初始化app面板上，基本信息中的时间
            this.label_dateFrom_Value.Text = this.dateTimePicker_Begin.Value.ToString("yyyy/MM/dd");
            this.label_dateTo_Value.Text = this.dateTimePicker_End.Value.ToString("yyyy/MM/dd");
            //当重复触发时，首先释放myCache和myCache1
            #region
            if (myCache != null)
            {
                myCache.Clear();
            }
            myCache = new List<ListViewItem>();

            if (myCache1 != null)
            {
                myCache1.Clear();
            }
            myCache1 = new List<ListViewItem>();
            #endregion

            //校验开始时间，结束时间的正确性
            DateTime tmp1 = this.dateTimePicker_Begin.Value;
            DateTime tmp2 = this.dateTimePicker_End.Value;
            #region
            if (tmp1 > tmp2)
            {
                this.dateTimePicker_Begin.Value = FileMngr.m_dateTime_begin;
                this.dateTimePicker_End.Value = FileMngr.m_dateTime_end;
                MessageBox.Show("开始时间大于结束时间，请重选");
                return;
            }
            else
            {
                FileMngr.m_dateTime_begin = tmp1;
                FileMngr.m_dateTime_end = tmp2;
            }
            #endregion

            DateTime TmLow = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, 0, 0, 0);
            DateTime TmHight = new DateTime(tmp2.Year, tmp2.Month, tmp2.Day, 23, 59, 59);

            if(g_bEngineerMode)
            {
                ShowAlarmList(TmLow, TmHight);
                ShowWorkDataList(TmLow, TmHight);
            }
            ShowAllCharts(this.dateTimePicker_Begin.Value, this.dateTimePicker_End.Value);
           
        }

        private void dateTimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            //初始化app面板上，基本信息中的时间
            this.label_dateFrom_Value.Text = this.dateTimePicker_Begin.Value.ToString("yyyy/MM/dd");
            this.label_dateTo_Value.Text = this.dateTimePicker_End.Value.ToString("yyyy/MM/dd");
            //当重复触发时，首先释放myCache和myCache1
            #region
            if (myCache != null)
            {
                myCache.Clear();
            }
            myCache = new List<ListViewItem>();

            if (myCache1 != null)
            {
                myCache1.Clear();
            }
            myCache1 = new List<ListViewItem>();
            #endregion

            //校验开始时间，结束时间的正确性
            DateTime tmp1 = this.dateTimePicker_Begin.Value;
            DateTime tmp2 = this.dateTimePicker_End.Value;
            #region
            if (tmp1 > tmp2)
            {
                this.dateTimePicker_Begin.Value = FileMngr.m_dateTime_begin;
                this.dateTimePicker_End.Value = FileMngr.m_dateTime_end;
                MessageBox.Show("开始时间大于结束时间，请重选");
                return;
            }
            else
            {
                FileMngr.m_dateTime_begin = tmp1;
                FileMngr.m_dateTime_end = tmp2;
            }
            #endregion

            DateTime TmLow = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, 0, 0, 0);
            DateTime TmHight = new DateTime(tmp2.Year, tmp2.Month, tmp2.Day, 23, 59, 59);

            if (g_bEngineerMode)
            {
                ShowAlarmList(TmLow, TmHight);
                ShowWorkDataList(TmLow, TmHight);
            }
            ShowAllCharts(this.dateTimePicker_Begin.Value, this.dateTimePicker_End.Value);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("I see U");
            FileMngr.m_dateTime_begin = this.dateTimePicker_Begin.Value;
            FileMngr.m_dateTime_end = this.dateTimePicker_End.Value;
            this.dateTimePicker_Begin.Enabled = false;
            this.dateTimePicker_End.Enabled = false;
            if (!this.g_bEngineerMode)
            {
                this.tabPage_alarmList.Parent = null;
                this.tabPage_workdatalist.Parent = null;
            }
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }



        private void 工程师模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form_engineer = new Form_engineer();

            if (this.g_bEngineerMode == true)
            {
                MessageBox.Show(LanguageMngr.u_r_already_in_eng_mode());
                return;
            }
            form_engineer.ShowDialog();
            if (g_username == "eng004" && g_password == "eng004")
            {
                MessageBox.Show(LanguageMngr.welcom_enterinto_eng_mode());
                //this.g_flag_alreadyInEngMode = true;
                this.g_bEngineerMode = true;
                //先初始化报警信息和工作信息列表的语言
                #region
                if (LanguageMngr.m_language==LANGUAGE.CHINA)
                {
                    this.tabPage_alarmList.Text = "报警信息";
                    this.tabPage_workdatalist.Text = "工作信息";
                }
                else if (LanguageMngr.m_language == LANGUAGE.ENGLISH)
                {
                    this.tabPage_alarmList.Text = "Alarm Info.";
                    this.tabPage_workdatalist.Text = "Work Info";
                }
                else
                {

                }
                #endregion
                this.tabPage_alarmList.Parent = this.tabControl1;   //隐藏报警列表
                this.tabPage_workdatalist.Parent = this.tabControl1; //隐藏工作列表
                this.用户模式ToolStripMenuItem.Enabled = true;      //启动用户模式按钮
            }

        }

        private void 用户模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.g_bEngineerMode = false;
            //this.g_flag_alreadyInEngMode = false;
            if (this.用户模式ToolStripMenuItem.Enabled==false)
            {
                if(LanguageMngr.m_language==LANGUAGE.CHINA)
                {
                    MessageBox.Show("您已经处于用户模式！");
                }
                else if(LanguageMngr.m_language==LANGUAGE.ENGLISH)
                {
                    MessageBox.Show("You are already in user mode!");
                }
                else
                {

                }
            }
            this.tabPage_alarmList.Parent = null;
            this.tabPage_workdatalist.Parent = null;
            ////试一试,貌似没起什么作用，内存并没有释放，有可能是因为使用了虚模式
            ////可以虚模式下的内存并没有释放
            //myCache.Clear();
            //myCache1.Clear();
            //this.listView_alarmInfo.Items.Clear();
            //this.listView_workData.Items.Clear();
            //this.listView_alarmInfo.Dispose();
            //this.listView_workData.Dispose();
        }
    }
    public class FileMngr
    {
        public static WORK_INFO_HEAD m_lastWorkHead;            //这个是为了显示app上的基本信息，才保留的一个信息
        public static WORK_INFO_MESSAGE m_lastWorkMsg;          //这个是为了显示app上的基本信息，才保留的一个信息
        public static DateTime m_dateTime_begin;
        public static DateTime m_dateTime_end;
        public const int ALARM_MSG_LEN = 16;                     //报警信息长度
        public const int WORKDATA_MSG_LEN = 64;                //工作信息长度
        public static string m_dirPath;                         //打开文件夹时的路径
        public static string m_alarmFileName;                   //报警文件名
        public static List<string> m_workFileNameList;              //工作文件路径的链表(工作文件有很多，每天一个)

        public static ALARM_INFO_HEAD m_alarmHead;              //alarm的消息头
        public static List<ALARM_INFO_MESSAGE> m_alarmMsgList;  //alarm消息体链表

        public static Dictionary<WORK_INFO_HEAD, List<WORK_INFO_MESSAGE>> m_workHead_Msg_Map;   //每天的工作信息头和Msg链表放到Map中

        public static bool IsDirValidate(string strPath)                      //判断打开的文件夹是否有效
        {
            var alarmFilePath = Directory.GetFiles(strPath, "ALARM.vmf");      //获取"ALARM.vmf"文件的路径名
            var workDateFilePathes = Directory.GetFiles(strPath, "DATA*.vmf");
            if (alarmFilePath.Length == 0 && workDateFilePathes.Length == 0)
            {
                return false;
            }
            m_dirPath = strPath;
            return true;
        }

        public static void GetAllFilesName()
        {
            var alarmFilePath = Directory.GetFiles(m_dirPath, "ALARM.vmf");      //获取"ALARM.vmf"文件的路径名
            var workDataFilePathes = Directory.GetFiles(m_dirPath, "DATA*.vmf");

            m_alarmFileName = alarmFilePath[0].Substring(alarmFilePath[0].LastIndexOf(@"\") + 1);
            //MessageBox.Show(m_alarmFileName);

            //m_workFileNameList = new List<string>();
            foreach (var file in workDataFilePathes)
            {
                m_workFileNameList.Add(file.Substring(file.LastIndexOf(@"\") + 1)); //将工作文件名添加到链表中
            }
        }

        public static bool GetAlarmMsg()
        {
            FileStream fs = new FileStream(m_dirPath + @"\" + m_alarmFileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs, Encoding.ASCII);

            ALARM_INFO_HEAD alarmHead = new ALARM_INFO_HEAD();
            int len_head = Marshal.SizeOf(alarmHead);
            byte[] buffer = new byte[len_head];

            if (fs == null)
            {
                MessageBox.Show("打开报警文件失败！");
                fs.Close();
                br.Close();
                return false;
            }

            br.Read(buffer, 0, len_head);

            //对alarmMsg的第一个字段进行校验

            //if (VerifyField(buffer))   //这里校验是失败的，为了打开文件将条件屏蔽
            if (VerifyField(buffer))
            {
                m_alarmHead = GetObject<ALARM_INFO_HEAD>(buffer, len_head); //将信息头放入m_alarmHead中
                //debug
                //MessageBox.Show("校验成功！");

                ALARM_INFO_MESSAGE alarmMsg = new ALARM_INFO_MESSAGE();
                int len_msg = Marshal.SizeOf(alarmMsg);
                byte[] buffer_msg = new byte[len_msg];

                //m_alarmMsgList = new List<ALARM_INFO_MESSAGE>();
                while (br.Read(buffer_msg, 0, len_msg) > 0)
                {
                    //if (VerifyAlarmMsg(buffer_msg))         //这里为了能读取字段，屏蔽条件
                    {
                        alarmMsg = GetObject<ALARM_INFO_MESSAGE>(buffer_msg, len_msg);
                        m_alarmMsgList.Add(alarmMsg);
                    }

                }
                //debug
                //MessageBox.Show(m_alarmMsgList.Count.ToString());
                br.Close();
                fs.Close();
                return true;
            }
            else
            {
                br.Close();
                fs.Close();
                return false;
            }
        }

        public static T GetObject<T>(byte[] data, int size)
        {
            Contract.Assume(size == Marshal.SizeOf(typeof(T)));
            IntPtr ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.Copy(data, 0, ptr, size);
                return (T)Marshal.PtrToStructure(ptr, typeof(T));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

        }

        public static byte[] GetData(object obj)
        {
            int size = Marshal.SizeOf(obj.GetType());
            byte[] data = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.StructureToPtr(obj, ptr, true);
                Marshal.Copy(ptr, data, 0, size);
                return data;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static bool GetWorkMsg()
        {
            //m_workHead_Msg_Map = new Dictionary<WORK_INFO_HEAD, List<WORK_INFO_MESSAGE>>();

            #region
            //MessageBox.Show(m_workFileNameList.Count.ToString());
            foreach (var workFile in m_workFileNameList)
            {

                List<WORK_INFO_MESSAGE> list = new List<WORK_INFO_MESSAGE>();
                FileStream fs = new FileStream(m_dirPath + @"\" + workFile, FileMode.Open);
                BinaryReader br = new BinaryReader(fs, Encoding.ASCII);
                
                WORK_INFO_HEAD alarmHead = new WORK_INFO_HEAD();
                int len_head = Marshal.SizeOf(alarmHead);
                byte[] buffer = new byte[len_head];
                #region
                if (fs == null)
                {
                    MessageBox.Show("打开报警文件失败！");
                    fs.Close();
                    br.Close();
                    return false;
                }
                #endregion
                //if (VerifyField(buffer))   //暂时屏蔽
                if (true)
                {
                    br.Read(buffer, 0, len_head);
                    alarmHead = GetObject<WORK_INFO_HEAD>(buffer, len_head);
                    m_lastWorkHead = alarmHead;         //保留最后一个工作信息头，作为最新的信息头，刷新到app基本信息中
                    #region
                    //记得到时候取消屏蔽
                    //if (!VerifyField(buffer))   //为了打开文件将校验屏蔽掉
                    //{
                    //    fs.Close();
                    //    br.Close();
                    //    return false;           
                    //}
                    #endregion
                    WORK_INFO_MESSAGE workDataMsg = new WORK_INFO_MESSAGE();
                    int len_msg = Marshal.SizeOf(workDataMsg);
                    byte[] buffer_msg = new byte[len_msg];

                    while (br.Read(buffer_msg, 0, len_msg) > 0)
                    {
                        //校验每一个字段 
                        //if (VerifyWorkDataMsg(buffer_msg))           //这里为了能读取字段，将校验屏蔽掉
                        {
                            workDataMsg = GetObject<WORK_INFO_MESSAGE>(buffer_msg, len_msg);
                            list.Add(workDataMsg);
                            m_lastWorkMsg = workDataMsg;//保留最后一个工作信息，作为最新的信息，刷新到app基本信息中
                        }
                    }
                    m_workHead_Msg_Map[alarmHead] = list;
                    //m_workHead_Msg_Map.Add(alarmHead,list);
                    fs.Close();
                    br.Close();
                    
                }
                //else
                //{
                //    fs.Close();
                //    br.Close();
                //    
                //}
            }
            #endregion

            return true;
        }

        public static bool VerifyField(byte[] buffer)
        {
            int len = Convert.ToInt32(buffer[0]);
            len -= 48;
            //MessageBox.Show(len.ToString());
            if (len > buffer.Length)
            {
                //MessageBox.Show("出事了!");
                return false;
            }
            int sum = 256 * Convert.ToInt32(buffer[len + 1]) + Convert.ToInt32(buffer[len + 2]); //sum1+sum2转成和
            int tmp = 0;
            for (int i = 0; i <= len; i++)
            {
                tmp += Convert.ToInt32(buffer[i]);
            }
            if (tmp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyAlarmMsg(byte[] buffer)
        {
            int len = buffer.Length;
            int tmp = 0;
            int sum = 256 * Convert.ToInt32(buffer[len - 2]) + Convert.ToInt32(buffer[len - 1]);
            if (len != ALARM_MSG_LEN)  //alarmMsg长度为16字节
            {
                return false;
            }
            for (int i = 0; i <= len - 3; i++)
            {
                tmp += Convert.ToInt32(buffer[i]);
            }
            if (sum == tmp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyWorkDataMsg(byte[] buffer)
        {
            int len = buffer.Length;
            int tmp = 0;
            int sum = 256 * Convert.ToInt32(buffer[len - 2]) + Convert.ToInt32(buffer[len - 1]);
            if (len != WORKDATA_MSG_LEN)  //workDataMsg长度为64字节
            {
                return false;
            }
            for (int i = 0; i <= len - 3; i++)
            {
                tmp += Convert.ToInt32(buffer[i]);
            }
            if (sum == tmp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string AlarmCode2Str(byte code)
        {
            int nCode = Convert.ToInt32(code);
            string str = "";
            switch (nCode)
            {
                case 0:
                    str = "氧浓度传感器故障";
                    break;
                case 1:
                    str = "流量传感器故障";
                    break;
                case 2:
                    str = "环境温度传感器故障";
                    break;
                case 3:
                    str = "驱动板温度传感器故障";
                    break;
                case 4:
                    str = "加热盘温度传感器故障";
                    break;
                case 5:
                    str = "散热风扇故障";
                    break;
                case 6:
                    str = "EEPROM校验失败";
                    break;
                case 7:
                    str = "出气口温度传感器故障";
                    break;
                case 8:
                    str = "患者端温度传感器故障";
                    break;
                default:
                    str = "未识别的错误";
                    break;
            }
            return str;
        }
    }


    public class LogRec
    {

    }
    
}
