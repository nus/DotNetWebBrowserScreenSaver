using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenSaver
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if (args.Length < 1)
            {
                StartScreenSaver();
                return;
            }
            else if (args[0].ToLower() == "/s")
            {
                StartScreenSaver();
            }
        }

        static void StartScreenSaver()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (Screen s in Screen.AllScreens)
            {
                Form f = new Form1();
                f.SetBounds(s.Bounds.X, s.Bounds.Y, s.Bounds.Width, s.Bounds.Height);
                f.Show();
            }

            Application.Run();
        }
    }
}
