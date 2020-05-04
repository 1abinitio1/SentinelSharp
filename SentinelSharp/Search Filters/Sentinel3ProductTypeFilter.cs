using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class Sentinel3ProductTypeFilter : BaseSearchFilter
    {
        public Sentinel3ProductType Sentinel3ProductType;

        public Sentinel3ProductTypeFilter()
        {

        }

        public Sentinel3ProductTypeFilter(Sentinel3ProductType sentinel3ProductType)
        {
            Sentinel3ProductType = sentinel3ProductType;
        }

        public override string Build()
        {
            switch (Sentinel3ProductType)
            {
                case Sentinel3ProductType.SR_1_SRA___:
                    return "(producttype:SR_1_SRA___)";
                case Sentinel3ProductType.SR_1_SRA_A:
                    return "(producttype:SR_1_SRA_A)";

                case Sentinel3ProductType.SR_1_SRA_BS:
                    return "(producttype:SR_1_SRA_BS)";
                case Sentinel3ProductType.SR_2_LAN___:
                    return "(producttype:SR_2_LAN___)";

                case Sentinel3ProductType.OL_1_EFR___:
                    return "(producttype:OL_1_EFR___)";
                case Sentinel3ProductType.OL_1_ERR___:
                    return "(producttype:OL_1_ERR___)";

                case Sentinel3ProductType.OL_2_LFR___:
                    return "(producttype:OL_2_LFR___)";
                case Sentinel3ProductType.OL_2_LRR___:
                    return "(producttype:OL_2_LRR___)";

                case Sentinel3ProductType.SL_1_RBT___:
                    return "(producttype:SL_1_RBT___)";
                case Sentinel3ProductType.SL_2_LST___:
                    return "(producttype:SL_2_LST___)";

                case Sentinel3ProductType.SY_2_SYN___:
                    return "(producttype:SY_2_SYN___)";
                case Sentinel3ProductType.SY_2_V10___:
                    return "(producttype:SY_2_V10___)";

                case Sentinel3ProductType.SY_2_VG1___:
                    return "(producttype:SY_2_VG1___)";
                case Sentinel3ProductType.SY_2_VGP___:
                    return "(producttype:SY_2_VGP___)";
                default:
                    return "";
            }
        }
    }
}
