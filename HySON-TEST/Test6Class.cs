using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HySON
{
    class Test6Class
    {
        [Member(typeof(Test3Class))]
        public List<Test3Class> member1;
    }
}
