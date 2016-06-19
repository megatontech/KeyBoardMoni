using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace HookINCS
{
    /// <summary>
    /// 声明一个Point的封送类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class POINT
    {
        public int x;
        public int y;
    }
}
