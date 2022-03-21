namespace RPSheets.Models.Responses
{
    public class SheetsResponse : ResponseBase
    {
        public List<CharacterSheet> Sheets { get; set; } = default!;
    }
}
