
using Xunit;
using Moq;
using Fiap.Api.ReportCity.Controllers;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Api.ReportCity.Test
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly UserController _controller;

        public UserControllerTests()
        {
            _mockUserService = new Mock<IUserService>();
            _controller = new UserController(_mockUserService.Object);
        }

        [Fact]
        public void GetUsers_ReturnsOkResult_WithListOfUsers()
        {
            // Arrange
            var users = new List<User> { new User { UserId = 1, Username = "Test User" } };
            _mockUserService.Setup(service => service.GetAllUsers()).Returns(users);

            // Act
            var result = _controller.GetUsers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(users.Count, returnValue.Count);
        }

        [Fact]
        public void GetUser_ReturnsOkResult_WithUser()
        {
            // Arrange
            var user = new User { UserId = 1, Username = "Test User" };
            _mockUserService.Setup(service => service.GetUserById(1)).Returns(user);

            // Act
            var result = _controller.GetUser(1);

            // Assert
            var okResult = Assert.IsType<ActionResult<User>>(result);
            Assert.Equal(user.UserId, okResult.Value.UserId);
        }

        [Fact]
        public void GetUser_ReturnsNotFound_WhenUserDoesNotExist()
        {
            // Arrange
            _mockUserService.Setup(service => service.GetUserById(1)).Returns((User)null);

            // Act
            var result = _controller.GetUser(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void PostUser_ReturnsCreatedAtAction_WithUser()
        {
            // Arrange
            var user = new User { UserId = 1, Username = "Test User" };

            // Act
            var result = _controller.PostUser(user);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<User>(createdAtActionResult.Value);
            Assert.Equal(user.UserId, returnValue.UserId);
        }

        [Fact]
        public void PutUser_ReturnsNoContent()
        {
            // Arrange
            var user = new User { UserId = 1, Username = "Updated User" };

            // Act
            var result = _controller.PutUser(1, user);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void DeleteUser_ReturnsNoContent()
        {
            // Act
            var result = _controller.DeleteUser(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}
