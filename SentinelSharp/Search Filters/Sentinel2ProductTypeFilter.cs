using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class Sentinel2ProductTypeFilter : BaseSearchFilter
    {
        public Sentinel2ProductType Sentinel2ProductType;

        public Sentinel2ProductTypeFilter()
        {

        }

        public Sentinel2ProductTypeFilter(Sentinel2ProductType sentinel2ProductType)
        {
            Sentinel2ProductType = sentinel2ProductType;
        }

        public override string Build()
        {
            switch (Sentinel2ProductType)
            {
                case Sentinel2ProductType.S2MSI2A:
                    return "(producttype:S2MSI2A)";
                case Sentinel2ProductType.S2MSI1C:
                    return "(producttype:S2MSI1C)";
                case Sentinel2ProductType.S2MS2Ap:
                    return "(producttype:S2MS2Ap)";
                default:
                    return "";
            }
        }
    }
}
