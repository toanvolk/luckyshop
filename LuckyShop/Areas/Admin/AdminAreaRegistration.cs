using System.Web.Mvc;

namespace LuckyShop.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("trangchu", "admin/trang-chu", new { controller = "Home", action = "Index" }, new string[] { "LuckyShop.Areas.Admin.Controllers" });
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "LuckyShop.Areas.Admin.Controllers" }
            );
        }
    }
}