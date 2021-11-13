using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class TblCompanyBranch
    {
        public int RowId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string BranchAddress2 { get; set; }
        public int? BranchPhoneNo { get; set; }
        public string BranchPersonName { get; set; }
        public string BranchEmail { get; set; }
        public int? BranchPfGroup { get; set; }
        public int? BranchPtGroup { get; set; }
        public int? BranchEsiGroup { get; set; }
    }
}
