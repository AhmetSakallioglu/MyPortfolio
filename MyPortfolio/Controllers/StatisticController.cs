using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.YetenekSayisi = context.Skills.Count();
			ViewBag.MesajSayisi = context.Messages.Count();
			ViewBag.OkunmayanMesaj = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.OkunanMesaj = context.Messages.Where(x => x.IsRead == true).Count();

			return View();
		}
	}
}
