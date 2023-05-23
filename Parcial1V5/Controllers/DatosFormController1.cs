using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parcial1V5.Models;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Parcial1V5.Controllers
{
    public class DatosFormController1 : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult MostrarDatos()
        {
            DatosForm obj = new DatosForm();

            

            obj.Cuit = int.Parse(Request.Form["Cuit"]);
            obj.RazonSocial = Request.Form["Rsocial"];
            obj.Domicilio = Request.Form["Domicilio"];
            obj.Email = Request.Form["Email"];

            return View(obj);
        }
    }
}
