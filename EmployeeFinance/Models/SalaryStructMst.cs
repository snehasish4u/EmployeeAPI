using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class SalaryStructMst
    {
        public int SalaryStrId { get; set; }
        public string SalaryStrCode { get; set; }
        public string SalaryStrName { get; set; }
        public string SalaryStrReamrk { get; set; }
        public bool? IsOnGross { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
