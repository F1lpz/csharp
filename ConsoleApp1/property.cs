using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class property
    {
        public int x {  get; set; }
        public int y { get; set; }

        public property(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int obsah()
        {
            return x * y;
        }


        public int obsah1()
        {
            return (x * 10) * (y * 10);
        }
            
    }
}
