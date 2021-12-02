using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class BankMaster
    {
        public int BankId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankShtName { get; set; }
        public string BankAccNo { get; set; }
        public string Address { get; set; }
        public int? PinNo { get; set; }
        public string PhoneNo { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string AccountType { get; set; }
        public string MicrCode { get; set; }
        public string IfscCode { get; set; }
        public string RtgsCode { get; set; }
        public string NeftCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
