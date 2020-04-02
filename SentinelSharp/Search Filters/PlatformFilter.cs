using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class PlatformFilter : BaseSearchFilter
    {
        public SentinelPlatform SentinelPlatform;

        public PlatformFilter()
        {

        }

        public PlatformFilter(SentinelPlatform sentinelPlatform)
        {
            SentinelPlatform = sentinelPlatform;
        }

        public override string Build()
        {
            switch (SentinelPlatform)
            {
                case SentinelPlatform.Sentinel1:
                    return "(platformname:Sentinel-1)";
                case SentinelPlatform.Sentinel2:
                    return "(platformname:Sentinel-2)";
                case SentinelPlatform.Sentinel3:
                    return "(platformname:Sentinel-3)";
                default:
                    return "";
            }
        }
    }
}
