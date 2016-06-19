using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBoardUsage.Model
{
    public static class DetailUsage 
    {

        public static Dictionary<string, UsageCount> usageList =new Dictionary<string,UsageCount>();
        public static int A = 0;
        public static int B = 0;
        public static int C = 0;
        public static int D = 0;
        public static int E = 0;
        public static int F = 0;
        public static int G = 0;
        public static int H = 0;
        public static int I = 0;
        public static int J = 0;
        public static int K = 0;
        public static int L = 0;
        public static int M = 0;
        public static int N = 0;
        public static int O = 0;
        public static int P = 0;
        public static int Q = 0;
        public static int R = 0;
        public static int S = 0;
        public static int T = 0;
        public static int U = 0;
        public static int V = 0;
        public static int W = 0;
        public static int X = 0;
        public static int Y = 0;
        public static int Z = 0;
        public static int KEY1 = 0;
        public static int KEY2 = 0;
        public static int KEY3 = 0;
        public static int KEY4 = 0;
        public static int KEY5 = 0;
        public static int KEY6 = 0;
        public static int KEY7 = 0;
        public static int KEY8 = 0;
        public static int KEY9 = 0;
        public static int KEY0 = 0;
        public static int F1 = 0;
        public static int F2 = 0;
        public static int F3 = 0;
        public static int F4 = 0;
        public static int F5 = 0;
        public static int F6 = 0;
        public static int F7 = 0;
        public static int F8 = 0;
        public static int F9 = 0;
        public static int F10 = 0;
        public static int F11 = 0;
        public static int F12 = 0;
        public static int ShiftKey = 0;
        public static int CtrlKey = 0;
        public static int AltKey = 0;
        public static int CapsLock = 0;
        public static int Tab = 0;
        public static int Escape = 0;
        public static int Enter = 0;
        public static int Home = 0;
        public static int End = 0;
        public static int PageUp = 0;
        public static int PageDown = 0;
    }
    public static class TotalUsage 
    {
        public static int totalCount = 0;
        public static int mainCount = 0;
        public static int numberCount = 0;
        public static int funcCount = 0;
        public static int ctrlCount = 0;
    }
   public class UsageCount
    {
        public int id { get; set; }
        public DateTime time { get; set; }
        public int Count { get; set; }
        public string TableName { get; set; }
        public string KeyName { get; set; }
    }
}
