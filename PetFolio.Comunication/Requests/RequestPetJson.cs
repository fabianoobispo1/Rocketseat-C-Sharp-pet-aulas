using PetFolio.Comunication.Enums;

namespace Petfolio.comunication.Requests
{
    public class RequestPetJson
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Birtday { get; set; }

        public PetType Type { get; set; }
    }
}
