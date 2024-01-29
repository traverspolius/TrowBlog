using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrowBlog.Web.Data;
using TrowBlog.Web.ViewModels;

namespace TrowBlog.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class PostController : Controller
	{
		private readonly ApplicationDbContext _context;

		public PostController(ApplicationDbContext context)
		{
			_context = context; //part 16 - 4:30
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View(new CreatePostVM());
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreatePostVM vm)
		{
			if (!ModelState.IsValid) 
			{ 
				return View(vm);
			}
			return View();
		}
	}
}
