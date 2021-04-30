using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoxAutomotive.Assessment.Core.IServices;

namespace CoxAutomotive.Assessment.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IExcelManager _excelManager;

        public UploadController(IExcelManager excelManager)
        {
            _excelManager = excelManager;
        }

        public async Task<IActionResult> Post(IFormFile file)
        {
            try
            {
                var validation = _excelManager.Validate(file);

                if (!validation.IsValid) return BadRequest(validation.Message);

                var result  = await _excelManager.ReadAndMap(file);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Excel file is not in expected format - {e.Message}");
            }
        }
    }
}
