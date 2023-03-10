using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmanWeb.Data;
using AmanWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmanWeb.Pages.Categories;

public class IndexModel : PageModel
{
	private readonly ApplicationDbContext _db;
	public IEnumerable<Category> Categories { get; set; }

	public IndexModel(ApplicationDbContext db)
	{
		_db = db;
	}

	public void OnGet()
	{
		Categories = _db.Category;
	}
}