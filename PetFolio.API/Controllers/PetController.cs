using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Aplication.UseCases.Pet.Registrar;
using Petfolio.Aplication.UseCases.Pet.update;
using Petfolio.comunication.Requests;
using Petfolio.comunication.Responses;
using PetFolio.Aplication.UseCases.Pet.GetAll;
using PetFolio.Aplication.UseCases.Pet.GetByID;
using PetFolio.Comunication.Responses;

namespace PetFolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPet), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJson request)


        {

            //regra de  negocio
            var response = new RegisterPetUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            var useCase = new UpdatePetUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()        {

            var useCase = new GetAllPetsUseCase();

            var response = useCase.Execute();

            if (response.Pets.Any()) { 
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get([FromRoute] int id)
        {

            var useCase = new GetPetByIdUseCase();

            var response = useCase.Execute(id);

          
            return Ok(response);
        
        }

    }
}
