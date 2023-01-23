using Acerto.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto.Business.Services
{
    public interface IPokedexService
    {
        Task<Guid?> AddPokemonAsync(Pokemon pokemon); //guid é um identificador glocal exclusivo

        Task UpdatePokemonAsync(Pokemon pokemon);

        Task DeletePokemonAsync(Guid pokemonId);

    }
}
