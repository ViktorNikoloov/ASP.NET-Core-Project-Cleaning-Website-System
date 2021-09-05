namespace CleaningWeb.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(CleaningDbContext dbContext, IServiceProvider serviceProvider);
    }
}
