using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2019MH604_2019ZH601.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019MH604_2019ZH601.Controllers
{
    public class CovidController : Controller
    {

        private readonly dbContext _context;

        public CovidController(dbContext miContexto) 
        {
            this._context = miContexto;
        }
        public IActionResult Index()
        {
            ViewData["Titulo"] = "Registro de Covid";

            IEnumerable<Departamentos> listaDepartamentos = from d in _context.departamentos
                                                            select d;
            List<SelectListItem> ComboDepartamentos = new List<SelectListItem>();

            foreach (Departamentos departamento in listaDepartamentos)
            {
                SelectListItem miOpcion = new SelectListItem
                {
                    Text = departamento.Departamento,
                    Value = departamento.IdDepartamento.ToString()
                };
                ComboDepartamentos.Add(miOpcion);
            }
            ViewBag.ComboDepartamentos = ComboDepartamentos;


            IEnumerable<Generos> listaGeneros = from g in _context.generos
                                                select g;

            List<SelectListItem> ComboGeneros = new List<SelectListItem>();
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
