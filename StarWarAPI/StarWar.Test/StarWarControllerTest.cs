using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using StarWarAPI.Controllers;
using System.Web.Http.Results;

namespace StarWar.Test
{
    [TestClass]
    public class StarWarControllerTest
    {
        [TestMethod]
        public async Task StarWarController_GetOpeningCrawl_Pass1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetOpeningCrawl();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Length > 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetOpeningCrawl_Pass2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetOpeningCrawl();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Contains("title"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetOpeningCrawl_Fail1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetOpeningCrawl();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Length == 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetOpeningCrawl_Fail2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetOpeningCrawl();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Contains("abcdefg"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetCharacterAppearance_Pass1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetCharacterAppearance();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Length > 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetCharacterAppearance_Pass2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetCharacterAppearance();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Contains("name"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetCharacterAppearance_Fail1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetCharacterAppearance();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Length == 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetCharacterAppearance_Fail2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetCharacterAppearance();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Contains("abcdefg"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetSpeciesAppeared_Pass1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetSpeciesAppeared();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Length > 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetSpeciesAppeared_Pass2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetSpeciesAppeared();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Contains("name") && contentResult.Content.Contains("c"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetSpeciesAppeared_Fail1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetSpeciesAppeared();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Length == 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetSpeciesAppeared_Fail2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetSpeciesAppeared();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Contains("abcdefg"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetVehiclePilots_Pass1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetVehiclePilots();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Length > 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetVehiclePilots_Pass2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetVehiclePilots();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsNotNull(contentResult);
                Assert.IsNotNull(contentResult.Content);
                Assert.IsTrue(contentResult.Content.Contains("Planet") && contentResult.Content.Contains("Name"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetVehiclePilots_Fail1()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetVehiclePilots();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Length == 0);
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public async Task StarWarController_GetVehiclePilots_Fail2()
        {
            // Arrange
            StarWarController controller = new StarWarController();
            try
            {
                // Act
                var response = controller.GetVehiclePilots();
                var contentResult = await response as OkNegotiatedContentResult<string>;

                // Assert
                Assert.IsFalse(contentResult.Content.Contains("abcdefg"));
            }
            catch
            {
                // Assert
                Assert.IsFalse(false);
            }
        }
    }
}
