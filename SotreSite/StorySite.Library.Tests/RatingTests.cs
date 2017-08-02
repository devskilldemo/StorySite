using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StorySite.Library.Tests
{
    [TestClass]
    public class RatingTests
    {
        Rating rating = new Rating();

        [TestInitialize]
        public void Init()
        {
            rating = new Rating();
        }

        [TestCleanup]
        public void Clean()
        {
            rating = null;
        }

        [TestMethod]
        public void UpVote_NoDownVote_ReturnsInfinity()
        {
            // Arrange
            

            // Act
            rating.UpVote();

            // Assert
            Assert.IsTrue(Double.IsInfinity(rating.CurrentRating));
        }

        [TestMethod, TestCategory("Combo")]
        public void UpVoteDownVote_PositiveUpAndDownVote_ReturnsCorrectRating()
        {
            // Arrange
            double expectedResult = 0.6;

            // Act
            rating.UpVote();
            rating.UpVote();
            rating.UpVote();

            rating.DownVote();
            rating.DownVote();
            rating.DownVote();
            rating.DownVote();
            rating.DownVote();

            // Assert
            Assert.AreEqual(expectedResult, rating.CurrentRating);
        }

        [TestMethod]
        public void DownVote_NoUpVote_ReturnsZero()
        {
            // Arrange

            // Act
            rating.DownVote();

            // Assert
            Assert.AreEqual(0, rating.CurrentRating);
        }
    }
}
