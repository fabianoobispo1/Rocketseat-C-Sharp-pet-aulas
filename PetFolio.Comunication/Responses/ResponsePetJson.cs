﻿using PetFolio.Comunication.Enums;

namespace PetFolio.Comunication.Responses
{
    public class ResponsePetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Birtday { get; set; }

        public PetType Type { get; set; }
    }
}
