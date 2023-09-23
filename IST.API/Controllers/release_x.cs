using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using IST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IST.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ReleaseX : ControllerBase
{
    private IConfiguration _AppSettings;

    public ReleaseX(IConfiguration appSettings)
    {
        _AppSettings = appSettings;
    }
    [HttpPost("/fag")]
    public async Task<IActionResult> GetFagFromSchool([FromServices] IFagService service, int limit, int offset, int instnr, string apiKey)
    {
        var byteArray = SHA1.HashData(Encoding.UTF8.GetBytes(apiKey));
        var hexString = Convert.ToHexString(byteArray);

        if (hexString != _AppSettings["apiKey"])
            return Unauthorized("Wrong API key");
        if (hexString == _AppSettings["apiKey"])
        {
            if (!service.CheckInstitutionID(instnr))
                return NotFound("Institution ID not found");

            var result = service.GetFagFromSchool(limit, offset, instnr);
            return Ok(result.ToArray());
        }
        else
            return BadRequest();
    }
}