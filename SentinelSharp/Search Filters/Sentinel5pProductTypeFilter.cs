using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class Sentinel5pProductTypeFilter : BaseSearchFilter
    {
        public Sentinel5pProductType Sentinel5pProductType;

        public Sentinel5pProductTypeFilter()
        {

        }

        public Sentinel5pProductTypeFilter(Sentinel5pProductType sentinel5pProductType)
        {
            Sentinel5pProductType = sentinel5pProductType;
        }

        public override string Build()
        {
            switch (Sentinel5pProductType)
            {
                case Sentinel5pProductType.L1B_IR_SIR:
                    return "(producttype:L1B_IR_SIR)";
                case Sentinel5pProductType.L1B_IR_UVN:
                    return "(producttype:L1B_IR_UVN)";

                case Sentinel5pProductType.L1B_RA_BD1:
                    return "(producttype:L1B_RA_BD1)";
                case Sentinel5pProductType.L1B_RA_BD2:
                    return "(producttype:L1B_RA_BD2)";

                case Sentinel5pProductType.L1B_RA_BD3:
                    return "(producttype:L1B_RA_BD3)";
                case Sentinel5pProductType.L1B_RA_BD4:
                    return "(producttype:L1B_RA_BD4)";

                case Sentinel5pProductType.L1B_RA_BD5:
                    return "(producttype:L1B_RA_BD5)";
                case Sentinel5pProductType.L1B_RA_BD6:
                    return "(producttype:L1B_RA_BD6)";

                case Sentinel5pProductType.L1B_RA_BD7:
                    return "(producttype:L1B_RA_BD7)";
                case Sentinel5pProductType.L1B_RA_BD8:
                    return "(producttype:L1B_RA_BD8)";

                case Sentinel5pProductType.L2__AER_AI:
                    return "(producttype:L2__AER_AI)";
                case Sentinel5pProductType.L2__AER_LH:
                    return "(producttype:L2__AER_LH)";

                case Sentinel5pProductType.L2__CH4:
                    return "(producttype:L2__CH4)";
                case Sentinel5pProductType.L2__CLOUD_:
                    return "(producttype:L2__CLOUD_)";

                case Sentinel5pProductType.L2__CO____:
                    return "(producttype:L2__CO____)";
                case Sentinel5pProductType.L2__HCHO__:
                    return "(producttype:L2__HCHO__)";

                case Sentinel5pProductType.L2__NO2___:
                    return "(producttype:L2__NO2___)";
                case Sentinel5pProductType.L2__NP_BD3:
                    return "(producttype:L2__NP_BD3)";

                case Sentinel5pProductType.L2__NP_BD6:
                    return "(producttype:L2__NP_BD6)";
                case Sentinel5pProductType.L2__NP_BD7:
                    return "(producttype:L2__NP_BD7)";

                case Sentinel5pProductType.L2__O3_TCL:
                    return "(producttype:L2__O3_TCL)";
                case Sentinel5pProductType.L2__O3____:
                    return "(producttype:L2__O3____)";

                case Sentinel5pProductType.L2__SO2___:
                    return "(producttype:L2__SO2___)";
                default:
                    return "";
            }
        }
    }
}
