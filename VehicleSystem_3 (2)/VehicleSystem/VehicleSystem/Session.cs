using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSystem
{
    internal class Session
    {
        private Thread myThread;
        private Boolean isInterrupted;

        public Session()
        {
            isInterrupted = false;
            myThread = new Thread(new ThreadStart(Run));
            myThread.Start();
        }

        public void Run() 
        {
            while (!isInterrupted)
            {

            }
            shutDown();
        }

        private void shutDown()
        {
            MessageBox.Show("Shut Down");
            myThread.Abort();
        }

        public void Interrupt()
        {
            myThread.Interrupt();
            isInterrupted = true;
        }
    }
}

