using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeSalaryStructure
    {
        public int RowId { get; set; }
        public string EmpSalStrId { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public string EmployeeId { get; set; }
        public string PayheadId { get; set; }
        public decimal? Amount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
