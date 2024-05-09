using System; 
using System.Linq; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoBadgeData;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBadgeRepositoryInstantiation()
        {
            // Arrange
            BadgeRepository repository;

            // Act
            repository = new BadgeRepository();

            // Assert
            Assert.IsNotNull(repository); // Check if the repository is not null after instantiation
        }
    }
};