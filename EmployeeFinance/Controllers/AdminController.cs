using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [Route("GetDesignation")]
        [HttpGet]
        public async Task<IActionResult> GetDesignation()
        {
            var result = await _adminManager.GetDesignation();
            return this.Ok(result);
        }
    }
}
