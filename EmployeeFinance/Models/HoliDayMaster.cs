using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class HoliDayMaster
    {
        public int HolidayId { get; set; }
        public string HolidayCode { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsNationalHoliday { get; set; }
        public string IsBranchWise { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
