using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace HookINCS
{
    /// <summary>
    /// 全局钩子类
    /// 提供事件对键盘、鼠标的消息进行拦截
    /// 您可以使用事件注册的方式通过自定义方法处理键盘、鼠标的动作
    /// 值得注意的是：您必须手动安装钩子并将自定义方法注册到事件中后，您才能对事件进行拦截
    /// </summary>
    public sealed class Hook
    {
        #region DllImport
        /// <summary>
        /// 设置钩子
        /// </summary>
        /// <param name="idHook">钩子类型，此处用整形的枚举表示</param>
        /// <param name="lpfn">钩子发挥作用时的回调函数</param>
        /// <param name="hInstance">应用程序实例的模块句柄(一般来说是你钩子回调函数所在的应用程序实例模块句柄)</param>
        /// <param name="threadId">与安装的钩子子程相关联的线程的标识符</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(
            HookType idHook,
            HookProc lpfn,
            IntPtr hInstance,
            int threadId
            );

        /// <summary>
        /// 抽掉钩子
        /// </summary>
        /// <param name="idHook">要取消的钩子的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(
            int idHook
            );

        /// <summary>
        /// 调用下一个钩子
        /// </summary>
        /// <param name="idHook">当前钩子的句柄</param>
        /// <param name="nCode">钩子链传回的参数，非0表示要丢弃这条消息，0表示继续调用钩子</param>
        /// <param name="wParam">传递的参数</param>
        /// <param name="lParam">传递的参数</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(
            int idHook,
            int nCode,
            int wParam,
            IntPtr lParam
            );

        /// <summary>
        /// 获取一个应用程序或动态链接库的模块句柄
        /// </summary>
        /// <param name="name">指定模块名，这通常是与模块的文件名相同的一个名字</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(
            string name
            );
        #endregion

        #region 单例实现相关
        static Hook() { }
        private Hook() { }

        /// <summary>
        /// 内部类，用于提供Hook类的单实例
        /// </summary>
        private class Nested
        {
            static Nested() { }
            internal static readonly Hook instance = new Hook();
        }

        ~Hook()
        {
            UninstallAllHook();
        }

        public static Hook GetInstance()
        {
            return Nested.instance;
        }
        #endregion

        #region 钩子句柄

        /// <summary>
        /// 键盘钩子句柄
        /// </summary>
        private static int kbhHook = 0;

        /// <summary>
        /// 鼠标钩子
        /// </summary>
        private static int mshHook = 0;

        /// <summary>
        /// 自定义钩子
        /// </summary>
        private static int userHook = 0;

        /// <summary>
        /// 键盘钩子回调函数
        /// </summary>
        private static HookProc kbHook;
        /// <summary>
        /// 鼠标钩子回调函数
        /// </summary>
        private static HookProc msHook;

        #endregion

        #region 提供给外界使用的事件

        /// <summary>
        /// 当键盘按键按下
        /// </summary>
        public event KeyEventHandler OnKeyDown;

        /// <summary>
        /// 当键盘某个键松开
        /// </summary>
        public event KeyEventHandler OnKeyUp;

        /// <summary>
        /// 当键盘某个键按下后松开
        /// </summary>
        public event KeyEventHandler OnKeyPress;

        // 鼠标相关
        /// <summary>
        /// 当鼠标单击
        /// </summary>
        public event MouseEventHandler OnMouseClick;
        /// <summary>
        /// 当鼠标滚动
        /// </summary>
        public event MouseEventHandler OnMouseScroll;
        /// <summary>
        /// 当鼠标双击
        /// </summary>
        public event MouseEventHandler OnMouseDoubleClick;

        /// <summary>
        /// 当鼠标某个键被按下
        /// </summary>
        public event MouseEventHandler OnMouseDown;
        //public event MouseEventHandler OnMouseEnter;
        //public event MouseEventHandler OnMouseHover;
        //public event MouseEventHandler OnMouseLeave;

        /// <summary>
        /// 当鼠标移动时(推荐具有一定经验的专业人士使用)
        /// </summary>
        public event MouseEventHandler OnMouseMove;

        /// <summary>
        /// 当鼠标某个键松开
        /// </summary>
        public event MouseEventHandler OnMouseUp;

        #endregion

        #region 安装钩子、卸载钩子的方法

        /// <summary>
        /// 安装键盘钩子(使用默认配置)
        /// </summary>
        public void InstallKeyBoardHook()
        {
            InstallKeyBoardHook(HookType.WH_KEYBOARD_LL);
        }

        /// <summary>
        /// 安装鼠标钩子(使用默认配置)
        /// </summary>
        public void InstallMouseHook()
        {
            InstallMouseHook(HookType.WH_MOUSE_LL);
        }

        /// <summary>
        /// 安装键盘和鼠标钩子(使用默认配置)
        /// </summary>
        public void InstallAllHook()
        {
            InstallKeyBoardHook();
            InstallMouseHook();
        }

        /// <summary>
        /// 使用自定义配置安装键盘钩子(推荐有一定经验的专业人士使用)
        /// </summary>
        /// <param name="type"></param>
        public void InstallKeyBoardHook(HookType type)
        {
            if (kbhHook == 0)
            {
                kbHook = new HookProc(DefaultKeyBoardHookProc);
                kbhHook = SetWindowsHookEx(
                    type,
                    kbHook,
                    GetModuleHandle(
                        Process.GetCurrentProcess().MainModule.ModuleName
                        ),
                    0
                    );
                if (kbhHook == 0)
                    UninstallKeyBoardHook();
            }
        }

        /// <summary>
        /// 使用自定义配置安装鼠标钩子(推荐有一定经验的专业人士使用)
        /// </summary>
        /// <param name="type"></param>
        public void InstallMouseHook(HookType type)
        {
            if (mshHook == 0)
            {
                msHook = new HookProc(DefaultMouseHookProc);
                mshHook = SetWindowsHookEx(
                    type,
                    msHook,
                    GetModuleHandle(
                        Process.GetCurrentProcess().MainModule.ModuleName
                        ),
                    0
                    );
                if (mshHook == 0)
                    UninstallMouseHook();
            }
        }

        /// <summary>
        /// 使用自定义配置安装钩子(不建议使用)
        /// </summary>
        /// <param name="type">钩子类型</param>
        /// <param name="dele">钩子回调函数</param>
        public int InstallHook(HookType type, HookProc dele)
        {
            if (userHook == 0)
            {
                userHook = SetWindowsHookEx(
                    type,
                    dele,
                    GetModuleHandle(
                        Process.GetCurrentProcess().MainModule.ModuleName
                        ),
                    0
                    );
                if (userHook == 0)
                    UninstallKeyBoardHook();
            }
            return userHook;
        }

        /// <summary>
        /// 更具自由性的钩子绑定方法
        /// 您几乎可以为任何线程(也可以是全部线程)、任何模块(也可以是主模块)设置任意类型的钩子
        /// </summary>
        /// <param name="type">钩子类型</param>
        /// <param name="dele">钩子回调函数</param>
        /// <param name="moduleHandel">回调函数所在模块句柄</param>
        /// <param name="threadId">线程编号(0表示为所有线程设置钩子)</param>
        public void InstallHook(HookType type, HookProc dele, IntPtr moduleHandel, int threadId)
        {
            if (userHook == 0)
            {
                userHook = SetWindowsHookEx(
                    type,
                    dele,
                    moduleHandel,
                    threadId
                    );
                if (userHook == 0)
                    UninstallKeyBoardHook();
            }
        }

        /// <summary>
        /// 卸载键盘钩子
        /// </summary>
        public void UninstallKeyBoardHook()
        {
            UninstallHook(ref kbhHook);
        }

        /// <summary>
        /// 卸载鼠标钩子
        /// </summary>
        public void UninstallMouseHook()
        {
            UninstallHook(ref mshHook);
        }

        /// <summary>
        /// 卸载所有钩子
        /// </summary>
        public void UninstallAllHook()
        {
            UninstallKeyBoardHook();
            UninstallMouseHook();
            UninstallHook(ref userHook);
        }

        /// <summary>
        /// 卸载钩子
        /// </summary>
        /// <param name="idhook"></param>
        private void UninstallHook(ref int idhook)
        {
            if (idhook != 0)
            {
                UnhookWindowsHookEx(idhook);
                idhook = 0;
            }
        }

        #endregion

        #region 钩子发挥作用时的方法

        /// <summary>
        /// 默认键盘钩子回调函数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private int DefaultKeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            KBDLLHOOKSTRUCT kbhs = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
            if (wParam == (int)MsgType.WM_KEYDOWN && OnKeyDown != null)
                OnKeyDown.Invoke(this, new KeyEventArgs((Keys)kbhs.vkCode));
            else
            {
                if (wParam == (int)MsgType.WM_KEYUP && OnKeyUp != null)
                    OnKeyUp.Invoke(this, new KeyEventArgs((Keys)kbhs.vkCode));
                if (wParam == (int)MsgType.WM_KEYUP && OnKeyPress != null)
                    OnKeyPress.Invoke(this, new KeyEventArgs((Keys)kbhs.vkCode));
            }
            return CallNextHookEx(kbhHook, nCode, wParam, lParam);
        }

        /// <summary>
        /// 默认鼠标钩子回调函数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private int DefaultMouseHookProc(int nCode, int wParam, IntPtr lParam)
        {
            MOUSEHOOKSTRUCT mshs = (MOUSEHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MOUSEHOOKSTRUCT));
            MouseButtons button = MouseButtons.None;
            int clickCount = 0;
            switch (wParam)
            {
                case (int)MsgType.WM_LBUTTONDOWN:
                    button = MouseButtons.Left;
                    clickCount = 1;
                    InvokeMouseEvent(OnMouseDown, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_LBUTTONUP:
                    button = MouseButtons.Left;
                    clickCount = 1;
                    InvokeMouseEvent(OnMouseClick, button, clickCount, mshs.pt);
                    InvokeMouseEvent(OnMouseUp, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_LBUTTONDBLCLK:
                    button = MouseButtons.Left;
                    clickCount = 2;
                    InvokeMouseEvent(OnMouseDoubleClick, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_RBUTTONDOWN:
                    button = MouseButtons.Right;
                    clickCount = 1;
                    InvokeMouseEvent(OnMouseDown, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_RBUTTONUP:
                    button = MouseButtons.Right;
                    clickCount = 1;
                    InvokeMouseEvent(OnMouseClick, button, clickCount, mshs.pt);
                    InvokeMouseEvent(OnMouseUp, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_RBUTTONDBLCLK:
                    button = MouseButtons.Right;
                    clickCount = 2;
                    InvokeMouseEvent(OnMouseDoubleClick, button, clickCount, mshs.pt);
                    break;
                case (int)MsgType.WM_MOUSEMOVE:
                    InvokeMouseEvent(OnMouseClick, button, clickCount, mshs.pt);
                    InvokeMouseEvent(OnMouseUp, button, clickCount, mshs.pt);
                    break;
            }
            return CallNextHookEx(mshHook, nCode, wParam, lParam);
        }

        /// <summary>
        /// 鼠标事件调用
        /// </summary>
        /// <param name="eventName">事件名</param>
        /// <param name="button">鼠标按键</param>
        /// <param name="clickCount">鼠标点击次数</param>
        /// <param name="p">鼠标坐标</param>
        private void InvokeMouseEvent(Delegate eventName, MouseButtons button, int clickCount, POINT p)
        {
            MouseEventArgs e = new MouseEventArgs(button, clickCount, p.x, p.y, 0);
            eventName.DynamicInvoke(this, e);
        }

        #endregion
    }
}
