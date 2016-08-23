using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class DBException
    {
        public string SessionId { get; set; }
        public string SourceProcedure { get; set; }
        public string LineNo { get; set; }
        public string Message { get; set; }
        public string ErrorNo { get; set; }
        public System.DateTime Timestamp { get; set; }
    }
}
