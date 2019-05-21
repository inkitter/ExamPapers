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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private DataTable AnalysisDT(DataTable dt)
        {
            var dtAna = new DataTable();
            dtAna.Columns.Add("题型");
            dtAna.Columns.Add("数量");
            foreach (DataRow line in dt.Rows)
            {
                var type=line[1].ToString();
                if (!dictType.ContainsKey(type))
                {
                    dictType.Add(type, 1);
                }
                else
                {
                    dictType[type]++;
                }
            }
            foreach (KeyValuePair<string,int> line in dictType)
            {
                DataRow r = dtAna.NewRow();
                r["题型"] = line.Key;
                r["数量"] = line.Value;
                dtAna.Rows.Add(r);
            }
            return dtAna;
        }
        private void GetAllID()
        {
            foreach (string ty in dictType.Keys)
            {
                List<string> lstLS = new List<string>();
                foreach (DataRow dr in dtData.Rows)
                    if (dr["题型"].ToString() == ty)
                    {
                        lstLS.Add(dr["ID"].ToString());
                    }
                dictTypeID.Add(ty, lstLS);
            }
        }
        private DataTable GenPreSettings()
        {
            DataTable preSetting = new DataTable();
            preSetting.Columns.Add("题型");
            preSetting.Columns.Add("数量");
            preSetting.Columns.Add("分值");
            preSetting.Columns.Add("总分");

            foreach (KeyValuePair<string, int> line in dictType)
            {
                DataRow r = preSetting.NewRow();
                r["题型"] = line.Key;
                r["数量"] = line.Value;
                preSetting.Rows.Add(r);
            }
            return preSetting;
        }
        
        private void BtnReadCSV_Click(object sender, EventArgs e)
        {
            dictType.Clear();
            dtData = Tools.ReadCSV(txtCSVPath.Text);
            dtSum = AnalysisDT(dtData);
            dfData.DataSource = dtData;
            dfSum.DataSource = dtSum;
            dfSetting.DataSource = GenPreSettings();
            GetAllID();
            dictData = Tools.InitdictData(dtData);
            Mypaper = new Paper(dtDSettings);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private DataTable dtData,dtSum;
        private Dictionary<string, int> dictType = new Dictionary<string, int>();
        private Dictionary<string, List<string>> dictTypeID = new Dictionary<string, List<string>>();

        private void BtnGenID_Click(object sender, EventArgs e)
        {

        }

        private void DfSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtDSettings = GetDataTableFromDGV(dfSetting);
        }

        private Dictionary<string, SingleQuest> dictData = new Dictionary<string, SingleQuest>();
        private Paper Mypaper;
        private DataTable dtDSettings;
    }

    
}
