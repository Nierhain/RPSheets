namespace RPSheets.Models.Responses
{
    public class SheetResponse : ResponseBase
    {
        public CharacterSheet Sheet { get; set; } = default!;
    }
}
