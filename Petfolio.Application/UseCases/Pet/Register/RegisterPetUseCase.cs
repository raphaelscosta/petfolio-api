using Petfolio.Communication.Request;
using Petfolio.Communication.Response;
using System.Security.Cryptography.X509Certificates;

namespace Petfolio.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {

        public ResponseRegisteredPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisteredPetJson
            {
                Id = 1,
                Name = request.Name
            };
        }

    }
}
