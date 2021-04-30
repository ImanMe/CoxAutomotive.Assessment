using System.Threading.Tasks;
using CoxAutomotive.Assessment.Core.Models;
using Microsoft.AspNetCore.Http;

namespace CoxAutomotive.Assessment.Core.IServices
{
    public interface IExcelManager
    {
        Task<Result> ReadAndMap(IFormFile file);
        Validation Validate(IFormFile file);
    }
}
