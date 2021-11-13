using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class EmployeeTrainingDtl
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeTraId { get; set; }
        public string TrainingName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Comments { get; set; }
        public string Remarks { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
