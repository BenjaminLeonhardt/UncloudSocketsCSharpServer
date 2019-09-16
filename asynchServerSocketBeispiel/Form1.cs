using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asynchServerSocketBeispiel {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        AsynchronousSocketListener asynchSocketListener;
        private void button1_Click(object sender, EventArgs e) {

        }

        private void startButton_Click(object sender, EventArgs e) {
            Thread neuerThread = new Thread(threadMethode);
            neuerThread.Start();

            Thread peersObserver = new Thread(AsynchronousSocketListener.peersObserverThread);
            peersObserver.Start();
        }

        public void threadMethode() {
            AsynchronousSocketListener.StartListening(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            AsynchronousSocketListener.run = false;
            Application.Exit();
        }
    }
}
