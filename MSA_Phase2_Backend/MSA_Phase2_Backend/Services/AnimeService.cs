using MSA_Phase2_Backend.Models;
namespace MSA_Phase2_Backend.Services;

public static class AnimeService
{
    static List<Anime> Animes { get; }
    static int nextId = 2;
    static AnimeService()
    {
        Animes = new List<Anime>
    {
        new Anime { Id = 1, Name = "Demon Slayer", FamousCharacter = "Zenitsu Agatsuma" },
        new Anime { Id = 2, Name = "Spy x Family", FamousCharacter = "Yor Forger" }
    };
    }

    public static List<Anime> GetAll() => Animes;

    public static Anime? Get(int id) => Animes.FirstOrDefault(p => p.Id == id);

    public static int GetLength(){
        return nextId;
    }
    public static void Add(Anime anime)
    {
        anime.Id = nextId++;
        nextId++;
        Animes.Add(anime);
    }

    public static void Delete(int id)
    {
        var anime = Get(id);
        if (anime is null)
            return;

        Animes.Remove(anime);
    }

    public static void Update(Anime anime)
    {
        var index = Animes.FindIndex(p => p.Id == anime.Id);
        if (index == -1)
            return;

        Animes[index] = anime;
    }
}

