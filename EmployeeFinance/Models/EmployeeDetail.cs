using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeDetail
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Occupation { get; set; }
        public int? Grade { get; set; }
        public string Branch { get; set; }
        public int? Department { get; set; }
        public int? Designation { get; set; }
        public int? Division { get; set; }
        public int? Category { get; set; }
        public int? Project { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? DateOfConfirm { get; set; }
        public DateTime? ResignOfferDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public DateTime? LastIncrementDate { get; set; }
        public DateTime? ProbationDate { get; set; }
        public DateTime? ProcessStartDate { get; set; }
        public string ResidentialPhone { get; set; }
        public string ResidentialMobile { get; set; }
        public string PersonalPhone { get; set; }
        public string PersonalEmail { get; set; }
        public string AlternateEmail { get; set; }
        public string ExtensionNo { get; set; }
        public string OfficePhone { get; set; }
        public string CcEmailId { get; set; }
        public string PresentPlot { get; set; }
        public string PresentArea { get; set; }
        public string PresentStreet { get; set; }
        public string PresentTown { get; set; }
        public string PresentCity { get; set; }
        public string PresentDistrict { get; set; }
        public string PresentState { get; set; }
        public string PresentPincode { get; set; }
        public string PermanentPlot { get; set; }
        public string PermanentArea { get; set; }
        public string PermanentStreet { get; set; }
        public string PermanentTown { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentDistrict { get; set; }
        public string PermanentState { get; set; }
        public string PermanentPincode { get; set; }
        public string MaritalStatus { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string SpouseName { get; set; }
        public string BankName { get; set; }
        public string BankAcNo { get; set; }
        public string Panno { get; set; }
        public string UanNo { get; set; }
        public string PranNo { get; set; }
        public string AadharNo { get; set; }
        public string GratuityCode { get; set; }
        public DateTime? GroupJoinDate { get; set; }
        public string EmployeeType { get; set; }
        public string Remarks { get; set; }
        public bool? IsPt { get; set; }
        public string PtNo { get; set; }
        public bool? IsPf { get; set; }
        public string PfNo { get; set; }
        public DateTime? PfJoinDate { get; set; }
        public string FpfNo { get; set; }
        public string PfNewVersion { get; set; }
        public decimal? Vpf { get; set; }
        public string PfRemark { get; set; }
        public bool? IsEsic { get; set; }
        public string EsicImpCode { get; set; }
        public string EsicOldNo { get; set; }
        public string EsicImpName { get; set; }
        public string EsicNewVersion { get; set; }
        public string EsicRemark { get; set; }
        public string EmployeeImage { get; set; }
        public bool? IsLeaving { get; set; }
        public DateTime? DateOfLeave { get; set; }
        public string ReasonOfLeave { get; set; }
        public int? PastServiceInDay { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
