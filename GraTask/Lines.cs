using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraTask
{
    class Lines
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Lines()
        {

        }
        public Lines(Point a , Point b)
        {
            this.A = a;
            this.B = b;
        }
        
    }
}
