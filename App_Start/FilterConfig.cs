using System.Web;
using System.Web.Mvc;

namespace rahul_prepod_frontend1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
