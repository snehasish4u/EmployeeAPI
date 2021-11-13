using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PfEsiRateSetting
    {
        public int PfEsiRateId { get; set; }
        public string PfEsiRateCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public decimal PfRate { get; set; }
        public decimal PfCutOff { get; set; }
        public bool? IsAplySpecCutOff { get; set; }
        public decimal? PfSpecCutOff { get; set; }
        public decimal PfEmployerPension { get; set; }
        public decimal EmprPfRate { get; set; }
        public string PfRoundOff { get; set; }
        public bool? PfIsRestEmprShare { get; set; }
        public bool? PfIsRestEmplToEmpr { get; set; }
        public decimal EsiEmplRate { get; set; }
        public decimal EsiEmprRate { get; set; }
        public decimal EsiCutOff { get; set; }
        public decimal EsiMinWage { get; set; }
        public string EsiRoundOff { get; set; }
        public decimal Acc02 { get; set; }
        public decimal Acc21 { get; set; }
        public decimal Acc22 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
