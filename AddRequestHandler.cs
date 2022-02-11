using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MediatoR.Models;

public class AddRequestHandler : IRequestHandler<AddRequest, AddResponse>
{
    public Task<AddResponse> Handle(AddRequest request, CancellationToken token)
    {
        var additionResult = request.NumberOne + request.NumberTwo;
        var response = new AddResponse(additionResult);

        return Task.FromResult(response);
    }
}