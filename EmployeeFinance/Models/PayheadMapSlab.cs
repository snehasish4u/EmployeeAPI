using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayheadMapSlab
    {
        public int RowId { get; set; }
        public int PayheadMapSlabId { get; set; }
        public int? SalaryStrId { get; set; }
        public int? PayheadId { get; set; }
        public decimal? PaymapMinAmount { get; set; }
        public string PaymapMaxAmount { get; set; }
        public string PaymapType { get; set; }
        public decimal? PaymapAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PayheadMapId { get; set; }
    }
}
