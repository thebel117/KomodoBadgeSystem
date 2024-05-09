using System; 
using System.Linq; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoBadgeData;

namespace UnitTesting
{
    [TestClass]     //Need these to mark the subsequent class as a test class, bc they're special
    public class UnitTest1
    {
        [TestMethod]        //same as classes, gotta mark these methods as special
        public void TestBadgeRepositoryInstantiation()
        {
            // Arrange (set up var and objs needed)
            BadgeRepository repository;  //variable named repository of type BadgeRepository

            // Act (perform action/call method being tested)
            repository = new BadgeRepository();     //makes a new instance of BadgeRepository and assigning it to the repository variable

            // Assert (verify action in 'act' actually works and by what criteria it "works")
            Assert.IsNotNull(repository); // chekcing if the repository obj is not null after instantiation
        }
    }
};
//If all three things work, the test succeeds in the test panel/terminal