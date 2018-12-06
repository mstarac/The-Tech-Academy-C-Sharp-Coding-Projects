using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOne
{

    public class OneMath
    {
        public OneMath(int a)
        {
            this.a = a * 2;
        }
        public int a { get; set; }
    }
    public class TwoMath
    {
        public TwoMath(int b)
        {
            this.b = b / 2;
        }
        public int b { get; set; }
    }
    public class ThreeMath
    {
        public ThreeMath(int c)
        {
            this.c = c * c;
        }
        public int c { get; set; }
    }
}


