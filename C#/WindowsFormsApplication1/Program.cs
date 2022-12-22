using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Net.Sockets;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
            
            Form1 form1 = new Form1();
            Application.EnableVisualStyles();
            //form1.start_SerialPort();
            Application.Run(form1);
            //form1.closeSerial();
            
        }
    }
}