using MediatR;

namespace stc.iam.Api.Application.Commands;

public class GrantAccessRequest : IRequest
{
    public string ProjectId { get; set; }
    public string PrincipalId { get; set; }
}