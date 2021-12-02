using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayheadSlab
    {
        public int PaySlabId { get; set; }
        public int? PayheadId { get; set; }
        public string PayheadCode { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string State { get; set; }
        public decimal? MinimumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public decimal? WomanAmount { get; set; }
        public decimal? JanAmount { get; set; }
        public decimal? FebAmount { get; set; }
        public decimal? MarAmount { get; set; }
        public decimal? AprAmount { get; set; }
        public decimal? MayAmount { get; set; }
        public decimal? JuneAmount { get; set; }
        public decimal? JulyAmount { get; set; }
        public decimal? AugAmount { get; set; }
        public decimal? SepAmount { get; set; }
        public decimal? OctAmount { get; set; }
        public decimal? NovAmount { get; set; }
        public decimal? DecAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
