using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class SensorModeFilter : BaseSearchFilter
    {
        public SensorMode SensorMode;

        public SensorModeFilter()
        {

        }

        public SensorModeFilter(SensorMode sensorMode)
        {
            SensorMode = sensorMode;
        }

        public override string Build()
        {
            switch (SensorMode)
            {
                case SensorMode.SM:
                    return "(sensoroperationalmode:SM)";
                case SensorMode.IW:
                    return "(sensoroperationalmode:IW)";
                case SensorMode.EW:
                    return "(sensoroperationalmode:EW)";
                case SensorMode.WV:
                    return "(sensoroperationalmode:WV)";
                default:
                    return "";
            }
        }
    }
}
