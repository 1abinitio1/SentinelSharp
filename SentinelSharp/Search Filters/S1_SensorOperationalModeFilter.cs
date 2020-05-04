using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class S1_SensorOperationalModeFilter : BaseSearchFilter
    {
        public S1_SensorOperationalMode S1_SensorOperationalMode;

        public S1_SensorOperationalModeFilter()
        {

        }

        public S1_SensorOperationalModeFilter(S1_SensorOperationalMode s1_SensorOperationalMode)
        {
            S1_SensorOperationalMode = s1_SensorOperationalMode;
        }

        public override string Build()
        {
            switch (S1_SensorOperationalMode)
            {
                case S1_SensorOperationalMode.SM:
                    return "(sensoroperationalmode:SM)";
                case S1_SensorOperationalMode.IW:
                    return "(sensoroperationalmode:IW)";
                case S1_SensorOperationalMode.EW:
                    return "(sensoroperationalmode:EW)";
                case S1_SensorOperationalMode.WV:
                    return "(sensoroperationalmode:WV)";
                default:
                    return "";
            }
        }
    }
}
