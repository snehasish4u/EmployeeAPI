using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeFinance.Models;

namespace EmployeeFinance
{
    public interface IAdminManager
    {
        Task<List<DesignationModel>> GetDesignation();
    }
}
