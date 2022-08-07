using MSA_Phase2_Backend.Models;
using MSA_Phase2_Backend.Services;
using Microsoft.AspNetCore.Mvc;
namespace MSA_Phase2_Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimeController : ControllerBase
{
    public AnimeController()
    {
    }

    [HttpGet]
    public ActionResult<List<Anime>> GetAll() =>
        AnimeService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Anime> Get(int id)
    {
        var anime = AnimeService.Get(id);

        if (anime == null)
            return NotFound();

        return anime;
    }

    [HttpPost]
    public IActionResult Create(Anime anime)
    {
        AnimeService.Add(anime);
        return CreatedAtAction(nameof(Create), new { id = anime.Id }, anime);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Anime anime)
    {
        if (id != anime.Id)
            return BadRequest();

        var existingAnime = AnimeService.Get(id);
        if (existingAnime is null)
            return NotFound();

        AnimeService.Update(anime);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var anime = AnimeService.Get(id);

        if (anime is null)
            return NotFound();

        AnimeService.Delete(id);

        return NoContent();
    }
}

