using Microsoft.AspNetCore.Mvc;

namespace TrowBlog.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class PostController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
