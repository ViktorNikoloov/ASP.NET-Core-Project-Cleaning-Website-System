namespace CleaningWeb.Services.Data.Administator
{
    using System.Collections.Generic;

    public interface IAdministratorService
    {
        IEnumerable<T> GetAllAppointments<T>();
    }
}
