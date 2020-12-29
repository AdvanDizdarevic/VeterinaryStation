using System.Web.Mvc;

namespace VeterinaryStation.Areas.ModulDoktor
{
    public class ModulDoktorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ModulDoktor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ModulDoktor_default",
                "ModulDoktor/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}