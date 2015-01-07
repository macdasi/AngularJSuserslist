using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tzunami_test.Infa
{
    public class BaseController : Controller
    {
        public List<string> GetErrorsFromModelState()
        {
            string mError = string.Empty;
            var errors = ModelState.SelectMany(x => x.Value.Errors.Select(error => error.ErrorMessage)).ToList();
            return errors;
        }
    }
}