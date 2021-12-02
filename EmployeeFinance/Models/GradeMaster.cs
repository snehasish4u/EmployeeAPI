using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class GradeMaster
    {
        public int RowId { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string GradeAlias { get; set; }
        public string ClaculateBasedOn { get; set; }
        public decimal? BasicAmount { get; set; }
        public int? NoticePeriod { get; set; }
        public string Email { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
