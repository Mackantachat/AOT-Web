using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationAui
    {
        public long Id { get; set; }
        public DateTime SystemDate { get; set; }
        public string SystemStaff { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateStaff { get; set; }
        public long OperationId { get; set; }
    }
}
