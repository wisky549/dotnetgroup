using DNG.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace DotNetGroup.Controllers
{
    public class BaseController : Controller
    {
        protected Rep<T> GetRep<T>(ModelStateDictionary modelState)
        {
            var rep = new Rep<T>();

            if (!modelState.IsValid)
            {
                var error = modelState.Values.First(m => m.Errors.Count > 0);

                rep.Message = error.Errors[0].ErrorMessage;
            }
            else
            {
                rep.Success = true;
            }

            return rep;
        }
    }
}
