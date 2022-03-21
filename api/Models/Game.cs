namespace RPSheets.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;

        public User Gamemaster { get; set; } = default!;
        public List<User> Players { get; set; } = default!;
        public List<CharacterSheet> CharacterSheets { get; set; } = default!;

    }
}
