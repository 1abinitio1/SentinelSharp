using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelSharp.Search_Filters
{
    class TimelinessFilter : BaseSearchFilter
    {
        public Timeliness Timeliness;

        public TimelinessFilter()
        {

        }

        public TimelinessFilter(Timeliness timeliness)
        {
            Timeliness = timeliness;
        }

        public override string Build()
        {
            switch (Timeliness)
            {
                case Timeliness.NRT:
                    return "(timeliness:\"NRT\")";
                case Timeliness.NRT_3h:
                    return "(timeliness:\"NRT-3h\")";
                case Timeliness.NA:
                    return "(timeliness:\"N/A\")";
                case Timeliness.Near_Real_Time:
                    return "(timeliness:\"Near Real Time\")";
                case Timeliness.STC:
                    return "(timeliness:\"STC\")";
                case Timeliness.Short_Time_Critical:
                    return "(timeliness:\"Short Time Critical\")";
                case Timeliness.NTC:
                    return "(timeliness:\"NTC\")";
                case Timeliness.Fast_24h:
                    return "(timeliness:\"Fast-24h\")";
                case Timeliness.Non_Time_Critical:
                    return "(timeliness:\"Non Time Critical\")";
                default:
                    return "";
            }
        }
    }
}
