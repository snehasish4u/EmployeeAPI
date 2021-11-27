using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayHeadDetail
    {
        public int PayheadDtlId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public int Grade { get; set; }
        public int PayheadId { get; set; }
        public string PayheadCode { get; set; }
        public string PayheadName { get; set; }
        public string PaymapCalcType { get; set; }
        public string AttachAs { get; set; }
        public string Formula { get; set; }
        public string PrintInSlip { get; set; }
        public string RoundOff { get; set; }
        public string ClacOnPresentDay { get; set; }
        public string IsWeeklyOff { get; set; }
        public string IsTaxable { get; set; }
        public decimal? ExemptionLimit { get; set; }
        public string IsExcludeFromCtc { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
