using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HySON
{
    class Test5Class
    {
        [Member(typeof(Test1Class))]
        public List<Test1Class> temps;
    }
}
