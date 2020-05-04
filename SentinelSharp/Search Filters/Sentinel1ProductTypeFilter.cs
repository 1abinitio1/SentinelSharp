using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class Sentinel1ProductTypeFilter : BaseSearchFilter
    {
        public Sentinel1ProductType Sentinel1ProductType;

        public Sentinel1ProductTypeFilter()
        {

        }

        public Sentinel1ProductTypeFilter(Sentinel1ProductType sentinel1ProductType)
        {
            Sentinel1ProductType = sentinel1ProductType;
        }

        public override string Build()
        {
            switch (Sentinel1ProductType)
            {
                case Sentinel1ProductType.SLC:
                    return "(producttype:SLC)";
                case Sentinel1ProductType.GRD:
                    return "(producttype:GRD)";
                case Sentinel1ProductType.OCN:
                    return "(producttype:OCN)";
                default:
                    return "";
            }
        }
    }
}
