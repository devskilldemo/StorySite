using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SotreSite.Models;
using StorySite.Data;
using Ninject;
using Ninject.MockingKernel.Moq;
using Moq;
using Ninject.MockingKernel;

namespace SotreSite.Tests.Models
{
    [TestClass]
    public class StoryModelTests
    {
        MoqMockingKernel kernel;

        [TestInitialize]
        public void Init()
        {
            kernel = new MoqMockingKernel();
        }

        [TestMethod]
        public void CreateStory_NoUpOrDownVote_RatingZeros()
        {
            // Arrange
            var unitOfWork = kernel.GetMock<IStorySiteUnitOfWork>();
            var storyRepo = kernel.GetMock<IStoryRepository>();
            unitOfWork.SetupGet(x => x.StoryRepository).Returns(storyRepo.Object);
            unitOfWork.Setup(x => x.Save());

            StoryModel model = new StoryModel(unitOfWork.Object);

            // Act
            var story = model.CreateStory("hello", "test");

            // Assert
            Assert.AreEqual(0, story.Rating.CurrentRating);
        }
    }
}
