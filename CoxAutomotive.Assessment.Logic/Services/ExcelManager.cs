using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CoxAutomotive.Assessment.Core.IServices;
using CoxAutomotive.Assessment.Core.Models;


namespace CoxAutomotive.Assessment.Logic.Services
{
    public class ExcelManager : IExcelManager
    {
        public async Task<Result> Read(IFormFile file)
        {
            var rows = await BreakCsvToRowsAsync(file);

            return new Result(rows);
        }

        public Validation Validate(IFormFile file)
        {
            if (file == null) return new Validation(false, "No file was selected");

            if (!file.FileName.EndsWith(".csv"))
                return new Validation(false, "Only .csv extension is accepted");

            return new Validation(true, "");
        }

        public static async Task<IList<string>> BreakCsvToRowsAsync(IFormFile file)
        {
            var result = new List<string>();

            using var reader = new StreamReader(file.OpenReadStream(), Encoding.GetEncoding("iso-8859-1"));

            while (reader.Peek() >= 0)
                result.Add(await reader.ReadLineAsync());

            return result;
        }
    }
}