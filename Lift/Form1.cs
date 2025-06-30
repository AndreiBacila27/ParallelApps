using Microsoft.VisualBasic.Devices;

namespace Lift
{
    public partial class Form1 : Form
    {
        static ManualResetEvent parter = new ManualResetEvent(false);
        static ManualResetEvent etaj1 = new ManualResetEvent(false);
        static ManualResetEvent etaj2 = new ManualResetEvent(false);
        static ManualResetEvent etaj3 = new ManualResetEvent(false);

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
            Thread parter_t = new Thread(new ThreadStart(Parter));
            Thread etaj1_t = new Thread(new ThreadStart(Etaj1));
            Thread etaj2_t = new Thread(new ThreadStart(Etaj2));
            Thread etaj3_t = new Thread(new ThreadStart(Etaj3));

            parter_t.Start();
            etaj1_t.Start();
            etaj2_t.Start();
            etaj3_t.Start();
        }

        public void Parter()
        {
            parter.WaitOne();
            
            for (int i = trackBar1.Value; i <= 0; i++)
            {
                trackBar1.Value++;
                Thread.Sleep(50);
            }

            checkBoxParter.Checked = false;
            parter.Reset();
        }
        public void Etaj1()
        {
            etaj1.WaitOne();
            
            for (int i = trackBar1.Value; i <= 25; i++)
            {
                trackBar1.Value++;
                Thread.Sleep(50);
            }

            checkBoxEtaj1.Checked = false;
            etaj1.Reset();
        }
        public void Etaj2()
        {
            etaj2.WaitOne();

            for (int i = trackBar1.Value; i <= 50; i++)
            {
                trackBar1.Value++;
                Thread.Sleep(50);
            }

            checkBoxEtaj2.Checked = false;
            etaj2.Reset();
        }
        public void Etaj3()
        {
            etaj3.WaitOne();

            for (int i = trackBar1.Value; i <= 75; i++)
            {
                trackBar1.Value++;
                Thread.Sleep(50);
            }

            checkBoxEtaj3.Checked = false;
            etaj3.Reset();
        }

        private void checkBoxEtaj3_CheckedChanged(object sender, EventArgs e)
        {
            etaj3.Set();
        }

        private void checkBoxEtaj2_CheckedChanged(object sender, EventArgs e)
        {
            etaj2.Set();
        }

        private void checkBoxEtaj1_CheckedChanged(object sender, EventArgs e)
        {
            etaj1.Set();
        }

        private void checkBoxParter_CheckedChanged(object sender, EventArgs e)
        {
            parter.Set();
        }
    }
}