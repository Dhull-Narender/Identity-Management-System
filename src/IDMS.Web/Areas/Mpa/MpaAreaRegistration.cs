using System.Web.Mvc;

namespace IDMS.Web.Areas.Mpa
{
    public class MpaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Mpa";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mpa_default_route",
                "Mpa/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}