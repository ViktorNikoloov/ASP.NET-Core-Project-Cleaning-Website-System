namespace CleaningWeb.Services.Data.Business
{
    using System.Linq;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class BusinessService : IBusinessService
    {
        private readonly IRepository<Business> businessRepository;

        public BusinessService(IRepository<Business> businessRepository)
        {
            this.businessRepository = businessRepository;
        }

        public T GetBusinessViewModel<T>()
        => this.businessRepository.AllAsNoTracking().To<T>().FirstOrDefault();
    }
}
