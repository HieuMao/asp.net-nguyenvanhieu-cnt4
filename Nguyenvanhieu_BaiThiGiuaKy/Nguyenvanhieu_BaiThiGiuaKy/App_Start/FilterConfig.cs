using System.Web;
using System.Web.Mvc;

namespace Nguyenvanhieu_BaiThiGiuaKy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
