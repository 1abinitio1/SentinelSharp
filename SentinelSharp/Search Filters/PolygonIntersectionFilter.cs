using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class PolygonIntersectionFilter : BaseSearchFilter
    {
        /// <summary>
        /// Longitudes of the polygons points
        /// </summary>
        public float[] PointLongitudes;

        /// <summary>
        /// Latitudes of the polygons points
        /// </summary>
        public float[] PointLatitudes;

        public PolygonIntersectionFilter()
        {

        }

        public PolygonIntersectionFilter(float[] Longitudes, float[] Latitudes)
        {
            PointLongitudes = Longitudes;
            PointLatitudes = Latitudes;
        }

        public override string Build()
        {
            string text = "";
            for (int i = 0; i < PointLongitudes.Length; i++)
            {
                text += ", " + PointLongitudes[i].ToString() + " " + PointLatitudes.ToString();
            }
            if (PointLatitudes.Length > 0)
            {
                text = text.Substring(2);
            }
            

            return "(footprint:\"Intersects(POLYGON((" + text + ")))\")";
        }
    }
}
