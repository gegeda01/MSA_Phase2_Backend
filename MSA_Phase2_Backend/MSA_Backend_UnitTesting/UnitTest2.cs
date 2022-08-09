using MSA_Phase2_Backend.Controllers;
using MSA_Phase2_Backend.Models;
using MSA_Phase2_Backend.Services;
using NSubstitute;
namespace MSA_Phase2_Backend.UnitTesting
{
    public class AnimeControllerTests_2
    {

        [SetUp]
        public void Setup()
        {
          
        }
        

        [Test]
        public void GetCorrectSubstitute_Test()
        {
            var anime = Substitute.For<IAnime>();

            var new_anime = new Anime() { Id = 6, Name = "Naruto", FamousCharacter = "Gaara" };

            anime.AddAnime= new_anime;

            Assert.That(anime.AddAnime, Is.EqualTo(new_anime));
           
        }


    }
}