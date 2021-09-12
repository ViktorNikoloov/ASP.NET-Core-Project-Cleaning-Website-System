namespace CleaningWeb.Web.ViewModels.Service
{
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class ServiceViewModel : IMapFrom<Service>
    {
        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
