using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;   //调用WINDOWS API函数时要用到
using Microsoft.Win32;
using HookINCS;  //写入注册表时要用到
namespace KeyBoardNotification
{
    public partial class Setting : DevExpress.XtraEditors.XtraForm
    {
        #region - 变量 -
        private Hook hook;
        int keyCount = 0;
        int mouseCount = 0;
        int mouseScoll = 0;

        private Point currPos, newPos, fromPos, fromNewPos;

        private bool IsMouseDown = false;

        #endregion - 变量 -
        public Setting()
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height+5;
            this.Left = Screen.PrimaryScreen.Bounds.Width-5;
            this.Width = 300;
            this.Height = 100;
            InitializeComponent();
            
        }
      
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
             { labelKeyCount.Text = "Key:" + (keyCount++); }
        }
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void OnMouseClick(object sender,MouseEventArgs e) 
        {
            if(e.Clicks!=0)
            {
                labelMouseCount.Text = "Click:"+mouseCount++.ToString();
            }
           
        }
        private void OnMouseScroll(object sender, MouseEventArgs e)
        {
            
            if (e.Delta != 0)
            {
                labelComboCount.Text = "Scroll:" + (mouseScoll++);
            }
        }
        private void miniBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //确定当前位置
                IsMouseDown = true;
                currPos = Control.MousePosition;
                fromPos = Location;
            }
        }

        private void miniBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                //确定新位置
                newPos = Control.MousePosition;
                fromNewPos.X = newPos.X - currPos.X + fromPos.X;
                fromNewPos.Y = newPos.Y - currPos.Y + fromPos.Y;
                Location = fromNewPos;
                fromPos = fromNewPos;
                currPos = newPos;
            }
        }

        private void miniBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;
            }
        }
        /// <summary>
        /// 打开统计和监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoniSwitch_Toggled(object sender, EventArgs e)
        {
            if (MoniSwitch.IsOn)
            {
                hook = Hook.GetInstance();
                hook.OnKeyPress += new KeyEventHandler(OnKeyDown);
                hook.OnMouseUp += new MouseEventHandler(OnMouseUp);
                hook.OnMouseMove += new MouseEventHandler(OnMouseUp);
                hook.OnMouseDown += new MouseEventHandler(OnMouseUp);
                hook.OnMouseClick += new MouseEventHandler(OnMouseClick);
                hook.InstallAllHook();
            }
            else 
            { 
                hook.UninstallAllHook(); 
            }
        }
        /// <summary>
        /// 播放提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoundSwitch_Toggled(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 输入特效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EffectSwitch_Toggled(object sender, EventArgs e)
        {

        }

        private void minimalButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;  //不显示在系统任务栏
            notifyIcon1.Visible = true;  //托盘图标可见
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;  //显示在系统任务栏
                this.WindowState = FormWindowState.Normal;  //还原窗体
                notifyIcon1.Visible = false;  //托盘图标隐藏
            }
        }

    }
}