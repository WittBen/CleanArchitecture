using CleanArchitectureExample.Application.Services;
using CleanArchitectureExample.Core.UseCases;
using CleanArchitectureExample.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExample;

class Program
{
  static void Main(string[] args)
  {
    // Configuration of the DI container
    var services = new ServiceCollection();
    services.AddTransient<IUserRepository, UserRepository>();
    services.AddTransient<IUserRegistrationUseCase, UserService>();

    // Create the DI container
    var serviceProvider = services.BuildServiceProvider();

    // Use the dependent components
    var userService = serviceProvider.GetService<IUserRegistrationUseCase>();
    userService.RegisterUser("Axel Folie", "axel@example.com");

    Console.ReadLine(); // Wait for user input so that the console application is not closed immediately
  }
}