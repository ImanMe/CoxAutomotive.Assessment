using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CoxAutomotive.Assessment.Core.Models;

namespace CoxAutomotive.Assessment.Core.IServices
{
    public interface IExcelManager
    {
        Task<Result> ReadAndMap(IFormFile file);
        Validation Validate(IFormFile file);
    }
}
