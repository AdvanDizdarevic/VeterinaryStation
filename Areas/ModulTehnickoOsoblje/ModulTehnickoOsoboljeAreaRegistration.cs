using System.Web.Mvc;


namespace VeterinaryStation.Areas.ModulTehnickoOsoblje
{
    public class ModulTehnickoOsoboljeAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ModulTehnickoOsoblje";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ModulTehnickoOsoblje_default",
                "ModulTehnickoOsoblje/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}