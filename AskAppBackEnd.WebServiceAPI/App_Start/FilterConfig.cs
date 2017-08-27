using System.Web;
using System.Web.Mvc;

namespace AskAppBackEnd.WebServiceAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //in production uncommented this filter
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}
