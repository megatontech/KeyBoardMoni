namespace KeyUsageStaticstics
{
    partial class Dashboard1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.cardDashboardItem1 = new DevExpress.DashboardCommon.CardDashboardItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // cardDashboardItem1
            // 
            this.cardDashboardItem1.ComponentName = "cardDashboardItem1";
            this.cardDashboardItem1.DataItemRepository.Clear();
            this.cardDashboardItem1.IgnoreMasterFilters = false;
            this.cardDashboardItem1.Name = "Cards 1";
            this.cardDashboardItem1.ShowCaption = true;
            // 
            // chartDashboardItem1
            // 
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // pieDashboardItem1
            // 
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Pies 1";
            this.pieDashboardItem1.NamesRepository.Clear();
            this.pieDashboardItem1.ShowCaption = true;
            // 
            // Dashboard1
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.cardDashboardItem1,
            this.chartDashboardItem1,
            this.pieDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 50.030769230769231D;
            dashboardLayoutItem2.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem2.Weight = 49.969230769230769D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.Weight = 66.707616707616708D;
            dashboardLayoutItem3.DashboardItem = this.cardDashboardItem1;
            dashboardLayoutItem3.Weight = 33.292383292383292D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.CardDashboardItem cardDashboardItem1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
    }
}
