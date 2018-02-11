using System.Web;
using System.Web.Mvc;

namespace EPSI_IC_FirstSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
