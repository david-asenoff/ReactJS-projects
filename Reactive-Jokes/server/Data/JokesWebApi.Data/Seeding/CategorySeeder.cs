namespace JokesWebApi.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using JokesWebApi.Data.Models;

    internal class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/HVq4Cd3/1.jpg", Name = "Big Brother" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/fxNqZ4m/2.jpg", Name = "Microsoft" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/LRk1xgT/3.jpg", Name = "SMS" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/K61nHpP/4.jpg", Name = "Авто" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/j5bsjDW/5.jpg", Name = "Блондинки" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/T4HPPDQ/6.jpg", Name = "Графити" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/THpZ3YR/7.jpg", Name = "Животни" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/L9pSCp8/8.jpg", Name = "Знаете ли че..." });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/44QLVKQ/9.jpg", Name = "Истории" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/L8jk7pf/10.jpg", Name = "Компютри" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/tctyJdL/11.jpg", Name = "Лафоризми" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/3rswJGH/12.jpg", Name = "Мечо Пух" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/DwkS3rJ/13.jpg", Name = "Мръсни" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/xfndhM8/14.jpg", Name = "Пиянски" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/hyZGZKj/15.jpg", Name = "По новините" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/KhrYGq0/16.jpg", Name = "Политически" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/jhr7VG1/17.jpg", Name = "Приказни" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/Jrccd5W/18.jpg", Name = "Професионални" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/mDsxKfx/19.jpg", Name = "Разни" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/S7Jbp0B/20.jpg", Name = "С*кс" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/2jg5zqT/21.jpg", Name = "Само в България" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/VMcyGW3/22.jpg", Name = "Семейни" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/CJRCZ1f/23.jpg", Name = "Спорт" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/tqQN3v2/24.jpg", Name = "Студентски" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/BjkcT0t/25.jpg", Name = "Ученически" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/Sn6KHrm/26.jpg", Name = "Черен хумор" });
            await dbContext.Categories.AddAsync(new Category { PictureUrl = "https://i.ibb.co/m4sNxXQ/27.jpg", Name = "Чък Норис" });

            await dbContext.SaveChangesAsync();
        }
    }
}
