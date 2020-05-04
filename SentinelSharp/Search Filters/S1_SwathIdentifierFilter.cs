using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class S1_SwathIdentifierFilter : BaseSearchFilter
    {
        public S1_SwathIdentifier S1_SwathIdentifier;

        public S1_SwathIdentifierFilter()
        {

        }

        public S1_SwathIdentifierFilter(S1_SwathIdentifier s1_SwathIdentifier)
        {
            S1_SwathIdentifier = s1_SwathIdentifier;
        }

        public override string Build()
        {
            switch (S1_SwathIdentifier)
            {
                case S1_SwathIdentifier.S1:
                    return "(swathidentifier:S1)";
                case S1_SwathIdentifier.S2:
                    return "(swathidentifier:S2)";
                case S1_SwathIdentifier.S3:
                    return "(swathidentifier:S3)";
                case S1_SwathIdentifier.S4:
                    return "(swathidentifier:S4)";
                case S1_SwathIdentifier.S5:
                    return "(swathidentifier:S5)";
                case S1_SwathIdentifier.S6:
                    return "(swathidentifier:S6)";
                case S1_SwathIdentifier.IW:
                    return "(swathidentifier:IW)";
                case S1_SwathIdentifier.IW1:
                    return "(swathidentifier:IW1)";
                case S1_SwathIdentifier.IW2:
                    return "(swathidentifier:IW2)";
                case S1_SwathIdentifier.IW3:
                    return "(swathidentifier:IW3)";
                case S1_SwathIdentifier.EW:
                    return "(swathidentifier:EW)";
                case S1_SwathIdentifier.EW1:
                    return "(swathidentifier:EW1)";
                case S1_SwathIdentifier.EW2:
                    return "(swathidentifier:EW2)";
                case S1_SwathIdentifier.EW3:
                    return "(swathidentifier:EW3)";
                case S1_SwathIdentifier.EW4:
                    return "(swathidentifier:EW4)";
                case S1_SwathIdentifier.EW5:
                    return "(swathidentifier:EW5)";
                default:
                    return "";
            }
        }
    }
}
