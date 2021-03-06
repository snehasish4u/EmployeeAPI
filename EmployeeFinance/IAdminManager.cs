using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeFinance.Dto;
using EmployeeFinance.Models;

namespace EmployeeFinance
{
    public interface IAdminManager
    {
        Task<List<DesignationModel>> GetDesignation();
        Task CreateDesignation(DesignationModel model);
        Task UpdateDesignation(DesignationModel model);
        Task DeleteDesignation(string ids);
        Task<DesignationModel> GetDesignationById(int id);
        Task<List<PayCalculationType>> GetPayHeadCalculationTypes();
        Task<List<PayHeadMst>> GetPayHeadNames();
        Task<List<PayHeadAttachType>> GetPayHeadAttachments();
        Task SavePayDetailsMapping(PayHeadDetailDto payHeadDetailDto);
    }
}
