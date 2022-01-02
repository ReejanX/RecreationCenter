using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System
{
    class VisitorsData
    {
        public int VisitorsId { get; set; }
        public string VisitorName { get; set; }
        public Int64? phone { get; set; }
        public string AgeGroup { get; set; }
        public int GroupCount { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? Price { get; set; }
    }
}
