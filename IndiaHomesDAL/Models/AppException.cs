using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class AppException
    {
        public string SessionId { get; set; }
        public string Exception { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public int ExceptionId { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
    }
}
