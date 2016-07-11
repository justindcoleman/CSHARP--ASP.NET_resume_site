using System.Web;
using System.Web.Mvc;

namespace HomeworkW5D1_Website_ASP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
