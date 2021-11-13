using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class CityMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StateId { get; set; }

        public virtual StateMaster State { get; set; }
    }
}
