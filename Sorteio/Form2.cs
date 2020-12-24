using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class Form2 : Form
    {
        DateTime time = new DateTime();
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = time - DateTime.Now;
            label1.Text = span.TotalSeconds.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            time = DateTime.Now;
        }
    }
}
