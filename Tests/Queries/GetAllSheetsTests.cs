using AutoBogus;
using RPSheets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Queries
{
    public class GetAllSheetsTests
    {
        private const int _sheetAmount = 10;

        public async Task ShouldReturnAllSheets()
        {
            var charSheets = AutoFaker.Generate<CharacterSheet>(_sheetAmount);


        }
    }
}
