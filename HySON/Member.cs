using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HySON
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Member: Attribute
    {
        public Type Value { get; };

        public Member(Type v)
        {
            this.Value = v;
        }
        
    }
}
