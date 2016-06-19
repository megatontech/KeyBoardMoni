using System;
using System.Collections.Generic;
using System.Text;

namespace HookINCS
{
    /// <summary>
    /// 钩子回调函数声明
    /// </summary>
    /// <param name="nCode">钩子链传递回来的参数，0表示此消息(被之前的消息钩子)丢弃，非0表示此消息继续有效</param>
    /// <param name="wParam">消息参数</param>
    /// <param name="lParam">消息参数</param>
    /// <returns></returns>
    public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
}
