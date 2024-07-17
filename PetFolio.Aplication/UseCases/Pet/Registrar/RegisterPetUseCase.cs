using Petfolio.comunication.Requests;
using Petfolio.comunication.Responses;

namespace Petfolio.Aplication.UseCases.Pet.Registrar
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPet Execute(RequestPetJson request)
        {
            return new ResponseRegisterPet
            {
                id = 1,
                name = request.Name

            };

        }
    }
}
