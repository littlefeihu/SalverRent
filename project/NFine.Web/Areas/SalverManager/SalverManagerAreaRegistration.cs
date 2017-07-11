using System.Web.Mvc;

namespace NFine.Web.Areas.SalverManager
{
    public class SalverManagerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SalverManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SalverManager_default",
                "SalverManager/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
