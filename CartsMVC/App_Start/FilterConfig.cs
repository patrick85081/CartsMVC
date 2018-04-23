using System.Web;
using System.Web.Mvc;

namespace CartsMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //filters.Add(new ApiResponseAttribute());
            //filters.Add(new CartsMVC.Controllers.ApiResultAttribute());
        }
    }
}
