namespace CleanArchitectureExample.Core.UseCases;

public interface IUserRegistrationUseCase
{
  void RegisterUser(string username, string email);
}
