using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayHeadMapMaster
    {
        public int RowId { get; set; }
        public string PayheadMapId { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public int? SalaryStruId { get; set; }
        public string PayheadId { get; set; }
        public string PaymapCalcBasic { get; set; }
        public string PaymapCalcType { get; set; }
        public decimal? PaymapCalcRate { get; set; }
        public string FormulaName { get; set; }
        public string FormulaValue { get; set; }
        public decimal? CutoffAmount { get; set; }
        public string RoundOff { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
