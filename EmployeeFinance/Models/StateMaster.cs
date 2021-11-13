using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class StateMaster
    {
        public StateMaster()
        {
            CityMasters = new HashSet<CityMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public virtual CountryMaster Country { get; set; }
        public virtual ICollection<CityMaster> CityMasters { get; set; }
    }
}
