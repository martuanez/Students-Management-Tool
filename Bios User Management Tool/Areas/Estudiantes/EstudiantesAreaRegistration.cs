using System.Web.Mvc;

namespace Bios_User_Management_Tool.Areas.Estudiantes
{
    public class EstudiantesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Estudiantes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Estudiantes_default",
                "Estudiantes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
