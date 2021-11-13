using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class CountryMaster
    {
        public CountryMaster()
        {
            StateMasters = new HashSet<StateMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public virtual ICollection<StateMaster> StateMasters { get; set; }
    }
}
