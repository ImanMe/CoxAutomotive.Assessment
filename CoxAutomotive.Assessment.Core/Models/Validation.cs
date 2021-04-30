namespace CoxAutomotive.Assessment.Core.Models
{
    public class Validation
    {
        public Validation(bool isValid, string message)
        {
            IsValid = isValid;
            Message = message;
        }
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
