using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom
{
    
    static class Program
    {
        public static string success_flag = "不成功";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLearn());
            if(success_flag == "验证成功")
            {
                Application.Run(new Form2());
            }
        }
    }
}
