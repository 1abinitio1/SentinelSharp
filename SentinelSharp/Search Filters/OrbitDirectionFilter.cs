using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class OrbitDirectionFilter : BaseSearchFilter
    {
        public OrbitDirection OrbitDirection;

        public OrbitDirectionFilter()
        {

        }

        public OrbitDirectionFilter(OrbitDirection orbitDirection)
        {
            OrbitDirection = orbitDirection;
        }

        public override string Build()
        {
            switch (OrbitDirection)
            {
                case OrbitDirection.Ascending:
                    return "(orbitdirection:Ascending)";
                case OrbitDirection.Descending:
                    return "(orbitdirection:Descending)";
                default:
                    return "";
            }
        }
    }
}
