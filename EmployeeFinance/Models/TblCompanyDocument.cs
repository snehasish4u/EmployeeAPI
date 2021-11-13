using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class TblCompanyDocument
    {
        public int RowId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyFileName { get; set; }
        public byte[] FileData { get; set; }
    }
}
