using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MMenuList
    {
        public int Id { get; set; }
        public string MName { get; set; }
        public string MLinks { get; set; }
        public int MSort { get; set; }
        public int MRefId { get; set; }
        public int MLevel { get; set; }
        public string MIcon { get; set; }
    }
}
