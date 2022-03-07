namespace RPSheets.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;

        public User Gamemaster { get; set; } = default!;
        public IEnumerable<User> Players { get; set; } = default!;
        public IEnumerable<CharacterSheet> CharacterSheets { get; set; } = default!;

    }
}
