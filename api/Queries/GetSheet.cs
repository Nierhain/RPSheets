using MediatR;
using RPSheets.Models.Responses;

namespace RPSheets.Queries
{
    public class GetSheetQuery : IRequest<SheetResponse>
    {
    }
}
