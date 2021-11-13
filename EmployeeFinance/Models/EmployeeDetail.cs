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
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string NomineeName { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Division { get; set; }
        public string Grade { get; set; }
        public string EmpAttendance { get; set; }
        public string BloodGroup { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PresentResNo { get; set; }
        public string PresentResName { get; set; }
        public string PresentRoad { get; set; }
        public string PresentArea { get; set; }
        public string PresentCity { get; set; }
        public string PresentState { get; set; }
        public string PresentPincode { get; set; }
        public string PermanentResNo { get; set; }
        public string PermanentResName { get; set; }
        public string PermanentRoad { get; set; }
        public string PermanentArea { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentState { get; set; }
        public string PermanentPincode { get; set; }
        public string MaritalStatus { get; set; }
        public string WardCircle { get; set; }
        public string BankAcNo { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string EmailId { get; set; }
        public bool? IsDefaultEmailId { get; set; }
        public string AltEmailId { get; set; }
        public bool? IsDefaultAltEmailId { get; set; }
        public string CcEmailId { get; set; }
        public string StdCode { get; set; }
        public string PhoneNo { get; set; }
        public string Mobile { get; set; }
        public string Panno { get; set; }
        public string AadharNo { get; set; }
        public string UanNo { get; set; }
        public string VoterId { get; set; }
        public string PassportNo { get; set; }
        public DateTime? MarriageDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesigId { get; set; }
        public int? EmpCateId { get; set; }
        public string EmployeeImage { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? SalaryCalcFrom { get; set; }
        public bool? IsLeaving { get; set; }
        public DateTime? DateOfLeave { get; set; }
        public string ReasonOfLeave { get; set; }
        public int? PastServiceInDay { get; set; }
        public bool? IsEsi { get; set; }
        public string EsiNo { get; set; }
        public string EsiDispensary { get; set; }
        public bool? IsPf { get; set; }
        public string PfNo { get; set; }
        public string PfDeptFile { get; set; }
        public bool? IsRestrictPf { get; set; }
        public bool? IsZeroPension { get; set; }
        public bool? IsZeroPt { get; set; }
        public bool? IsGri { get; set; }
        public string GriNo { get; set; }
        public bool? IsInsurance { get; set; }
        public string InsuranceNo { get; set; }
        public string IsDisabled { get; set; }
        public string IsInternationalworker { get; set; }
        public string IsHigherEpf { get; set; }
        public string IsHigherEps { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string SalaryStructureId { get; set; }
    }
}
