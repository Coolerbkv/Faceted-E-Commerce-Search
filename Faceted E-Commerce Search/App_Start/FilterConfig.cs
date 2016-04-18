using System.Web;
using System.Web.Mvc;

namespace Faceted_E_Commerce_Search
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
