using Microsoft.AspNetCore.Mvc;

namespace stc.iam.Api.Controllers;

public class ProjectController : BaseController
{
    [Route("[action]")]
    public async Task<IActionResult> GrantAccess()
    {
        throw new NotImplementedException();
    }
    
    [Route("[action]")]
    public async Task<IActionResult> CreateApiKey()
    {
        throw new NotImplementedException();
    }
}