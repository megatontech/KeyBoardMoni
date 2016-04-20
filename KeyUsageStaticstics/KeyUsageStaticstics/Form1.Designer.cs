using DevExpress.XtraPivotGrid;

namespace KeyUsageStaticstics
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(14, 13);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1237, 687);
            this.splitContainerControl1.SplitterPosition = 299;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldExtendedPrice,
            this.fieldOrderYear,
            this.fieldOrderMonth});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(1237, 383);
            this.pivotGridControl.TabIndex = 2;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 155;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Order Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.True;
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldOrderMonth
            // 
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 0;
            this.fieldOrderMonth.Caption = "Order Month";
            this.fieldOrderMonth.FieldName = "OrderDate";
            this.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.Name = "fieldOrderMonth";
            this.fieldOrderMonth.UnboundFieldName = "fieldOrderDate";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesDataMember = "Series";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl.Size = new System.Drawing.Size(1237, 299);
            this.chartControl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 713);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Text = "Data Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private PivotGridControl pivotGridControl;
        private PivotGridField fieldProductName;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldOrderYear;
        private PivotGridField fieldOrderMonth;
        private DevExpress.XtraCharts.ChartControl chartControl;

        #endregion
    }
}
