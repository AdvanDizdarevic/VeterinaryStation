using System.Web.Mvc;

namespace VeterinaryStation.Areas.ModulKorisnickiNalog
{
    public class ModulKorisnickiNalogAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ModulKorisnickiNalog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ModulKorisnickiNalog_default",
                "ModulKorisnickiNalog/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}