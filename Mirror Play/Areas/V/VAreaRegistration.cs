using System.Web.Mvc;

namespace Mirror_Play.Areas.V
{
    public class VAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "V";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "V_default",
                "V/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}