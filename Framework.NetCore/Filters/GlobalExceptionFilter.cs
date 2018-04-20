using Microsoft.AspNetCore.Mvc.Filters;
using Framework.NetCore.Helpers;

namespace Framework.NetCore.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var type = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
            Log4NetHelper.WriteError(type, filterContext.Exception);
        }
    }
}
