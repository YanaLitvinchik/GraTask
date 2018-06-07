using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Lines l = new Lines();
        List<Lines> lines = new List<Lines>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            l.Begin = e.Location;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 200, 0, 200, this.ClientSize.Height);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 400, 0, 400, this.ClientSize.Height);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 200, this.ClientSize.Width, 200);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 400, this.ClientSize.Width, 400);
            //e.Graphics.DrawLines
        }
    }
}
