using System.Windows.Forms;
using System;
namespace ScreenSaver
{
    partial class Form1
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
            System.Console.WriteLine("aaa");
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(284, 263);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            this.webBrowser1.DocumentText = Properties.Resources.ResourceManager.GetString("index");
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            Cursor.Hide();

            base.OnLoad(e);
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Document.MouseMove +=new HtmlElementEventHandler(Document_MouseMove);
        }

        void Document_MouseMove(object sender, HtmlElementEventArgs e)
        {
            if (sx == -1)
            {
                sx = e.MousePosition.X;
                sy = e.MousePosition.Y;
            }
            else if (Math.Abs(e.MousePosition.X - sx) > MOVE_THREASHOLD || Math.Abs(e.MousePosition.Y - sy) > MOVE_THREASHOLD)
            {
                System.Environment.Exit(0);
            }
        }

        #endregion

        private const int MOVE_THREASHOLD = 30;
        private int sx = -1;
        private int sy = -1;
        private WebBrowser webBrowser1;
    }
}
