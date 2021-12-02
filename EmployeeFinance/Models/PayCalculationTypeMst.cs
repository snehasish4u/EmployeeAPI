using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayCalculationTypeMst
    {
        public int Id { get; set; }
        public string CalculationType { get; set; }
        public string Allias { get; set; }
    }
}
