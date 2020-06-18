using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaurdian
{
    public partial class Guardian : Form
    {
        public Guardian()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.CursorVisible = false;
            Console.SetWindowPosition(0, 0);
            Console.Write("Start Guardian : ");
            while (true)
            {
                Console.Write("*");
                foreach (Process Guardian_Cheat in Process.GetProcesses())
                {
                    if (Guardian_Cheat.ProcessName.ToLower().Contains("cheat"))
                    {
                        Console.Write("Cheat Detect");
                        Guardian_Cheat.Kill();
                    }

                    if (Guardian_Cheat.ProcessName.ToLower().Contains("engine"))
                    {
                        Console.Write("Cheat Detect");
                        Guardian_Cheat.Kill();
                    }
                }
            }
        }
    }
}
