using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tercer_clase.Models;
using System.Diagnostics;


namespace Tercer_clase.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult MostrarEmpleado()
        {
            Empleado el = new Empleado() { Codigo = 1234585, Nombre = "Alex" };
            return View(el);
        }
    }
}