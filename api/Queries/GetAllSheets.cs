using MediatR;
using RPSheets.Data;
using RPSheets.Models.Responses;

namespace RPSheets.Queries;

public class GetAllSheetsQuery : IRequest<SheetsResponse>
{

}

public class GetAllSheetsHandler : IRequestHandler<GetAllSheetsQuery, SheetsResponse>
{
    private readonly IDbRepository _repository;
    public Task<SheetsResponse> Handle(GetAllSheetsQuery request, CancellationToken cancellationToken)
    {
        
    }
}
