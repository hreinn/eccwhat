using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EccWhat
{
    public static class Program
    {
        private static Form f;
        private static List<string> opt;
        private static WebBrowser wb;
        private static object[] resu;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
         
            f = new Form();

            wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            f.Controls.Add(wb);

            wb.ObjectForScripting = new Callback();

            if (!File.Exists("eccwhat.html"))
            {
                Console.WriteLine("You need to put a file in " + Directory.GetCurrentDirectory() + " if you plan to run the program the same way. Press any key to exit.");

                Console.ReadKey();
                return;
            }
            var html = File.ReadAllText("eccwhat.html");

            wb.DocumentText = html;
            f.Text = wb.DocumentTitle;
            wb.AllowNavigation = false;
            f.ShowDialog();
            //if (resu != null)
            //    foreach (var o in resu)
            //    {
            //        Console.WriteLine(i++.ToString().PadLeft('4'));
            //    }

        }

        [ComVisible(true)]
        public class Callback
        {
            public void callback(params object[] os)
            {
                int i = 0;
                var r = "";
                foreach (var o in os.Where(p=>p!=null))
                {
                    Console.WriteLine(i+++":"+o.ToString());
                    r += " "+o.ToString();
                }
                //Console.WriteLine();
                //Console.WriteLine(r);
                //
                f.Close();
                Start(os.Select(p=>p.ToString()).ToArray());

            }

            private void Start(string[] os)
            {
                var p = new Process();
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                p.StartInfo.FileName = os.First().ToString();
                p.StartInfo.Arguments = os.Skip(1).Aggregate((current, next) => current + " " + next);

                p.OutputDataReceived += delegate
                {

                    Console.WriteLine(p.StandardOutput.ReadToEnd());
                    Console.WriteLine(p.StandardError.ReadToEnd());
                };
                p.Start();
                
                p.WaitForExit();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
                Console.WriteLine(p.StandardError.ReadToEnd());
            }
        }
    }
}
