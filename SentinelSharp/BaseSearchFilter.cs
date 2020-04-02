using System.Collections;
using System.Collections.Generic;

namespace SentinelSharp
{
    public class BaseSearchFilter
    {
        public bool Invert;
        public BaseSearchFilter()
        {

        }

        public virtual string Build()
        {
            return "";
        }
    }
}