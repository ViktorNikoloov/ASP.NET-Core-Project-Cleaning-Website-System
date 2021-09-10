namespace CleaningWeb.Services.Data.Company
{
    using System.Linq;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> companyRepository;

        public CompanyService(IRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public T GetCompanyInfoViewModel<T>()
        => this.companyRepository.AllAsNoTracking().To<T>().FirstOrDefault();

        public T GetCompanyViewModel<T>()
        => this.companyRepository.AllAsNoTracking().To<T>().FirstOrDefault();
    }
}
