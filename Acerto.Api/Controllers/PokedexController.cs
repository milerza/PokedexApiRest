using Acerto.Business.Entities;
using Acerto.Business.Services;
using Acerto.Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace Acerto.Api.Controllers
{
    [Route("pokedex")]
    public class PokedexController : ControllerBase //ao criar uma controler,
                                                    //eu tenho que herdar da controler base para acessar os endpoint
    {
        private readonly IPokedexService _pokedexService;
        private readonly IMapper _mapper;


        public PokedexController(IPokedexService pokedexService)
        {
            _pokedexService = pokedexService;
        }

        [HttpPost] /// se é Post: Insercao http:acerto/pokedex/
        [SwaggerOperation("Cadastrar Pokémon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddPokemon([FromBody]PokemonModel model) //todo endpoint retorna um IActionResult
                                                                               //[FromBody] é para pegar do corpo da requisicao. O default é da url.
        {
            var pokemon = _mapper.Map<Pokemon>(model);
            var pokemonById = await _pokedexService.AddPokemonAsync(pokemon);

            return Created($"{HttpContext.Request.Path}/{pokemonById}", null); //retorna que foi criado um pokemon pro front
        }


        [HttpPut] // se é Put: Update http:acerto/pokedex/
        [SwaggerOperation("Atualizar cadastro Pokémon")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdatePokemon([FromBody] PokemonModel model)
        {
            var pokemon = _mapper.Map<Pokemon>(model);
            await _pokedexService.UpdatePokemonAsync(pokemon);

            return NoContent(); 
        }

        [HttpDelete("{pokemonId:guid}")] //http:acerto/pokedex/ahdjsh-asdf-asdf-fsdfsd estou passando o guid na rota
        [SwaggerOperation("Remover Pokémon")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        public async Task<IActionResult> DeletePokemon(Guid pokemonId)
        {
            await _pokedexService.DeletePokemonAsync(pokemonId);
            return NoContent();
        }
        
        [HttpGet("{pokemonId:guid}")]
        [SwaggerOperation("Obter Pokémon por ID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPokemon(Guid pokemonId)
        {
            return Ok();
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
