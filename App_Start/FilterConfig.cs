using System.Web;
using System.Web.Mvc;

namespace AppDev3B_AI_Assignment_2019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
