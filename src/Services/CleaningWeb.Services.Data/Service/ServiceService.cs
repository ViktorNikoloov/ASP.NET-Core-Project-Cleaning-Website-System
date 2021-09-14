namespace CleaningWeb.Services.Data.Service
{
    using System.Collections.Generic;
    using System.Linq;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class ServiceService : IServiceService
    {
        private readonly IRepository<Service> serviceRepository;

        public ServiceService(IRepository<Service> serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }

        public IEnumerable<T> GetAllInFormationForService<T>()
            => this.serviceRepository
            .AllAsNoTracking()
            .To<T>()
            .ToList();
    }
}
