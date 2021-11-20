using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11
{
    class People
    {
        public string FIO;
        public double ves;
        public int rost;

        public override string ToString()
        {
            return FIO + "  рост=" + rost;
        }
    }
}
