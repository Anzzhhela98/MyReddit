﻿namespace MyReddit.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyReddit.Data;
    using MyReddit.Web.ViewModels;
    using MyReddit.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();

            var categories = this.db.Categories.Select(x => new IndexCategoryViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
            }).ToList();

            viewModel.Categories = categories;
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
