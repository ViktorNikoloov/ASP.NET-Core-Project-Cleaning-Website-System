namespace CleaningWeb.Services.Data.Company
{
    public interface ICompanyService
    {
        T GetCompanyInfoViewModel<T>();

        T GetCompanyViewModel<T>();
    }
}
