using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathingMachine
{
    public struct DETAIL_CHART_INFO
    {
        public DateTime tm;
        public int patient_tmp;
        public int air_outlet_tmp;
        public int flow;
        public int oxy_concentration;
    }

    public struct CHART_SIZE
    {
        public int Height;
        public int Width;
    }

    public enum CHARTTYPE
    {
        PATIENT_TMP,
        AIR_OUTLET_TMP,
        FLOW,
        OXY_CONCENTRATION
    }

    public class BasicInfo
    {

    }


    //以下是从C++头文件通过软件转换过来的

    public partial class NativeConstants
    {

        /// ALARM_MSG_LEN -> 16
        public const int ALARM_MSG_LEN = 16;

        /// WORKDATA_MSG_LEN -> 64
        public const int WORKDATA_MSG_LEN = 64;

        /// FILE_PATH_MAX -> 512
        public const int FILE_PATH_MAX = 512;

        /// BMP_UNSELECTED -> "vincent_medical.bmp"
        public const string BMP_UNSELECTED = "vincent_medical.bmp";

        /// BMP_SELECTED -> "selected.bmp"
        public const string BMP_SELECTED = "selected.bmp";

        /// ALARM_RUNNING_MODE_HUMIDIFY -> 0
        public const int ALARM_RUNNING_MODE_HUMIDIFY = 0;

        /// ALARM_RUNNING_MODE_AUTOMIZATION -> 1
        public const int ALARM_RUNNING_MODE_AUTOMIZATION = 1;

        /// ALARM_ERR_CODE_DATA_0 -> "氧浓度传感器故障"
        public const string ALARM_ERR_CODE_DATA_0 = "氧浓度传感器故障";

        /// ALARM_ERR_CODE_DATA_1 -> "流量传感器故障"
        public const string ALARM_ERR_CODE_DATA_1 = "流量传感器故障";

        /// ALARM_ERR_CODE_DATA_2 -> "环境温度传感器故障"
        public const string ALARM_ERR_CODE_DATA_2 = "环境温度传感器故障";

        /// ALARM_ERR_CODE_DATA_3 -> "驱动板温度传感器故障"
        public const string ALARM_ERR_CODE_DATA_3 = "驱动板温度传感器故障";

        /// ALARM_ERR_CODE_DATA_4 -> "加热盘温度传感器故障"
        public const string ALARM_ERR_CODE_DATA_4 = "加热盘温度传感器故障";

        /// ALARM_ERR_CODE_DATA_5 -> "散热风扇故障"
        public const string ALARM_ERR_CODE_DATA_5 = "散热风扇故障";

        /// ALARM_ERR_CODE_DATA_6 -> "EEPROM校验失败"
        public const string ALARM_ERR_CODE_DATA_6 = "EEPROM校验失败";

        /// ALARM_ERR_CODE_DATA_7 -> "出气口温度传感器故障"
        public const string ALARM_ERR_CODE_DATA_7 = "出气口温度传感器故障";

        /// ALARM_ERR_CODE_DATA_8 -> "患者端温度传感器故障"
        public const string ALARM_ERR_CODE_DATA_8 = "患者端温度传感器故障";

        /// ALARM_ERR_CODE_DATA_9 -> ""
        public const string ALARM_ERR_CODE_DATA_9 = "";

        /// ALARM_ERR_CODE_DATA_10 -> ""
        public const string ALARM_ERR_CODE_DATA_10 = "";

        /// ALARM_ERR_CODE_DATA_11 -> ""
        public const string ALARM_ERR_CODE_DATA_11 = "";

        /// ALARM_ERR_CODE_DATA_12 -> ""
        public const string ALARM_ERR_CODE_DATA_12 = "";

        /// ALARM_ERR_CODE_DATA_13 -> ""
        public const string ALARM_ERR_CODE_DATA_13 = "";

        /// ALARM_ERR_CODE_DATA_14 -> ""
        public const string ALARM_ERR_CODE_DATA_14 = "";

        /// ALARM_ERR_CODE_DATA_15 -> ""
        public const string ALARM_ERR_CODE_DATA_15 = "";

        /// ALARM_ERR_CODE_DATA_16 -> ""
        public const string ALARM_ERR_CODE_DATA_16 = "";

        /// ALARM_ERR_CODE_DATA_17 -> ""
        public const string ALARM_ERR_CODE_DATA_17 = "";

        /// ALARM_ERR_CODE_DATA_18 -> ""
        public const string ALARM_ERR_CODE_DATA_18 = "";

        /// ALARM_ERR_CODE_DATA_19 -> ""
        public const string ALARM_ERR_CODE_DATA_19 = "";

        /// ALARM_ERR_CODE_DATA_20 -> "人体端超温"
        public const string ALARM_ERR_CODE_DATA_20 = "人体端超温";

        /// ALARM_ERR_CODE_DATA_21 -> "缺水"
        public const string ALARM_ERR_CODE_DATA_21 = "缺水";

        /// ALARM_ERR_CODE_DATA_22 -> "加热线脱落"
        public const string ALARM_ERR_CODE_DATA_22 = "加热线脱落";

        /// ALARM_ERR_CODE_DATA_23 -> "探头脱落"
        public const string ALARM_ERR_CODE_DATA_23 = "探头脱落";

        /// ALARM_ERR_CODE_DATA_24 -> "高氧浓度"
        public const string ALARM_ERR_CODE_DATA_24 = "高氧浓度";

        /// ALARM_ERR_CODE_DATA_25 -> "低氧浓度"
        public const string ALARM_ERR_CODE_DATA_25 = "低氧浓度";

        /// ALARM_ERR_CODE_DATA_26 -> "泄露"
        public const string ALARM_ERR_CODE_DATA_26 = "泄露";

        /// ALARM_ERR_CODE_DATA_27 -> "堵塞"
        public const string ALARM_ERR_CODE_DATA_27 = "堵塞";

        /// ALARM_ERR_CODE_DATA_28 -> "达不到流量"
        public const string ALARM_ERR_CODE_DATA_28 = "达不到流量";

        /// ALARM_ERR_CODE_DATA_29 -> "达不到温度"
        public const string ALARM_ERR_CODE_DATA_29 = "达不到温度";

        /// ALARM_ERR_CODE_DATA_30 -> "湿化罐未安装"
        public const string ALARM_ERR_CODE_DATA_30 = "湿化罐未安装";

        /// ALARM_ERR_CODE_DATA_31 -> "运行中电源断开"
        public const string ALARM_ERR_CODE_DATA_31 = "运行中电源断开";

        /// ALARM_ERR_CODE_DATA_32 -> "运行中SD卡拔出"
        public const string ALARM_ERR_CODE_DATA_32 = "运行中SD卡拔出";
    }

    public enum LANGUAGE
    {

        CHINA,

        ENGLISH,

        JAPAN,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ALARM_INFO_HEAD
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ALARM_FLAG;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MACHINETYPE;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SN;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SOFTWAR_VER;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_0;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_1;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_2;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_3;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_4;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_5;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_6;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_7;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_8;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_9;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string RESERVE_10;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ALARM_NUM;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ALARM_INFO_MESSAGE
    {

        /// char
        public byte YEAR1;

        /// char
        public byte YEAR2;

        /// char
        public byte MONTH;

        /// char
        public byte DAY;

        /// char
        public byte HOUR;

        /// char
        public byte MINUTE;

        /// char
        public byte SECOND;

        /// char
        public byte RUNNIN_MODE;

        /// char
        public byte ALARM_CODE;

        /// char
        public byte ALARM_DATA_L;

        /// char
        public byte ALARM_DATA_H;

        /// char
        public byte RESERVE_0;

        /// char
        public byte RESERVE_1;

        /// char
        public byte RESERVE_2;

        /// char
        public byte CHECKSUM_L;

        /// char
        public byte CHECHSUM_H;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct WORK_INFO_HEAD
    {

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string WORK_FLAG;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string MACHINETYPE;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string SN;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string SOFTWAR_VER;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_0;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_1;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_2;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_3;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_4;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_5;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_6;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_7;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_8;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_9;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string RESERVE_10;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string WORKDATA_NUM;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct WORK_INFO_MESSAGE
    {

        /// char
        public byte YEAR1;

        /// char
        public byte YEAR2;

        /// char
        public byte MONTH;

        /// char
        public byte DAY;

        /// char
        public byte HOUR;

        /// char
        public byte MINUTE;

        /// char
        public byte SECOND;

        /// char
        public byte SET_MODE;

        /// char
        public byte SET_TEMP;

        /// char
        public byte SET_FLOW;

        /// char
        public byte SET_HIGH_OXYGEN_ALARM;

        /// char
        public byte SET_LOW_OXYGEN_ALARM;

        /// char
        public byte SET_ATOMIZATION_LEVEL;

        /// char
        public byte SET_ATOMIZATION_TIME;

        /// char
        public byte SET_ADULT_OR_CHILDE;

        /// char
        public byte DATA_PATIENT_TEMP;

        /// char
        public byte DATA_AIR_OUTLET_TEMP;

        /// char
        public byte DATA_HEATING_PLATE_TMP;

        /// char
        public byte DATA_ENVIRONMENT_TMP;

        /// char
        public byte DATA_DRIVERBOARD_TMP;

        /// char
        public byte DATA_FLOW;

        /// char
        public byte DATA_OXYGEN_CONCENTRATION;

        /// char
        public byte DATA_AIR_PRESSURE;

        /// char
        public byte DATA_LOOP_TYPE;

        /// char
        public byte DATA_FAULT_STATUS_1;

        /// char
        public byte DATA_FAULT_STATUS_2;

        /// char
        public byte DATA_ATOMIZ_DACVALUE_L;

        /// char
        public byte DATA_ATOMIZ_DACVALUE_H;

        /// char
        public byte DATA_ATOMIZ_ADCVALUE_L;

        /// char
        public byte DATA_ATOMIZ_ADCVALUE_H;

        /// char
        public byte DATA_LOOP_HEATING_PWM_L;

        /// char
        public byte DATA_LOOP_HEATING_PWM_H;

        /// char
        public byte DATA_LOOP_HEATING_ADC_L;

        /// char
        public byte DATA_LOOP_HEATING_ADC_H;

        /// char
        public byte DATA_HEATING_PLATE_PWM_L;

        /// char
        public byte DATA_HEATING_PLATE_PWM_H;

        /// char
        public byte DATA_HEATING_PLATE_ADC_L;

        /// char
        public byte DATA_HEATING_PLATE_ADC_H;

        /// char
        public byte DATA_MAIN_MOTOR_DRIVER_L;

        /// char
        public byte DATA_MAIN_MOTOR_DRIVER_H;

        /// char
        public byte DATA_MAIN_MOTOR_SPEED_L;

        /// char
        public byte DATA_MAIN_MOTOR_SPEED_H;

        /// char
        public byte DATA_PRESS_SENSOR_ADC_L;

        /// char
        public byte DATA_PRESS_SENSOR_ADC_H;

        /// char
        public byte DATA_WATERLEVEL_SENSOR_HADC_L;

        /// char
        public byte DATA_WATERLEVEL_SENSOR_HADC_H;

        /// char
        public byte DATA_WATERLEVEL_SENSOR_LADC_L;

        /// char
        public byte DATA_WATERLEVEL_SENSOR_LADC_H;

        /// char
        public byte DATA_FAN_DRIVER_L;

        /// char
        public byte DATA_FAN_DRIVER_H;

        /// char
        public byte DATA_FAN_SPEED_L;

        /// char
        public byte DATA_FAN_SPEED_H;

        /// char
        public byte RESERVE_0;

        /// char
        public byte RESERVE_1;

        /// char
        public byte RESERVE_2;

        /// char
        public byte RESERVE_3;

        /// char
        public byte RESERVE_4;

        /// char
        public byte RESERVE_5;

        /// char
        public byte RESERVE_6;

        /// char
        public byte RESERVE_7;

        /// char
        public byte RESERVE_8;

        /// char
        public byte RESERVE_9;

        /// char
        public byte CHECKSUM_L;

        /// char
        public byte CHECKSUM_H;
    }




}
