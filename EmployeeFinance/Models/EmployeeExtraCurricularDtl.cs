using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeExtraCurricularDtl
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeCurrId { get; set; }
        public string ActivityName { get; set; }
        public string EventName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Award { get; set; }
        public string Remarks { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
