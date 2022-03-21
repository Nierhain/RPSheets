using RPSheets.Enums;

namespace RPSheets.Models
{
    public record Statistics
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int Amount { get; set; }
        public StatisticsType Type { get; set; }
        public StatisticsGroup Group { get; set; } = default!;
    }
}
