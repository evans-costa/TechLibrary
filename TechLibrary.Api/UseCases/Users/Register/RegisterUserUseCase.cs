using TechLibrary.Communication.Requests;
using TechLibrary.Communication.Response;

namespace TechLibrary.Api.UseCases.Users.Register;

public class RegisterUserUseCase
{
    public ResponseRegisteredUserJson Execute(RequestUserJson request)
    {
        Validate(request);
        
        return new ResponseRegisteredUserJson
        {
            
        };
    }

    private void Validate(RequestUserJson request)
    {
        var validator = new RegisterUserValidator();
        
        var result = validator.Validate(request);

        if (result.IsValid is false)
        {
            var errorMessages = result.Errors.Select(error => error.ErrorMessage).ToList();
        }
    }
}
