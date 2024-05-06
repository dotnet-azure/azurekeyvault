using Microsoft.AspNetCore.Mvc;

namespace AzureKeyVault.Controllers;

[ApiController]
[Route("[controller]")]
public class VaultController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public VaultController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    [Route("secret")]
    public string? GetSecret(string secretName)
    {
        return _configuration[secretName];
    }
}
