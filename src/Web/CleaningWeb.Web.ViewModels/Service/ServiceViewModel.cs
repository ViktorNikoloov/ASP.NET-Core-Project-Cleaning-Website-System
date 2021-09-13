namespace CleaningWeb.Web.ViewModels.Service
{
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class ServiceViewModel : IMapFrom<Service>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description?.Length > 60 ? this.Description?.Substring(0, 50) + "..." : this.Description;

        public string Image { get; set; }

        public string Url => $"{this.Title.Replace(" ", string.Empty)}";
    }
}
