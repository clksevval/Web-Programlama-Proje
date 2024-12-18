using Microsoft.AspNetCore.Mvc;
using web_proje.Data;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly VeritabaniContext _context;

    public EventsController(VeritabaniContext context)
    {
        _context = context;
    }

    // Etkinlikleri JSON olarak döndürür
    [HttpGet]
    public IActionResult GetEvents()
    {
        var events = _context.Nobetler.Select(e => new
        {
            id = e.NobetId,
			title = $"Bölüm:{e.BolumId}, Asistan:{e.AsistanId} ",
			start = e.Nobet_Tarihi.ToString("s"),
            end = e.Nobet_Tarihi_Bitis.ToString("s")

        }).ToList();

        return Ok(events);
    }
}

