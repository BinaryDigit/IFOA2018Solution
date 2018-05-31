using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelWindowsForms
{
    public delegate void SetProgressCallback(int i);
    public delegate void SetTextCallback(string txt);

    public partial class Form1 : Form
    {
        //private readonly SynchronizationContext synchronizationContext;

        SetTextCallback SetTextDelegate;
        public void SetText(string txt)
        {
            textBox1.Text += txt;
        }

        SetProgressCallback pbDelegate;
        public void PBSetter(int i)
        {
            progressBar1.Value = i;
        }

        public async Task SetProgressBar()
        {
            await Task.Run(() => 
            { 
                for (int i = 0; i <= 100; i++)
                {
                    object[] ii = new object[1] { i};
                    progressBar1.Invoke( pbDelegate, ii);
                    Thread.Sleep(100);
                }
            }
            );
           
        }

        public Form1()
        {
            InitializeComponent();
            //synchronizationContext = SynchronizationContext.Current;

            pbDelegate += PBSetter;
            SetTextDelegate += SetText;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("", FileMode.Open);
            byte[] bb = new byte[fs.Length];
            await fs.ReadAsync( bb, 0, (int)fs.Length-1);
            await SetProgressBar();
            await SetTextAsync();
        }

        private async Task SetTextAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    object[] ii = new object[1] { "lorem ipsum" };
                    textBox1.Invoke(SetTextDelegate, ii);
                    Thread.Sleep(100);
                }
            }
            );
        }
    }
}
