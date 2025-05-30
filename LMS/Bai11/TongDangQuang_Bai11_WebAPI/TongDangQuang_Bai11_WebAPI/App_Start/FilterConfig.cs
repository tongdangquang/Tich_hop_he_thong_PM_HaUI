using System.Web;
using System.Web.Mvc;

namespace TongDangQuang_Bai11_WebAPI
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
