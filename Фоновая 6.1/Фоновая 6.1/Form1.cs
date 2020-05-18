using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая_6._1
{
    public partial class Form1 : Form
    {
        private int a;
        private Point p;
        public Form1()
        {
            InitializeComponent();
            a = button1.Width;
            p = button2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p.X >= 10)
                p.X -= 10;
            else
                p.X = Width - button2.Width - 15;
            button2.Location = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Width > button1.MinimumSize.Width + 1)
                button1.Width -= 2;
            else
                button1.Width = a;
        }
    }
}
