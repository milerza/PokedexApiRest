using Acerto.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto.Business.Services
{
    public class PokedexService : IPokedexService
    {
        public Task<Guid?> AddPokemonAsync(Pokemon pokemon)
        {
            var validation = pokemon.Validate();

            if (!validation.IsValid)
            {
                // notificar erro pro usuario
                return null;
            }

            throw new NotImplementedException();
        }

        public Task DeletePokemonAsync(Guid pokemonId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePokemonAsync(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
