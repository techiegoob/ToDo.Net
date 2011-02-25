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

            // add test item(s)
            ListViewItem liv1=new ListViewItem();
            liv1.ForeColor=Color.Red;
            liv1.Text="(A)";
            liv1.SubItems.Add("Test1", Color.Black, lstItems.BackColor, lstItems.Font);            
            this.lstItems.Items.Add(liv1);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            ResizeListing();
        }

        private void ResizeListing()
        {
            //listBox1.Top = 0;
            //listBox1.Left = 0;
            this.lstItems.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            this.lstItems.Columns[1].Width = this.lstItems.Width - this.lstItems.Columns[0].Width;

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

        private void lstItems_KeyPress(object sender, KeyPressEventArgs e)
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
