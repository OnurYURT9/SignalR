using Covid19SignalR.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19SignalR.Controllers
{
    public class CovidsController : Controller
    {
        private readonly CovidService _service;

        public CovidsController(CovidService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> SaveCovid(Covid covid)
        {
            await _service.SaveCovid(covid);
            List<Covid> covidList = _service.GetList().ToList();
            return Ok(covidList);
        }
        [HttpGet]
        public IActionResult InitializeCovid()
        {
            Random rnd = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach(ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newcovid = new Covid { City = item,Count= rnd.Next(100, 1000), CovidDate = DateTime.Now.AddDays(x)};
                     _service.SaveCovid(newcovid).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });
            return Ok("Covid-19 dataları veri tabanına kaydedildi");
        } 
    }
}
