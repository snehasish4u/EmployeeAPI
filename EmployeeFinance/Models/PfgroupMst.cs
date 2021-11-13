using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PfgroupMst
    {
        public int RowId { get; set; }
        public int PfgroupId { get; set; }
        public string PfNo { get; set; }
        public string DbaFileCode { get; set; }
        public string FileExtension { get; set; }
        public string Address { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string PfgroupName { get; set; }
    }
}
