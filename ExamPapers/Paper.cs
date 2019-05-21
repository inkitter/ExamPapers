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

namespace ExamPapers
{
    public class Tools
    {
        public static DataTable ReadCSV(string filePath,char split=',')
        {
            //读取CSV转化为DataTable
            var dt = new DataTable();
            foreach (var headerLine in File.ReadLines(filePath).Take(1))
            {
                foreach (var headerItem in headerLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dt.Columns.Add(headerItem.Trim());
                }
            }
            foreach (var line in File.ReadLines(filePath).Skip(1))
            {
                dt.Rows.Add(line.Split(split));
            }
            return dt;
        }

        public static Dictionary<string, SingleQuest> InitdictData(DataTable dtData)
        {
            //按照ID、题目类建立词典，总数据库
            Dictionary<string, SingleQuest> dictData = new Dictionary<string, SingleQuest>();
            foreach (DataRow dr in dtData.Rows)
            {
                SingleQuest dd = new SingleQuest(dr);
                if (!dictData.ContainsKey(dr["ID"].ToString()))
                {
                    dictData.Add(dr["ID"].ToString(), dd);
                }
            }
            return dictData;
        }
    }

    public class SingleQuest
    //单个题目的类
    {
        public SingleQuest(DataRow dr)
        {
            ID = dr["ID"].ToString();
            Difficulty = dr["难度系数"].ToString();
            Char = dr["章节"].ToString();
            QuestType = dr["题型"].ToString();
            A1 = dr["1"].ToString();
            Quest = dr["题干"].ToString();
        }
        public string ID { get; set; }
        public string Difficulty { get; set; }
        public string Char { get; set; }
        public string QuestType { get; set; }
        public string Quest { get; set; }
        public string A1 { get; set; }
        public string GetQuest(int No)
        {
            string re = "";
            re = No.ToString() + ". " + Quest + "\n" + A1;
            return re;
        }
    }
    public class Settings
    {
        public void SetType(string str)
        {
            type = str;
        }
        public void SetCount(string str)
        {
            count = Convert.ToUInt16(str);
        }
        public void SetScore(string str)
        {
            score = Convert.ToUInt16(str);
        }
        private string type;
        private int count;
        public int score;
    }
    public class Paper
    {
        public Paper(DataTable dtDSettings)
        {
            foreach (DataRow r in dtDSettings.Rows)
            {
                Settings set = new Settings();
                set.SetType(r["题型"].ToString());
                set.SetCount(r["数量"].ToString());
                set.SetScore(r["分值"].ToString());
            }
        }
        public Dictionary<string, Settings> dictSetting;
        public Dictionary<string, SingleQuest> dictAllQuests;
        public DataTable ShowAllQuest()
        {
            DataTable AllData = new DataTable();
            foreach(SingleQuest sq in dictAllQuests.Values)
            {

            }
            return AllData;
        }
        public List<string> GetQuestTypesList()
        {
            List<string> lst = new List<string>();

            return lst;
        }
    }
}
