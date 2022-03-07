namespace RPSheets.Models
{
    public record User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public IEnumerable<CharacterSheet> CharacterSheets { get; set; } = default!;
        public IEnumerable<Game> Games { get; set; } = default!;

    }
}
