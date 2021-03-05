using DataClass;
using NUnit.Framework;

namespace AppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateUser()
        {
            User_Data user_Data = new User_Data();

            var res = user_Data.CreateUser(new ModelsClass.MethodParameters.CreateUser()
            {
                Email = "alej@live.de",
                IdNumber = 1321654,
                IdType = 2,
                Name = "Prueba_1",
                PassWord = "ajshdkja",
                Surname = "Apellido1"
            });
            Assert.Pass();
        }
    }
}