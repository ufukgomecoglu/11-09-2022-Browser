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
                    webBrowser1.Url = new Uri($"http://www.{TSTB_Adres.Text}.com");
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
        }
    }
}
