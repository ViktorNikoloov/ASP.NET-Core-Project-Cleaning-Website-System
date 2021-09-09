namespace CleaningWeb.Services.Data.About
{
    using System.Linq;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class AboutService : IAboutService
    {
        private readonly IRepository<Business> businessRepository;
        private readonly IRepository<Company> companyRepository;

        public AboutService(
            IRepository<Business> businessRepository,
            IRepository<Company> companyRepository)
        {
            this.businessRepository = businessRepository;
            this.companyRepository = companyRepository;
        }

        public T GetBusinessViewModel<T>()
        => this.businessRepository.AllAsNoTracking().To<T>().FirstOrDefault();

        public T GetCompanyViewModel<T>()
        => this.companyRepository.AllAsNoTracking().To<T>().FirstOrDefault();
    }
}
