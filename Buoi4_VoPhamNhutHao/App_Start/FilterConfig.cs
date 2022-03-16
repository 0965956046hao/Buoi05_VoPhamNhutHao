using System.Web;
using System.Web.Mvc;

namespace Buoi4_VoPhamNhutHao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
