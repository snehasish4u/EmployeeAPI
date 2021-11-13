using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeDisciplinaryDtl
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeDisId { get; set; }
        public string Memo { get; set; }
        public string IssueBy { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Comments { get; set; }
        public string Remarks { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
