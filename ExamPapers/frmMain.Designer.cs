namespace ExamPapers
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dfSetting = new System.Windows.Forms.DataGridView();
            this.txtCSVPath = new System.Windows.Forms.TextBox();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.dfData = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dfSum = new System.Windows.Forms.DataGridView();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dfSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dfSetting
            // 
            this.dfSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfSetting.Location = new System.Drawing.Point(383, 333);
            this.dfSetting.Name = "dfSetting";
            this.dfSetting.RowTemplate.Height = 30;
            this.dfSetting.Size = new System.Drawing.Size(511, 409);
            this.dfSetting.TabIndex = 7;
            this.dfSetting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DfSetting_CellValueChanged);
            // 
            // txtCSVPath
            // 
            this.txtCSVPath.Location = new System.Drawing.Point(138, 10);
            this.txtCSVPath.Name = "txtCSVPath";
            this.txtCSVPath.Size = new System.Drawing.Size(756, 28);
            this.txtCSVPath.TabIndex = 8;
            this.txtCSVPath.Text = "test.csv";
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.Location = new System.Drawing.Point(32, 10);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(100, 29);
            this.btnReadCSV.TabIndex = 9;
            this.btnReadCSV.Text = "读取";
            this.btnReadCSV.UseVisualStyleBackColor = true;
            this.btnReadCSV.Click += new System.EventHandler(this.BtnReadCSV_Click);
            // 
            // dfData
            // 
            this.dfData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfData.Location = new System.Drawing.Point(32, 45);
            this.dfData.Name = "dfData";
            this.dfData.RowHeadersWidth = 20;
            this.dfData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dfData.RowTemplate.Height = 14;
            this.dfData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dfData.Size = new System.Drawing.Size(862, 268);
            this.dfData.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(744, 777);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // dfSum
            // 
            this.dfSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dfSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfSum.Location = new System.Drawing.Point(32, 333);
            this.dfSum.Name = "dfSum";
            this.dfSum.RowHeadersWidth = 15;
            this.dfSum.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dfSum.RowTemplate.Height = 20;
            this.dfSum.RowTemplate.ReadOnly = true;
            this.dfSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dfSum.Size = new System.Drawing.Size(318, 409);
            this.dfSum.TabIndex = 12;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(992, 161);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(312, 28);
            this.txtOutput.TabIndex = 13;
            // 
            // btnGenID
            // 
            this.btnGenID.Location = new System.Drawing.Point(543, 777);
            this.btnGenID.Name = "btnGenID";
            this.btnGenID.Size = new System.Drawing.Size(150, 45);
            this.btnGenID.TabIndex = 14;
            this.btnGenID.Text = "选ID";
            this.btnGenID.UseVisualStyleBackColor = true;
            this.btnGenID.Click += new System.EventHandler(this.BtnGenID_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 871);
            this.Controls.Add(this.btnGenID);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.dfSum);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dfData);
            this.Controls.Add(this.btnReadCSV);
            this.Controls.Add(this.txtCSVPath);
            this.Controls.Add(this.dfSetting);
            this.Name = "frmMain";
            this.Text = "试卷生成器";
            ((System.ComponentModel.ISupportInitialize)(this.dfSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dfSetting;
        private System.Windows.Forms.TextBox txtCSVPath;
        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.DataGridView dfData;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dfSum;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenID;
    }
}

