using System.Web;
using System.Web.Mvc;

namespace Oct9_2017SuggestionBoxMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
