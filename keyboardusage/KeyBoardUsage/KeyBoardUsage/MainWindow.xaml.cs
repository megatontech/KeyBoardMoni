using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using HookINCS;
using KeyBoardUsage.DB;
using KeyBoardUsage.Model;
using LiveCharts;

namespace KeyBoardUsage
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqliteHelper sqlhelper = new SqliteHelper();
        private Hook hook;
        private Timer timer = new Timer();
        private NotifyIcon notifyIcon = null;
        private int CurrentGifFrameCount = 0;

        public MainWindow()
        {
            timer.Interval = 5000;
            timer.Start();
            timer.Tick += new System.EventHandler(TimerTick);
            sqlhelper.InitDb();
            InitializeComponent();
            funcSeries = new SeriesCollection();
            totalSeries = new SeriesCollection(); 
            mainSeries = new SeriesCollection(); 
            ctrlSeries = new SeriesCollection();
            numberSeries = new SeriesCollection();
            initTotalChart();
            initMainChart();
            initNumberChart();
            initFuncChart();
            initCtrlChart();
            InitHooks();
            InitialTray();
        }

        #region Hooks

        private void ModifyCountVal(string key, int val)
        {
            if (DetailUsage.usageList.ContainsKey(key))
            {
                UsageCount count = DetailUsage.usageList[key];
                count.Count = val;
                DetailUsage.usageList[key] = count;
            }
            else
            {
                UsageCount count = new UsageCount();
                count.Count = val;
                count.KeyName = key;
                count.TableName = key;
                count.time = DateTime.Now;
                DetailUsage.usageList.Add(key, count);
            }
        }

        /// <summary>
        /// 按键处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (CurrentGifFrameCount != 128)
            {
                CurrentGifFrameCount = CurrentGifFrameCount + 1;
            }
            else
            {
                CurrentGifFrameCount = 0;
            }
            ChangeGifFrameDisp(CurrentGifFrameCount);
            TotalUsage.totalCount = TotalUsage.totalCount + 1;
            switch (e.KeyData)
            {
                case Keys.A: DetailUsage.A = DetailUsage.A + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_A", DetailUsage.A); break;
                case Keys.B: DetailUsage.B = DetailUsage.B + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_B", DetailUsage.B); break;
                case Keys.C: DetailUsage.C = DetailUsage.C + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_C", DetailUsage.C); break;
                case Keys.D: DetailUsage.D = DetailUsage.D + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_D", DetailUsage.D); break;
                case Keys.E: DetailUsage.E = DetailUsage.E + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_E", DetailUsage.E); break;
                case Keys.F: DetailUsage.F = DetailUsage.F + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_F", DetailUsage.F); break;
                case Keys.G: DetailUsage.G = DetailUsage.G + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_G", DetailUsage.G); break;
                case Keys.H: DetailUsage.H = DetailUsage.H + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_H", DetailUsage.H); break;
                case Keys.I: DetailUsage.I = DetailUsage.I + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_I", DetailUsage.I); break;
                case Keys.J: DetailUsage.J = DetailUsage.J + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_J", DetailUsage.J); break;
                case Keys.K: DetailUsage.K = DetailUsage.K + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_K", DetailUsage.K); break;
                case Keys.L: DetailUsage.L = DetailUsage.L + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_L", DetailUsage.L); break;
                case Keys.M: DetailUsage.M = DetailUsage.M + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_M", DetailUsage.M); break;
                case Keys.N: DetailUsage.N = DetailUsage.N + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_N", DetailUsage.N); break;
                case Keys.O: DetailUsage.O = DetailUsage.O + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_O", DetailUsage.O); break;
                case Keys.P: DetailUsage.P = DetailUsage.P + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_P", DetailUsage.P); break;
                case Keys.Q: DetailUsage.Q = DetailUsage.Q + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_Q", DetailUsage.Q); break;
                case Keys.R: DetailUsage.R = DetailUsage.R + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_R", DetailUsage.R); break;
                case Keys.S: DetailUsage.S = DetailUsage.S + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_S", DetailUsage.S); break;
                case Keys.T: DetailUsage.T = DetailUsage.T + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_T", DetailUsage.T); break;
                case Keys.U: DetailUsage.U = DetailUsage.U + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_U", DetailUsage.U); break;
                case Keys.V: DetailUsage.V = DetailUsage.V + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_V", DetailUsage.V); break;
                case Keys.W: DetailUsage.W = DetailUsage.W + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_W", DetailUsage.W); break;
                case Keys.X: DetailUsage.X = DetailUsage.X + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_X", DetailUsage.X); break;
                case Keys.Y: DetailUsage.Y = DetailUsage.Y + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_Y", DetailUsage.Y); break;
                case Keys.Z: DetailUsage.Z = DetailUsage.Z + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.mainCount = TotalUsage.mainCount + 1; ModifyCountVal("USAGE_Z", DetailUsage.Z); break;
                case Keys.D1: DetailUsage.KEY1 = DetailUsage.KEY1 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_1", DetailUsage.KEY1); break;
                case Keys.D2: DetailUsage.KEY2 = DetailUsage.KEY2 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_2", DetailUsage.KEY2); break;
                case Keys.D3: DetailUsage.KEY3 = DetailUsage.KEY3 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_3", DetailUsage.KEY3); break;
                case Keys.D4: DetailUsage.KEY4 = DetailUsage.KEY4 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_4", DetailUsage.KEY4); break;
                case Keys.D5: DetailUsage.KEY5 = DetailUsage.KEY5 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_5", DetailUsage.KEY5); break;
                case Keys.D6: DetailUsage.KEY6 = DetailUsage.KEY6 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_6", DetailUsage.KEY6); break;
                case Keys.D7: DetailUsage.KEY7 = DetailUsage.KEY7 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_7", DetailUsage.KEY7); break;
                case Keys.D8: DetailUsage.KEY8 = DetailUsage.KEY8 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_8", DetailUsage.KEY8); break;
                case Keys.D9: DetailUsage.KEY9 = DetailUsage.KEY9 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_9", DetailUsage.KEY9); break;
                case Keys.D0: DetailUsage.KEY0 = DetailUsage.KEY0 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.numberCount = TotalUsage.numberCount + 1; ModifyCountVal("USAGE_0", DetailUsage.KEY0); break;
                case Keys.F1: DetailUsage.F1 = DetailUsage.F1 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F1", DetailUsage.F1); break;
                case Keys.F2: DetailUsage.F2 = DetailUsage.F2 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F2", DetailUsage.F2); break;
                case Keys.F3: DetailUsage.F3 = DetailUsage.F3 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F3", DetailUsage.F3); break;
                case Keys.F4: DetailUsage.F4 = DetailUsage.F4 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F4", DetailUsage.F4); break;
                case Keys.F5: DetailUsage.F5 = DetailUsage.F5 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F5", DetailUsage.F5); break;
                case Keys.F6: DetailUsage.F6 = DetailUsage.F6 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F6", DetailUsage.F6); break;
                case Keys.F7: DetailUsage.F7 = DetailUsage.F7 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F7", DetailUsage.F7); break;
                case Keys.F8: DetailUsage.F8 = DetailUsage.F8 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F8", DetailUsage.F8); break;
                case Keys.F9: DetailUsage.F9 = DetailUsage.F9 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F9", DetailUsage.F9); break;
                case Keys.F10: DetailUsage.F10 = DetailUsage.F10 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F10", DetailUsage.F10); break;
                case Keys.F11: DetailUsage.F11 = DetailUsage.F11 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F11", DetailUsage.F11); break;
                case Keys.F12: DetailUsage.F12 = DetailUsage.F12 + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.funcCount = TotalUsage.funcCount + 1; ModifyCountVal("USAGE_F12", DetailUsage.F12); break;
                case Keys.ShiftKey: DetailUsage.ShiftKey = DetailUsage.ShiftKey + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_SHIFT", DetailUsage.ShiftKey); break;
                case Keys.CapsLock: DetailUsage.CapsLock = DetailUsage.CapsLock + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_CAPSLOCK", DetailUsage.CapsLock); break;
                case Keys.Tab: DetailUsage.Tab = DetailUsage.Tab + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_TAB", DetailUsage.Tab); break;
                case Keys.Escape: DetailUsage.Escape = DetailUsage.Escape + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_ESC", DetailUsage.Escape); break;
                case Keys.Enter: DetailUsage.Enter = DetailUsage.Enter + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_ENTER", DetailUsage.Enter); break;
                case Keys.Home: DetailUsage.Home = DetailUsage.Home + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_HOME", DetailUsage.Home); break;
                case Keys.End: DetailUsage.End = DetailUsage.End + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_END", DetailUsage.End); break;
                case Keys.PageUp: DetailUsage.PageUp = DetailUsage.PageUp + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_PAGEUP", DetailUsage.PageUp); break;
                case Keys.PageDown: DetailUsage.PageDown = DetailUsage.PageDown + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_PAGEDOWN", DetailUsage.PageDown); break;
                case Keys.ControlKey: DetailUsage.CtrlKey = DetailUsage.CtrlKey + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_CTRL", DetailUsage.PageDown); break;
                case Keys.Alt: DetailUsage.AltKey = DetailUsage.AltKey + 1; TotalUsage.totalCount = TotalUsage.totalCount + 1; TotalUsage.ctrlCount = TotalUsage.ctrlCount + 1; ModifyCountVal("USAGE_ALT", DetailUsage.PageDown); break;
                default: TotalUsage.totalCount = TotalUsage.totalCount + 1;
                    break;
                //USAGE_INSERT
                //USAGE_DELETE
                //USAGE_BACKSPACE
                //USAGE_PLUS
                //USAGE_MINUS
                //USAGE_LBRACKET
                //USAGE_RBRACKET
                //USAGE_CONLONS
                //USAGE_QUOTATION
                //USAGE_GT
                //USAGE_LT
                //USAGE_QUESTION
                //USAGE_UP
                //USAGE_DOWN
                //USAGE_LEFT
                //USAGE_RIGHT
                //USAGE_PRTSC
                //USAGE_SLASH
                //USAGE_WAVE
                //USAGE_WIN
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
        }

        private void OnMouseScroll(object sender, MouseEventArgs e)
        {
        }
        /// <summary>
        /// 注册钩子
        /// </summary>
        public void InitHooks()
        {
            hook = Hook.GetInstance();
            hook.OnKeyPress += new KeyEventHandler(OnKeyDown);
            hook.OnMouseUp += new MouseEventHandler(OnMouseUp);
            hook.OnMouseMove += new MouseEventHandler(OnMouseUp);
            hook.OnMouseDown += new MouseEventHandler(OnMouseUp);
            hook.OnMouseClick += new MouseEventHandler(OnMouseClick);
            hook.InstallAllHook();
        }

        #endregion Hooks

        #region Event

        private void ChangeGifFrameDisp(int count)
        {
            string path = System.Environment.CurrentDirectory + "/Resources/" + count + ".jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(path, UriKind.Absolute));
            img.Source = bitmap;
        }

        /// <summary>
        /// 初始化时最小化托盘
        /// </summary>
        private void InitialTray()
        {
            //隐藏主窗体
            this.Visibility = Visibility.Hidden;
            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipText = "...";
            notifyIcon.Text = "运行中~";
            System.Drawing.Icon icon1 = new System.Drawing.Icon(SystemIcons.Information, 40, 40);
            notifyIcon.Icon = icon1;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(2000);
            notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_MouseClick);
            this.StateChanged += new EventHandler(SysTray_StateChanged);
        }

        /// <summary>
        /// 鼠标单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //如果鼠标左键单击
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visibility == Visibility.Visible)
                {
                    this.Visibility = Visibility.Hidden;
                }
                else
                {
                    this.Visibility = Visibility.Visible;
                    this.Activate();
                }
            }
        }

        /// <summary>
        /// 窗体状态改变时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SysTray_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// 定时保存按键统计信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, System.EventArgs e)
        {
            //保存数据到数据库
            List<UsageCount> modelList = new List<UsageCount>();
            foreach (var val in DetailUsage.usageList.Values)
            {
                UsageCount count = new UsageCount();
                count.time = DateTime.Now;
                count.KeyName = val.KeyName;
                count.Count = val.Count;
                count.TableName = val.TableName;
                modelList.Add(count);
            }
            sqlhelper.InsertModelData(modelList);
            Dictionary<string, UsageCount> dic = new Dictionary<string, UsageCount>();
            DetailUsage.usageList = dic;
            Dictionary<string, int> totaldic = new Dictionary<string, int>();
            totaldic.Add("TOTAL", TotalUsage.totalCount);
            totaldic.Add("MAIN", TotalUsage.mainCount);
            totaldic.Add("NUMBER", TotalUsage.numberCount);
            totaldic.Add("FUNC", TotalUsage.funcCount);
            totaldic.Add("CTRL", TotalUsage.ctrlCount);
            sqlhelper.UpdateTotalCount(totaldic);
        }

        /// <summary>
        ///点击刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_Click(object sender, RoutedEventArgs e)
        {
            initTotalChart();
            initMainChart();
            initNumberChart();
            initFuncChart();
            initCtrlChart();
            TotalChart.Update(true);
            MainChart.Update(true);
            NumberChart.Update(true);
            FuncChart.Update(true);
            CtrlChart.Update(true);
        }

        #endregion Event

        #region Chart

        public SeriesCollection totalSeries { get; set; }
        
        public SeriesCollection mainSeries { get; set; }
        public SeriesCollection numberSeries { get; set; }
        public SeriesCollection funcSeries { get; set; }
        public SeriesCollection ctrlSeries { get; set; }

        private void initTotalChart()
        {
            var dic = sqlhelper.GetTotalCount();
            TotalUsage.mainCount = dic["MAIN"];
            TotalUsage.numberCount = dic["NUMBER"];
            TotalUsage.funcCount = dic["FUNC"];
            TotalUsage.ctrlCount = dic["CTRL"];
            TotalUsage.totalCount = TotalUsage.mainCount + TotalUsage.numberCount + TotalUsage.funcCount + TotalUsage.ctrlCount;
            var mainkeySeries = new PieSeries
            {
                Title = "主键盘区",
                Values = new ChartValues<double> { TotalUsage.mainCount }
            };
            var numberSeries = new PieSeries
            {
                Title = "数字键盘区",
                Values = new ChartValues<double> { TotalUsage.numberCount }
            };
            var funcSeries = new PieSeries
            {
                Title = "功能键区",
                Values = new ChartValues<double> { TotalUsage.funcCount }
            };
            var ctrlSeries = new PieSeries
            {
                Title = "编辑控制键区",
                Values = new ChartValues<double> { TotalUsage.ctrlCount }
            };
            while (totalSeries.Count > 0)
            {
                totalSeries.RemoveAt(0);
            }
            totalSeries.Add(mainkeySeries);
            totalSeries.Add(numberSeries);
            totalSeries.Add(funcSeries);
            totalSeries.Add(ctrlSeries);
            DataContext = this;
        }

        private void initMainChart()
        {
            InitializeComponent();
            
            var val = sqlhelper.GetCharCount();
            var charlesSeries = new BarSeries
            {
                Title = "字母键",
                Values = new ChartValues<double> { val[0], val[1], val[2], val[3], val[4], val[5], val[6], val[7], val[8], val[9], val[10], val[11], val[12], val[13], val[14], val[15], val[16], val[17], val[18], val[19], val[20], val[21], val[22], val[23], val[24], val[25] }
            };
            if (mainSeries.Count > 0)
            {
                mainSeries.RemoveAt(0);
            }
            mainSeries.Add(charlesSeries);
            DataContext = this;
        }

        private void initNumberChart()
        {
            InitializeComponent();
          
            var val = sqlhelper.GetNumberCount();
            var charlesSeries = new BarSeries
            {
                Title = "数字键",
                Values = new ChartValues<double> { val[0], val[1], val[2], val[3], val[4], val[5], val[6], val[7], val[8], val[9] }
            };
            if (numberSeries.Count > 0)
            {
                numberSeries.RemoveAt(0);
            }
            numberSeries.Add(charlesSeries);
            DataContext = this;
        }

        private void initFuncChart()
        {
            InitializeComponent();
            var val = sqlhelper.GetFuncCount();
            var charlesSeries = new BarSeries
            {
                Title = "功能键",
                Values = new ChartValues<double> { val[0], val[1], val[2], val[3], val[4], val[5], val[6], val[7], val[8], val[9], val[10], val[11] }
            };
            if (funcSeries.Count > 0)
            {
                funcSeries.RemoveAt(0);
            }
            funcSeries.Add(charlesSeries);
            DataContext = this;
        }

        private void initCtrlChart()
        {
            InitializeComponent();
            var charlesSeries = new BarSeries
            {
                Title = "编辑控制键",
                Values = new ChartValues<double> { 10, 11, 7, 8, 5, 4, 2, 7, 19, 20 }
            };
            if (ctrlSeries.Count > 0)
            {
                ctrlSeries.RemoveAt(0);
            }
            ctrlSeries.Add(charlesSeries);
            DataContext = this;
        }

        #endregion Chart
    }
}