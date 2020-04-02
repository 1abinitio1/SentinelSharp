using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class S1_ProductFilter : BaseSearchFilter
    {
        public Sentinel1Product Sentinel1Product;

        public S1_ProductFilter()
        {

        }

        public S1_ProductFilter(Sentinel1Product sentinel1Product)
        {
            Sentinel1Product = sentinel1Product;
        }

        public override string Build()
        {
            switch (Sentinel1Product)
            {
                case Sentinel1Product.SLC:
                    return "(producttype:SLC)";
                case Sentinel1Product.GRD:
                    return "(producttype:GRD)";
                case Sentinel1Product.OCN:
                    return "(producttype:OCN)";
                default:
                    return "";
            }
        }
    }
}
