using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EmployeeFinance.Dto;

namespace EmployeeFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager _adminManager;
        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }

        #region Designation
        [Route("GetDesignation")]
        [HttpGet]
        public async Task<IActionResult> GetDesignation()
        {
            var result = await _adminManager.GetDesignation();
            return this.Ok(result);
        }

        [Route("GetDesignationById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetDesignationById(int id)
        {
            var result = await _adminManager.GetDesignationById(id);
            return this.Ok(result);
        }

        [Route("CreateDesignation")]
        [HttpPost]
        public async Task CreateDesignation([FromBody] DesignationModel model)
        {
            await _adminManager.CreateDesignation(model);
        }

        [Route("UpdateDesignation")]
        [HttpPut]
        public async Task UpdateDesignation([FromBody] DesignationModel model)
        {
            await _adminManager.UpdateDesignation(model);
        }


        [Route("DeleteDesignation/{ids}")]
        [HttpDelete]
        public async Task DeleteDesignation(string ids)
        {
            await _adminManager.DeleteDesignation(ids);
        }
        #endregion

        #region PayHead
        [Route("GetPayHeadCalculationTypes")]
        [HttpGet]
        public async Task<IActionResult> GetPayHeadCalculationTypes()
        {
            var result = await _adminManager.GetPayHeadCalculationTypes();
            return this.Ok(result);
        }

        [Route("GetPayHeadNames")]
        [HttpGet]
        public async Task<IActionResult> GetPayHeadNames()
        {
            var result = await _adminManager.GetPayHeadNames();
            return this.Ok(result);
        }

        [Route("GetPayHeadAttachments")]
        [HttpGet]
        public async Task<IActionResult> GetPayHeadAttachments()
        {
            var result = await _adminManager.GetPayHeadAttachments();
            return this.Ok(result);
        }

        [Route("SavePayDetailsMapping")]
        [HttpPost]
        public async Task SavePayDetailsMapping([FromBody] PayHeadDetailDto payHeadDetailDto)
        {
            await _adminManager.SavePayDetailsMapping(payHeadDetailDto);
        }

        #endregion

    }
}
