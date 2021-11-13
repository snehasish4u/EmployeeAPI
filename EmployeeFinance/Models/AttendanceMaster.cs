using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class AttendanceMaster
    {
        public int AttendanceId { get; set; }
        public string AttendanceCode { get; set; }
        public string AttendanceName { get; set; }
        public string AttendanceSalaryType { get; set; }
        public string AttendanceOtType { get; set; }
        public string SalaryCalendarType { get; set; }
        public string AttendanceRegType { get; set; }
        public string IsMorethanWorkDay { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
