namespace MyReddit.Data.Seeding
{
    using MyReddit.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<string> { "Beauty","Sport","Health","Food" };

            foreach (var category in categories)
            {
                dbContext.Categories.Add(new Category
                {
                    Name = category,
                    Title = category,
                    Description = category,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfCZbQxq2JneYZetHTNrF--jc3sriaUco-2uM3JD17PA&s",
                });
            }
        }
    }
}
