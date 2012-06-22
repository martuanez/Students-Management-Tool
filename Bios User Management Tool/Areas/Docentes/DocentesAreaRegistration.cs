using System.Web.Mvc;

namespace Bios_User_Management_Tool.Areas.Docentes
{
    public class DocentesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Docentes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Docentes_default",
                "Docentes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
