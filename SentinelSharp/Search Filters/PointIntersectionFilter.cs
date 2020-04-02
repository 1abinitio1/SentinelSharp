using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    /// <summary>
    /// All images that contain a point
    /// </summary>
    class PointIntersectionFilter : BaseSearchFilter
    {
        public float Lat;
        public float Lon;

        public PointIntersectionFilter()
        {

        }

        public PointIntersectionFilter(float Lat, float Lon)
        {
            this.Lat = Lat;
            this.Lon = Lon;
        }

        public override string Build()
        {
            return "(footprint:\"Intersects(" + Lat + ", " + Lon + ")\")";
            //return "(footprint:\"Intersects(51.5072, 0.1275)\")";
        }
    }
}
