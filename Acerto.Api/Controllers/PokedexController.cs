using Acerto.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Acerto.Api.Controllers
{
    [Route("pokedex")]
    public class PokedexController : ControllerBase //ao criar uma controler,
                                                    //eu tenho que herdar da controler base para acessar os endpoint
    {
        private readonly IPokedexService _pokedexService;

        public PokedexController(IPokedexService pokedexService)
        {
            _pokedexService = pokedexService;
        }

        [HttpPost] //verbos http
        [SwaggerOperation("Cadastrar Pokémon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddPokemon() //todo endpoint retorna um IActionResult
        {
            return Ok(); //status code de sucesso
        }


        [HttpPut]
        [SwaggerOperation("Atualizar cadastro Pokémon")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdatePokemon()
        {
            return Ok(); //status code de sucesso
        }

        [HttpDelete]
        [SwaggerOperation("Remover Pokémon")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeletePokemon()
        {
            return Ok(); //status code de sucesso
        }
        
        [HttpGet("{pokemonId:guid}")]
        [SwaggerOperation("Obter Pokémon por ID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPokemon(Guid pokemonId)
        {
            return Ok(); //status code de sucesso
        }

        [HttpGet("find")]
        [SwaggerOperation("Listar Pokémon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> FindPokemon() //conceito de find em rest é encontrar uma informacao por meio de filtros
        {
            return Ok(); //status code de sucesso
        }
    }
}
