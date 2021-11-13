using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PtgroupMst
    {
        public int PtgroupId { get; set; }
        public string PtgroupCode { get; set; }
        public string PtgroupName { get; set; }
        public int? StateId { get; set; }
        public string CertificateNo { get; set; }
        public string PtoNo { get; set; }
        public string PtAddress { get; set; }
        public string ReturnPeriod { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
