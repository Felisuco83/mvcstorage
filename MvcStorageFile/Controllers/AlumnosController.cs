using Microsoft.AspNetCore.Mvc;
using MvcStorage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStorage.Controllers
{
    public class AlumnosController : Controller
    {
        ServiceTableAlumnos ServiceAlumnos;
        public AlumnosController(ServiceTableAlumnos service)
        {
            this.ServiceAlumnos = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index (string curso)
        {
            string token = await this.ServiceAlumnos.GetTokenAsync(curso);
            return View(this.ServiceAlumnos.GetAlumnos(token));
        }
    }
}
