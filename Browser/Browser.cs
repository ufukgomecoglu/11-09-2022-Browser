using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void TSB_Home_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://www.google.com");
        }

        private void TSTB_Adres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TSTB_Adres.Text.Length != 0)
                {
                    string adres = $"http://www.{TSTB_Adres.Text}.com";
                    webBrowser1.Url = new Uri(adres);
                    Kaydet(adres);
                }
            }
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (TSTB_Adres.Text.Length != 0)
            //    {
            //        webBrowser1.Navigate(TSTB_Adres.Text);
            //    }
            //}
        }
        private int Datanumber()
        {
            StreamReader sr = new StreamReader(@"C:\Browser\adres.txt");
            string text = sr.ReadToEnd();
            string[] lines = text.Split('\n');
            int linesNumber = lines.Length;
            sr.Close();
            return linesNumber;
        }
        private void Kaydet(string adres)
        {
            StreamReader sr = new StreamReader(@"C:\Browser\adres.txt");
            List<string> adress = new List<string>();
            for (int i = 0; i < Datanumber()-1; i++)
            {
                adress.Add(sr.ReadLine());
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(@"C:\Browser\adres.txt");
            for (int i = 0; i < adress.Count; i++)
            {
                sw.WriteLine(adress[i]);
            }
            sw.WriteLine(adres);
            sw.Close();
            adress.Clear();
        }
        private void TSB_Refresh_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        private void TSB_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void TSB_Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Browser");
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo(@"C:\Browser\adres.txt");
            if (!fi.Exists)
            {
                fi.Create();
            }
            
        }
    }
}
