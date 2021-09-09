namespace CleaningWeb.Services.Data.About
{
    public interface IAboutService
    {
        T GetBusinessViewModel<T>();

        T GetCompanyViewModel<T>();
    }
}
