namespace CleaningWeb.Data.Models
{
    using System;

    public class Vacation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
