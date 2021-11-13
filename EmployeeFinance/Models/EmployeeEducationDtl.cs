using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeEducationDtl
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeEduId { get; set; }
        public string Qualfication { get; set; }
        public string University { get; set; }
        public string YearPassed { get; set; }
        public decimal? Percentage { get; set; }
        public string Remarks { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
