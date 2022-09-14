namespace Browser
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Back = new System.Windows.Forms.ToolStripButton();
            this.TSB_Forward = new System.Windows.Forms.ToolStripButton();
            this.TSB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.TSB_Home = new System.Windows.Forms.ToolStripButton();
            this.TSTB_Adres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSDDB_Profil = new System.Windows.Forms.ToolStripDropDownButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Back,
            this.TSB_Forward,
            this.TSB_Refresh,
            this.TSB_Home,
            this.TSTB_Adres,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Back
            // 
            this.TSB_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Back.Image = global::Browser.Properties.Resources.back;
            this.TSB_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Back.Name = "TSB_Back";
            this.TSB_Back.Size = new System.Drawing.Size(23, 22);
            this.TSB_Back.Text = "toolStripButton1";
            this.TSB_Back.Click += new System.EventHandler(this.TSB_Back_Click);
            // 
            // TSB_Forward
            // 
            this.TSB_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Forward.Image = global::Browser.Properties.Resources.Forward;
            this.TSB_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Forward.Name = "TSB_Forward";
            this.TSB_Forward.Size = new System.Drawing.Size(23, 22);
            this.TSB_Forward.Text = "toolStripButton2";
            this.TSB_Forward.Click += new System.EventHandler(this.TSB_Forward_Click);
            // 
            // TSB_Refresh
            // 
            this.TSB_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Refresh.Image = global::Browser.Properties.Resources.refresh;
            this.TSB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Refresh.Name = "TSB_Refresh";
            this.TSB_Refresh.Size = new System.Drawing.Size(23, 22);
            this.TSB_Refresh.Text = "toolStripButton1";
            this.TSB_Refresh.Click += new System.EventHandler(this.TSB_Refresh_Click);
            // 
            // TSB_Home
            // 
            this.TSB_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Home.Image = global::Browser.Properties.Resources.Home;
            this.TSB_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Home.Name = "TSB_Home";
            this.TSB_Home.Size = new System.Drawing.Size(23, 22);
            this.TSB_Home.Text = "toolStripButton1";
            this.TSB_Home.Click += new System.EventHandler(this.TSB_Home_Click);
            // 
            // TSTB_Adres
            // 
            this.TSTB_Adres.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.TSTB_Adres.Name = "TSTB_Adres";
            this.TSTB_Adres.Size = new System.Drawing.Size(550, 25);
            this.TSTB_Adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTB_Adres_KeyDown);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::Browser.Properties.Resources.vertical_dots;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "TSDDB_VerticalDots";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDDB_Profil});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSDDB_Profil
            // 
            this.TSDDB_Profil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSDDB_Profil.Image = ((System.Drawing.Image)(resources.GetObject("TSDDB_Profil.Image")));
            this.TSDDB_Profil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_Profil.Name = "TSDDB_Profil";
            this.TSDDB_Profil.Size = new System.Drawing.Size(29, 20);
            this.TSDDB_Profil.Text = "toolStripDropDownButton2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 403);
            this.webBrowser1.TabIndex = 2;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Browser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Back;
        private System.Windows.Forms.ToolStripButton TSB_Forward;
        private System.Windows.Forms.ToolStripButton TSB_Refresh;
        private System.Windows.Forms.ToolStripButton TSB_Home;
        private System.Windows.Forms.ToolStripTextBox TSTB_Adres;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_Profil;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}