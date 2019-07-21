using ChartsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartsApplication.Controllers
{
    public class ColumnChartController:Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public JsonResult PopulationChart()
        {
            var populationList = PopulationDataAccessLayer.GetCityPopulationList();

            return Json(populationList);
        }
    }
}
