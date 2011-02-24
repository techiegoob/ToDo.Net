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
            //listBox1.Top = 0;
            //listBox1.Left = 0;
            listBox1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);

            // position the status label.
            lStatus.Top = this.ClientSize.Height - 30;
            lStatus.Left = 5;
            lStatus.Width = this.ClientSize.Width-10;
            lStatus.Height = 20;
            lStatus.Text = "test";
            lStatus.BringToFront();
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "+":
                    this.lStatus.Text = "Adding...";
                    break;

            }
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "+":
                    this.lStatus.Text = "Adding...";
                    break;

            }
        }
    }
}
