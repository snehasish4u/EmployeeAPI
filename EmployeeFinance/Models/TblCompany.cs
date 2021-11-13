using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class TblCompany
    {
        public int RowId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPersonName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddress2 { get; set; }
        public int? CompanyPhoneNo { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyCinno { get; set; }
        public string CompanyGstno { get; set; }
        public bool? ComapnyIsPf { get; set; }
        public string CompanyPfno { get; set; }
        public string CompanyDbafileCode { get; set; }
        public string CompanyPfExtn { get; set; }
        public bool? ComapnyIsPfvol { get; set; }
        public bool? ComapnyIsPfmultigrp { get; set; }
        public bool? ComapnyIsEsi { get; set; }
        public string CompanyEsiNo { get; set; }
        public string CompanyEsiLocalOfc { get; set; }
        public bool? IndvCalculateEmpEsi { get; set; }
        public bool? LimitEsiGross { get; set; }
        public bool? IsEsiMultipleGroup { get; set; }
        public bool? ComapnyIsTds { get; set; }
        public string ComapnyTanNo { get; set; }
        public string CompanyType { get; set; }
        public bool? ComapnyIsBonus { get; set; }
        public bool? ComapnyIsItr { get; set; }
        public bool? ComapnyIsPt { get; set; }
        public bool? ComapnyIsSupSalary { get; set; }
        public bool? ComapnyIsGratuity { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
