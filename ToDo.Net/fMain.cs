using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDo.Net
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            ResizeListing();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            ResizeListing();
        }

        private void ResizeListing()
        {
            listBox1.Top = 0;
            listBox1.Left = 0;
            listBox1.Width = this.ClientSize.Width;
            listBox1.Height = this.ClientSize.Height;

            // position the status label.
            lStatus.Top = this.ClientSize.Height - 30;
            lStatus.Left = 0;
            lStatus.Width = this.ClientSize.Width;
            lStatus.Height = 20;
            lStatus.Text = "test";
            lStatus.BringToFront();
        }
    }
}
