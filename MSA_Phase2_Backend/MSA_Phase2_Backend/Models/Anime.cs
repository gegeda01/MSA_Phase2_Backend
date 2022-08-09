namespace MSA_Phase2_Backend.Models;

public class Anime
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? FamousCharacter { get; set; }
}

public interface IAnime
{
    int Id { get; set; }
    string? Name { get; set; }
    string? FamousCharacter { get; set; }

    Anime AddAnime { get; set; }


}