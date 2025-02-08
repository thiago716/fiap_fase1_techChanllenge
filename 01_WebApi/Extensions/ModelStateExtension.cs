using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApi.Extensions;

public static class ModelStateExtension
{
    public static List<string> GetErrors(this ModelStateDictionary modelState)
    {
        var errorList = new List<string>();
        
        foreach (var item in modelState.Values)
        {
            errorList.AddRange(item.Errors.Select(x => x.ErrorMessage));
        }

        return errorList;
    }
}
