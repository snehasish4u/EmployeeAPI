using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PtrateMst
    {
        public int RowId { get; set; }
        public int PtrateId { get; set; }
        public int PtgroupId { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public decimal? MinimumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public decimal? PtRate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string PtrateName { get; set; }
    }
}
