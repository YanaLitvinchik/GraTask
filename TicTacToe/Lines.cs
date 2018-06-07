using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Lines
    {
        public Point Begin { get; set; }//
        public Point End { get; set; }
        public Lines()
        {

        }
        public Lines(Point _begin, Point _end)
        {
            this.Begin = _begin;
            this.End = _end;
        }
    }
}
