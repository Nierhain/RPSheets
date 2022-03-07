using Microsoft.EntityFrameworkCore;
using RPSheets.Models;

namespace RPSheets.Data
{
    public class RPSheetsContext: DbContext
    {
        public DbSet<CharacterSheet> Sheets { get; set; }
    
    }
}
