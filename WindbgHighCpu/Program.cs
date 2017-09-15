using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindbgHighCpu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"到命令行下，切换到windbg.exe目录，然后执行adplus -hang -pn WindbgHighCpu.exe -o E:\dumps。");
            Console.WriteLine("请注意了：如果在E盘下没有dumps文件夹，那么先要在E盘下新建该文件夹。");
            Console.WriteLine("如果要停止，按Ctrl+C结束程序。");
            Console.WriteLine("====================================================");          

            while (true)
            {
               Console.SetCursorPosition(0, 5);
               Console.Write(DateTime.Now.Ticks.ToString());
            }
            Console.ReadKey();
        }
    }
}
