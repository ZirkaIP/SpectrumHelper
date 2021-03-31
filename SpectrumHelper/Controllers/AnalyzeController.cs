using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpectrumHelper.ViewModels;

namespace SpectrumHelper.Controllers
{
	public class AnalyzeController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}

		public IActionResult SendToAnalyze(IncomingParameters parameterss)
		{
			return View(Index());
		}
	}
}
