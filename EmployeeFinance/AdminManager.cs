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
            await using var context = new VYPAK_PAYROLLContext();
            var result = context.DesignationMsts.Add(new DesignationMst()
            {
                DesigId = model.Id,
                DesigName =model.DesignationName,
                DesigShtName = model.Shortname
            });

            context.SaveChanges();
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
                else
                {
                    //return NotFound();
                    
                }
            }
            //return Ok();
        }
        public async Task DeleteDesignation(int id)
        {
           await using (var context = new VYPAK_PAYROLLContext())
            {
                var designation = context.DesignationMsts
                    .Where(s => s.DesigId == id)
                    .FirstOrDefault();

                context.Entry(designation).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
