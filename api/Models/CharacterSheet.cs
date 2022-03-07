namespace RPSheets.Models
{
    public record CharacterSheet
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string AvatarUrl { get; set; } = default!;
        public Game Game { get; set; } = default!;
        public User Owner { get; set; } = default!;
        public User GameMaster { get; set; } = default!;
        public IEnumerable<Statistics> Statistics { get; set; } = default!;

    }

    public record Statistics
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public int Amount { get; set; }
    }
}
