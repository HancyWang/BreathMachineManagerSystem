using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreathingMachine
{
    //病人信息结构体
    public struct PATIENT_INFO
    {
        public string name;
        public string age;
        public string gender;
        public string height;
        public string weight;
        public string phoneNum;
        public string adress;
    }
    //定义委托
    public delegate void PatientInfoHandler(PATIENT_INFO info);
    public partial class Form_PatientInfo : Form
    {

        public Form_PatientInfo()
        {
            InitializeComponent();
        }
        //实例化病人信息委托
        public event PatientInfoHandler PatientInfo;

        private void button_ok_Click(object sender, EventArgs e)
        {
            PATIENT_INFO info = new PATIENT_INFO();
            info.name = this.textBox_name.Text;
            info.age = this.textBox_age.Text;
            info.gender = this.radioButton_male.Checked?"男":"女";
            info.height = this.textBox_height.Text;
            info.weight = this.textBox_weight.Text;
            info.phoneNum = this.textBox_phoneNum.Text;
            info.adress = this.textBox_adress.Text;
            
            if ("" == info.name || "" == info.age || "" == info.height || "" == info.weight || "" == info.phoneNum || "" == info.adress)
            {
                MessageBox.Show("请将信息填写完整！");
                return;
            }

            if (PatientInfo != null)//判断事件是否为空
            {
                PatientInfo(info);//执行委托实例  
                this.DialogResult = DialogResult.OK;
                this.Close();
            }  
           
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_PatientInfo_Load(object sender, EventArgs e)
        {
            this.radioButton_male.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
