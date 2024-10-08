using MediatR;

namespace stc.iam.Api.Application.Commands;

public class GrantAccessHandler : IRequestHandler<GrantAccessRequest>
{
    public Task Handle(GrantAccessRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}