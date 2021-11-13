using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeFinance.Models;
using EmployeeManagement.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EmployeeFinance
{
    public class AdminManager : IAdminManager
    {
        public async Task<List<DesignationModel>> GetDesignation()
        {
            await using var context = new VYPAK_PAYROLLContext();
            var result = context.DesignationMsts.ToList();
            var designation = result.Select(x => new DesignationModel
            {
                Id = x.DesigId,
                Shortname = x.DesigShtName,
                DesignationName = x.DesigName
            });
            return designation.ToList();
        }
    }
}
