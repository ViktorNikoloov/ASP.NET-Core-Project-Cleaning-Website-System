namespace CleaningWeb.Services.Data.Service
{
    using System.Collections.Generic;

    public interface IServiceService
    {
        IEnumerable<T> GetAllInFormationForService<T>();
    }
}
