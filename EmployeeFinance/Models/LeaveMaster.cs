using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class LeaveMaster
    {
        public int LeaveId { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveName { get; set; }
        public string LeaveShortName { get; set; }
        public bool? IsAffectSalary { get; set; }
        public bool? IsAlloted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
