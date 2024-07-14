using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AhmedOumezzine.FlashMessage
{
    public static partial class ExtensionMethods
    {

        public static List<string> GetModelStateErrors(this ModelStateDictionary modelState)
        {
            IEnumerable<string>? errors = from state in modelState.Values
                                         from error in state.Errors
                                         select error.ErrorMessage;

            List<string>? errorList = errors.ToList();

            if (errorList is not null && errorList.Count > 0)
                return errorList;
            else
                return new List<string>();
        }
    }
}
