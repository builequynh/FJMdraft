using System.ComponentModel.DataAnnotations;

namespace FJMdraft.Utility.Helpers
{
    public class GreaterThanToday : ValidationAttribute
    {
        public override bool IsValid(object? value) /*ghi đè IsValid trong parent class
                                                     value có thể rỗng*/
        {
            if (value is DateOnly deadlineDate) /*check: value là DateOnly 
                                                 * -> gán value vào deadlineDate*/
            {
                return deadlineDate > DateOnly.FromDateTime(DateTime.Today); /*So sánh deadline và thời gian thực. 
                                                                              Deadline ở sau currentDate --> trả true*/
            }

            return true;
        }
    }
}
