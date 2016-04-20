using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace KeyUsageStaticstics
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitPivotGrid();
            BindChart();
        }
        /// <summary>
        /// 绑定图
        /// </summary>
        void BindChart()
        {
            chartControl.DataSource = pivotGridControl;
        }
        /// <summary>
        /// 初始化表格
        /// </summary>
        void InitPivotGrid()
        {
            // Change this property to transpose the chart.
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            pivotGridControl.BeginUpdate();
            pivotGridControl.DataSource = GetDBData("SalesPerson");
            SetFilter();
            pivotGridControl.EndUpdate();
            SetSelection();
        }
        /// <summary>
        /// 筛选
        /// </summary>
        void SetFilter()
        {
            fieldProductName.FilterValues.SetValues(new object[] {
                "鼠标",
                "字母",
                "数字",
                "符号",
                "功能",
                "组合",
                "方向",
                "回车"
            }, PivotFilterType.Included, true);
            fieldOrderYear.FilterValues.SetValues(new object[] { 1995 }, PivotFilterType.Included, true);
        }
        /// <summary>
        /// 排序
        /// </summary>
        void SetSelection()
        {
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chocolade" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chai" });
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        IList GetXMLData(string tableName)
        {
            var xmlFileName = FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwindSalesPerson.xml");
            if (string.IsNullOrEmpty(xmlFileName))
                return null;
            using (DataSet dataSet = new DataSet())
            {
                dataSet.ReadXml(xmlFileName);
                return dataSet.Tables[tableName].DefaultView;
            }
        }
        /// <summary>
        /// 查询本地数据库存储数据
        /// </summary>
        /// <param name="ColName"></param>
        /// <returns></returns>
        IList GetDBData(string ColName) 
        {
            return null;
        }
        /// <summary>
        /// 保存统计数据到数据库
        /// </summary>
        /// <returns></returns>
        public bool SaveData() {
            return false;
        }

    }
}
