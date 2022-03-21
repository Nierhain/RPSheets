namespace RPSheets.Models
{
    public record StatisticsGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
