using MSA_Phase2_Backend.Controllers;
using MSA_Phase2_Backend.Models;
using MSA_Phase2_Backend.Services;
using NSubstitute;
namespace MSA_Phase2_Backend.UnitTesting
{
    public class AnimeControllerTests_1
    {
        AnimeController AN;
        [SetUp]
        public void Setup()
        {
            AN = new AnimeController();
        }
        

        [Test]
        public void Add_GetCorrectSize_Test()
        {

            var id = 3;
            var name = "One Piece";
            var character = "Nico Robin";

            var am = new Anime() { Id=id,Name=name,FamousCharacter=character};

            var ai = new Anime() { Id = 5, Name = name, FamousCharacter = "Nami"};

            AN.Create(am);
            AN.Create(ai);

            int lg = AnimeService.GetLength();

            Assert.That(lg, Is.EqualTo(id+1));
        }

    }
}