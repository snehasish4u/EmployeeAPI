using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class OccupationMaster
    {
        public int OccupationId { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationName { get; set; }
        public string OccupationShortName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
