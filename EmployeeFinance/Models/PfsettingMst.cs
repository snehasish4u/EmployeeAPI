using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PfsettingMst
    {
        public int PfsettId { get; set; }
        public string PfsettCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public int? PfsettAge { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
