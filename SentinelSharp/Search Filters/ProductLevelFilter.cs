using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class ProductLevelFilter : BaseSearchFilter
    {
        public int Level;

        public ProductLevelFilter()
        {

        }
        
        public ProductLevelFilter(int Level)
        {
            this.Level = Level;
        }

        public override string Build()
        {
            return "(L" + Level + ")";
        }
    }
}
