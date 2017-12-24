using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathingMachine
{
    class LanguageMngr
    {
        public static string pls_enter_right_usrname_pwd()
        {
            if(m_language==LANGUAGE.CHINA)
            {
                return "请输入正确的用户名和密码";
            }
            else if(m_language==LANGUAGE.ENGLISH)
            {
                return "Please enter the right username and password！";
            }
            else
            {
                return "";
            }
        }

        public static string no_data()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "无数据！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "No data!";
            }
            else
            {
                return "";
            }
        }

        public static string u_r_already_in_eng_mode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "您已经在工程师模式！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "You are already in engineer mode!";
            }
            else
            {
                return "";
            }
        }

        public static string welcom_enterinto_eng_mode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "欢迎进入工程师模式！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Welcome to engineer mode!";
            }
            else
            {
                return "";
            }
        }

        public static string adault_or_child(byte bt)
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return Convert.ToBoolean(bt) ? "儿童" : "成人";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return Convert.ToBoolean(bt) ? "Child" : "Adault";
            }
            else
            {
                return "";
            }
        }

        //if(LanguageMngr.m_language==LANGUAGE.CHINA)
        //    {
        //        str = Convert.ToBoolean(bt) ? "雾化" : "湿化";
        //    }
        //    else if(LanguageMngr.m_language==LANGUAGE.ENGLISH)
        //    {
        //        str = Convert.ToBoolean(bt) ? "Atomization" : "Humidifying";
        //    }
        //    else
        //    {
        //        //等有其他语言再添加
        //    }
        public static String humidy_or_atomiz(byte bt)
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return Convert.ToBoolean(bt) ? "雾化" : "湿化";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return Convert.ToBoolean(bt) ? "Atomization" : "Humidifying";
            }
            else
            {
                return "";
            }
        }


        public static LANGUAGE m_language;  //0-中文,1-英语，，其它待添加
        public static void ShowPanel()
        {
            
        }
    }
}
