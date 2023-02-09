using System.Web;
using System.Web.Mvc;

namespace Aplicacion_MVC_SerieIII
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
