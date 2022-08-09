using MSA_Phase2_Backend.Controllers;
using MSA_Phase2_Backend.Models;
using MSA_Phase2_Backend.Services;
using NSubstitute;
namespace MSA_Phase2_Backend.UnitTesting
{
    public class AnimeControllerTests_3
    {
        AnimeController AM;
        [SetUp]
        public void Setup()
        {
            AM = new AnimeController();
        }
        

        [Test]
        public void Delete_GetCorrectSize_Test()
        {

            var id = 3;

            AM.Delete(id);

            int lg = AnimeService.GetLength();

            Assert.That(lg, Is.EqualTo(3));
        }

    }
}