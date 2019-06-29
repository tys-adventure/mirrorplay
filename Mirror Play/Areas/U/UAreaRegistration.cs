using System.Web.Mvc;

namespace Mirror_Play.Areas.U
{
    public class UAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "U";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "U_default",
                "U/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}