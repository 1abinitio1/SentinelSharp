using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class S1_PolarisationModeFilter : BaseSearchFilter
    {
        public S1_PolarisationMode S1_PolarisationMode;

        public S1_PolarisationModeFilter()
        {

        }

        public S1_PolarisationModeFilter(S1_PolarisationMode s1_PolarisationMode)
        {
            S1_PolarisationMode = s1_PolarisationMode;
        }

        public override string Build()
        {

            switch (S1_PolarisationMode)
            {
                case S1_PolarisationMode.HH:
                    return "(polarisationmode:HH)";
                case S1_PolarisationMode.VV:
                    return "(polarisationmode:VV)";
                case S1_PolarisationMode.HV:
                    return "(polarisationmode:HV)";
                case S1_PolarisationMode.VH:
                    return "(polarisationmode:VH)";
                case S1_PolarisationMode.HH_HV:
                    return "(polarisationmode:HH HV)";
                case S1_PolarisationMode.VV_VH:
                    return "(polarisationmode:VV VH)";
                default:
                    return "";
            }
        }
    }
}
