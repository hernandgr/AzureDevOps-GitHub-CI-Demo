using Microsoft.AspNetCore.Mvc;
using MySimpleDemo.Web.Controllers;
using Xunit;

namespace MySimpleDemo.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}