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
        public async Task CreateDesignation(DesignationModel model)
        {
            try
            {
                await using var context = new VYPAK_PAYROLLContext();
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
            catch (Exception e)
            {
                
            }
        }

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

        public async Task<DesignationModel> GetDesignationById(int id)
        {
            await using var context = new VYPAK_PAYROLLContext();
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
            await using (var context = new VYPAK_PAYROLLContext())
            {
                var existingStudent = context.DesignationMsts.Where(s => s.DesigId == model.Id).FirstOrDefault();

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
            try
            {

                await using var context = new VYPAK_PAYROLLContext();
                string[] values = ids.Split(',');
                foreach (var val in values)
                {
                    var designation = context.DesignationMsts.FirstOrDefault(x => x.DesigId == Convert.ToInt32(val));
                    context.DesignationMsts.Remove(designation);
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

    }
}
