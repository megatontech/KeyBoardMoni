using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace HookINCS
{
    /// <summary>
    /// 声明鼠标钩子的封送结构类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class MOUSEHOOKSTRUCT
    {

        /// <summary>
        /// POINT结构对象，保存鼠标在屏幕上的x,y坐标
        /// </summary>
        public POINT pt;
        /// <summary>
        /// 接收到鼠标消息的窗口的句柄
        /// </summary>
        public IntPtr hWnd;
        /// <summary>
        /// hit-test值，详细描述参见WM_NCHITTEST消息
        /// </summary>
        public int wHitTestCode;
        /// <summary>
        /// 指定与本消息联系的额外消息
        /// </summary>
        public int dwExtraInfo;
    }
}
