using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HySON
{
    class Test7Class
    {
        public int a;
        public String b;
        [Member(typeof(int))]
        public List<int> c;
        public int[] d;
        [Member(typeof(Test1Class))]
        public List<Test1Class> temps;
    }
}
