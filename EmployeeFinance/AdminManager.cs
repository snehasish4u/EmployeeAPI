using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeFinance.Dto;
using EmployeeFinance.Models;
using Microsoft.Extensions.Configuration;

namespace EmployeeFinance
{
    public class AdminManager : IAdminManager
    {
        private readonly IConfiguration _iConfiguration;

        public AdminManager(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }
        #region Designation
        public async Task CreateDesignation(DesignationModel model)
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            int newId = context.DesignationMsts.Max(x => x.DesigId);
            context.DesignationMsts.Add(new DesignationMst()
            {
                DesigId = newId + 1,
                DesigCode = string.Concat("DESG", newId + 1),
                DesigName = model.DesignationName,
                DesigShtName = model.Shortname
            });

            context.SaveChanges();
        }

        public async Task<List<DesignationModel>> GetDesignation()
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            var result = context.DesignationMsts.ToList();
            var designation = result.Select(x => new DesignationModel
            {
                Id = x.DesigId,
                Shortname = x.DesigShtName,
                DesignationName = x.DesigName
            });
            return designation.ToList();
        }

        public async Task<DesignationModel> GetDesignationById(int id)
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            var designation = context.DesignationMsts.FirstOrDefault(s => s.DesigId == id);
            var designationModel = new DesignationModel();
            if (designation != null)
            {
                designationModel = new DesignationModel
                {
                    Id = designation.DesigId,
                    Shortname = designation.DesigShtName,
                    DesignationName = designation.DesigName
                };
            }

            return designationModel;
        }

        public async Task UpdateDesignation(DesignationModel model)
        {
            await using (var context = new VYPAK_PAYROLLContext(_iConfiguration))
            {
                var existingStudent = context.DesignationMsts.FirstOrDefault(s => s.DesigId == model.Id);

                if (existingStudent != null)
                {
                    existingStudent.DesigName = model.DesignationName;
                    existingStudent.DesigShtName = model.Shortname;

                    context.SaveChanges();
                }
            }
        }

        public async Task DeleteDesignation(string ids)
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            string[] values = ids.Split(',');
            foreach (var val in values)
            {
                var designation = context.DesignationMsts.FirstOrDefault(x => x.DesigId == Convert.ToInt32(val));
                context.DesignationMsts.Remove(designation);
            }

            context.SaveChanges();
        }
        #endregion

        #region PayHead
        
        public async Task<List<PayCalculationType>> GetPayHeadCalculationTypes()
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            var calculationTypeList = context.PayCalculationTypeMsts.Select(x => new PayCalculationType
            {
                Id = x.Id,
                CalculationType = x.CalculationType,
                Allias = x.Allias
            }).ToList();
            return calculationTypeList;
        }

        public async Task<List<PayHeadMst>> GetPayHeadNames()
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            var payHeadNames = context.PayHeadMsts.Select(x => new PayHeadMst
            {
                PayHeadName = x.PayHeadName
            });
            return payHeadNames.ToList();
        }

        public async Task<List<PayHeadAttachType>> GetPayHeadAttachments()
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            var payHeadAttachments = context.PayHeadAttacheMsts.Select(x => new PayHeadAttachType
            {
                Id = x.Id,
                AttachTo = x.AttachTo,
                Allias = x.Allias
            });
            return payHeadAttachments.ToList();
        }

        public async Task SavePayDetailsMapping(PayHeadDetailDto payHeadDetailDto)
        {
            await using var context = new VYPAK_PAYROLLContext(_iConfiguration);
            int newId = context.DesignationMsts.Max(x => x.DesigId);
            context.PayHeadDetails.Add(new PayHeadDetail
            {
                EffectiveFrom = payHeadDetailDto.EffectiveFrom,
                Grade = payHeadDetailDto.Grade,
                PayheadId = payHeadDetailDto.PayheadId,
                PayheadCode = payHeadDetailDto.PayheadCode ?? "H01",
                PayheadName = payHeadDetailDto.PayheadName ?? "Engineering Dept",
                PaymapCalcType = payHeadDetailDto.PaymapCalcType,
                Narration = payHeadDetailDto.Narration,
                AttachAs = payHeadDetailDto.AttachAs,
                Formula = payHeadDetailDto.Formula,
                PrintInSlip = payHeadDetailDto.PrintInSlip == "True" ? "Y" : "N",
                RoundOff = payHeadDetailDto.RoundOff == "True" ? "Y" : "N",
                ClacOnPresentDay = payHeadDetailDto.ClacOnPresentDay == "True" ? "Y" : "N",
                IsWeeklyOff = payHeadDetailDto.IsWeeklyOff == "True" ? "Y" : "N",
                IsTaxable = payHeadDetailDto.IsTaxable,
                ExemptionLimit = payHeadDetailDto.ExemptionLimit,
                IsExcludeFromCtc = payHeadDetailDto.IsExcludeFromCtc,
                CreatedBy = payHeadDetailDto.CreatedBy,
                CreatedOn = DateTime.Now,
                ModifiedBy = payHeadDetailDto.ModifiedBy,
                ModifiedOn = DateTime.Now,
                IsDeleted = false
            });

            context.SaveChanges();
        }

        #endregion
    }
}
