using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.DataAccess;
using WebApplication9.DataAccess.Model;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDataProvider _db;
        public HomeController(ILogger<HomeController> logger, IDataProvider context)
        {
            _logger = logger;
            _db = context;
        }

        [HttpGet]
        public IActionResult BidPrice([FromForm] int Companyid)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return View(Companyid);
        }
        [HttpPost]
        public string Bid(DateTime Dt, int Price, string CompId)
        {
            var bid = new Bid();
            bid.Dt = DateTime.Now;
            bid.Price = Price;
            CompId = CompId.TrimEnd('/');
            Guid cid;
            if (Guid.TryParse(CompId, out cid))
            {
                Company cp = _db.Companies.First(c => c.Id == Guid.Parse(CompId));
                bid.CompanyId = cp;
                if (cp != null)
                    _db.Bids.Add(bid);
                else
                    return "Компания не найдена";
                
                //тут правильнее сделать цикл который чистит все записи больше до 20
                if (_db.Bids.Count(b => b.CompanyId == cp) > 20)
                {
                    var firstbid = _db.Bids.OrderByDescending(b => b.Dt).First();
                    _db.Bids.Remove(firstbid);
                }
                _db.SaveChanges();
                return "Спасибо, " + bid.Dt + "!";
            }
            return "Не добавилось! Не корректная ссылка на компанию";
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
