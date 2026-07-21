using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Project_Web_BHX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
