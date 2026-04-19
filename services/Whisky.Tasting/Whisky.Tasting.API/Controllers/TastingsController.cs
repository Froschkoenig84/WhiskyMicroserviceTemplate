namespace Whisky.Tasting.API.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TastingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] { "Ardbeg", "Laphroaig", "Lagavulin" });
    }

    [HttpPost]
    public IActionResult Create([FromBody] TastingRequest request)
    {
        // Hier landet dein JSON-Sample aus der .http Datei!
        return Ok(new { 
            message = $"Whisky {request.WhiskyName} wurde erfolgreich empfangen!",
            score = request.Score 
        });
    }
}

// Nur ein temporärer Record für den Test
public record TastingRequest(string WhiskyName, string Notes, int Score);