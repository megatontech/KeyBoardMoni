using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace HookINCS
{
    /// <summary>
    /// 键盘Hook结构函数
    /// 即钩子发挥作用时能够得到的一些参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class KBDLLHOOKSTRUCT
    {
        /// <summary>
        /// 虚拟按键码(1--254)
        /// </summary>
        public int vkCode;
        /// <summary>
        /// 硬件按键扫描码
        /// </summary>
        public int scanCode;
        /// <summary>
        /// 键按下：128 抬起：0
        /// </summary>
        public int flags;
        /// <summary>
        /// 消息时间戳间
        /// </summary>
        public int time;
        /// <summary>
        /// 额外信息
        /// </summary>
        public int dwExtraInfo;
    }
}
