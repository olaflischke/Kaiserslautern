using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BummlerWinForm
{
    public partial class Form1 : Form
    { Bummler bummler;
        public Form1()
        {
            InitializeComponent();

             bummler = new Bummler();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = await bummler.BummelnAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            label2.Text = await bummler.TroedelnAsync();
        }
    }
}
