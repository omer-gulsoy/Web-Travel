using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Models
{
    public class VisitorViewModel
    {
        public int VisitorID { get; set; }
        public string VisitorName { get; set; }
        public string VisitorSurname { get; set; }
        public string VisitorCity { get; set; }
        public string VisitorCountry { get; set; }
        public string Mail { get; set; }
    }
}
