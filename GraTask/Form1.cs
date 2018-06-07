using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraTask
{
    public partial class Form1 : Form
    {
        Lines l = new Lines();
        List<Lines> lines = new List<Lines>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            lines.Add(new Lines(l.A, l.B));
            foreach (var item in lines)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 5), item.B, item.A);
            }
        }
        Random r = new Random();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (r.Next(1, 5))
            {
                case (1):
                    l.B = new Point( 0, r.Next(0, ClientSize.Height));
                    break;

                case (2):
                    l.B = new Point( r.Next(ClientSize.Width), 0);
                    break;

                case (3):
                    l.B = new Point(r.Next(ClientSize.Width),ClientSize.Height); 
                    break;

                case (4):
                    l.B = new Point(ClientSize.Width,r.Next(0, ClientSize.Height));
                    break;
                }
            l.A = e.Location;
            Invalidate();
        }

    }
}
