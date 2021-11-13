using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EsigroupMst
    {
        public int RowId { get; set; }
        public int EsigroupId { get; set; }
        public string EsigroupCode { get; set; }
        public string EsigroupName { get; set; }
        public string EsiNo { get; set; }
        public string EsiLocalOffice { get; set; }
        public string Address { get; set; }
        public bool? IsLimitEsiGross { get; set; }
        public bool? IsIndividualCalc { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
