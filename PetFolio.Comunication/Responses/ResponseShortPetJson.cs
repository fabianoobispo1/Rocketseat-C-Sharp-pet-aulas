using PetFolio.Comunication.Enums;

namespace PetFolio.Comunication.Responses
{
    public class ResponseShortPetJson
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public PetType type { get; set; }
    }
}
