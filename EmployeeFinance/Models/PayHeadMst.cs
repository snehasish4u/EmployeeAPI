using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayHeadMst
    {
        public int PayHeadId { get; set; }
        public string PayHeadCode { get; set; }
        public string PayHeadName { get; set; }
        public string PayHeadInslip { get; set; }
        public string PayHeadType { get; set; }
        public string PayHeadCategory { get; set; }
        public string UseForGratuity { get; set; }
        public string UseForNetPay { get; set; }
        public string ContributeBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
