using HostedRclDebug.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HostedRclDebug.Server.Controllers
{
	[Route("~/")]
	public class HostController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
