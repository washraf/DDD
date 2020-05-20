using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utils.Validation
{
    public static class ValidationExtensions
    {
        public static Dictionary<string,string> ToDictionary(this ValidationResult result)
        {
            return result.Errors.ToDictionary(
                    x => x.PropertyName, x => x.ErrorMessage);
        }
    }
}
