using Acerto.Business.Entities;
using FluentValidation;

namespace Acerto.Api.Validations
{
    public class PokemonValidation : AbstractValidator<Pokemon>
    {
        public PokemonValidation()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .Length(3, 50)
                .WithMessage("O nome do pokémon deve ter entre 3 e 50 caracteres.");

            RuleFor(p => p.CategoryId)
                .NotEmpty()
                .WithMessage("É necessário informar uma categoria válida.");
        }
        
    }
}
