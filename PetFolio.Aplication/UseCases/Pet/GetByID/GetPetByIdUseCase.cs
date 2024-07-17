using PetFolio.Comunication.Responses;

namespace PetFolio.Aplication.UseCases.Pet.GetByID
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "teste",
                Type = Comunication.Enums.PetType.Cat,

                Birtday = new DateTime(year: 2023, month: 01, day: 01)
            };
        }
    }
}
