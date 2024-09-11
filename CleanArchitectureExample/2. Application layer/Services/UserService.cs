using CleanArchitectureExample.Core.Entities;
using CleanArchitectureExample.Core.UseCases;
using CleanArchitectureExample.Infrastructure;

namespace CleanArchitectureExample.Application.Services;

public class UserService : IUserRegistrationUseCase
{
  private readonly IUserRepository _userRepository;

  public UserService(IUserRepository userRepository)
  {
    _userRepository = userRepository;
  }

  public IUserRepository GetUserRepository()
  {
    return _userRepository;
  }

  public void RegisterUser(string username, string email)
  {
    // The user registration logic is implemented here
    var newUser = new User { Username = username, Email = email };

    _userRepository.AddUser(newUser);
    Console.WriteLine($"User {username} with the email {email} was successfully registered.");
  }
}