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

namespace Macchine_BGW_v2
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgw1, bgw2;
        int xn0, yn0, xr0, yr0;
        Random rnd;
        

        public Form1()
        {
            InitializeComponent();
            xn0 = imgNera.Location.X;
            yn0 = imgNera.Location.Y;
            xr0 = imgRossa.Location.X;
            yr0 = imgRossa.Location.Y;
            rnd = new Random();
        }

       

        private void BtnStart_Click(object sender, EventArgs e)
        {
            imgNera.Location = new Point(xn0, yn0);
            imgRossa.Location = new Point(xn0, yr0);
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(imgNera);
            bgw2.RunWorkerAsync(imgRossa);
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnStart.Enabled = false;
            if (e.ProgressPercentage == -1)
            {
                PictureBox p1 = e.UserState as PictureBox;
                if (p1.Name == "imgNera")
                    MessageBox.Show("WINNER: Nero");
                else if (p1.Name == "imgRossa")
                    MessageBox.Show("WINNER: Rosso");
                btnStart.Enabled = true;
                bgw1.CancelAsync();
                bgw2.CancelAsync();

            }
            else
            {
                PictureBox p = e.UserState as PictureBox;
                int n = e.ProgressPercentage;
                p.Location = new Point(p.Location.X + n, p.Location.Y);
            }

            
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker bgw = sender as BackgroundWorker;
            PictureBox img = (PictureBox)e.Argument;
            while(img.Location.X < imgTraguardo.Location.X-135)
            {
                
                if (bgw.CancellationPending)
                {
                    return;
                }
                else
                {
                    Thread.Sleep(70);
                    int n1 = rnd.Next(0, 30);
                    bgw.ReportProgress(n1, img);
                }
            }

            if (!bgw.CancellationPending)
                bgw.ReportProgress(-1, img);

            bgw1.CancelAsync();
            bgw2.CancelAsync();


        }

        
    }
}
