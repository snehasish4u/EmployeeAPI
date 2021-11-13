using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class LumsumEditorMst
    {
        public int RowId { get; set; }
        public int LumsumEditorId { get; set; }
        public string LumsumEditorName { get; set; }
        public string LumsumEditorType { get; set; }
        public int? LumsumEditorGrade { get; set; }
        public decimal? LumsumEditorAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
