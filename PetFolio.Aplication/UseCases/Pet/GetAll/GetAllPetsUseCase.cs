using PetFolio.Comunication.Responses;

namespace PetFolio.Aplication.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {

            return new ResponseAllPetJson
            {
                 Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        id = 1,
                        name = "Test",
                        type = Comunication.Enums.PetType.Dog
                    }
                }


            };


        }
    }
}
