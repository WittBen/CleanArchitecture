using CleanArchitectureExample.Application.Services;
using CleanArchitectureExample.Core.Entities;
using CleanArchitectureExample.Infrastructure;
using Moq;

namespace CleanArchitecture.Tests.CoreTests;

public class UseCasesTests
{
  [Fact]
  public void RegisterUser_Should_Register_User()
  {
    // Arrange
    var mockUserRepository = new Mock<IUserRepository>();
    var userService = new UserService(mockUserRepository.Object);
    var username = "Max Zuchowski";
    var email = "maxz@example.com";

    // Act
    userService.RegisterUser(username, email);

    // Assert
    mockUserRepository.Verify(repo => repo.AddUser(It.IsAny<User>()), Times.Once);
  }
}