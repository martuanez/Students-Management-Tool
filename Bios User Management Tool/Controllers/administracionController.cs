using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bios_User_Management_Tool.Controllers
{
    [Authorize(Roles = "Admin")]
    public class administracionController : Controller
    {
        //
        // GET: /administracion/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alumnos()
        {
            return View();
        }

        public ActionResult Alumnos(int Id)
        {
            return View();
        }

        public ActionResult Docentes()
        {
            return View();
        }

        public ActionResult Docentes(int Id)
        {
            return View();
        }
        
        public ActionResult Cursos()
        {
            return View();
        }

        public ActionResult Cursos(int Id)
        {
            return View();
        }
    }
}
