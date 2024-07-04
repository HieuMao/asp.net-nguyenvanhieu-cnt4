using System.Web;
using System.Web.Mvc;

namespace NvhK22CNT4Lesson11_2210900102
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
