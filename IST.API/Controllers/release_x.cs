using System.Security.Cryptography;
using System.Text;
using IST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IST.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ReleaseX : ControllerBase
{
    // ReSharper disable once InconsistentNaming
    private readonly IConfiguration _AppSettings;

    public ReleaseX(IConfiguration appSettings)
    {
        _AppSettings = appSettings;
    }

    [HttpPost("/fag")]
    public async Task<IActionResult> GetFagFromSchool([FromServices] IFagService service, int limit, int offset,
        int instnr, string apiKey)
    {
        var hexString = "";
        await Task.Run(() =>
        {
            var byteArray = SHA1.HashData(Encoding.UTF8.GetBytes(apiKey));
            hexString = Convert.ToHexString(byteArray);
        });

        if (hexString != _AppSettings["apiKey"])
            return Unauthorized("Wrong API key");
        if (hexString == _AppSettings["apiKey"])
        {
            if (!service.CheckInstitutionID(instnr))
                return NotFound("Institution ID not found");

            var result = service.GetFagFromSchool(limit, offset, instnr);
            return Ok(result.ToArray());
        }

        return BadRequest();
    }
}