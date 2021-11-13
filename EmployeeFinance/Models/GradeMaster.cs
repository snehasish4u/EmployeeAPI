﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class GradeMaster
    {
        public int RowId { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
