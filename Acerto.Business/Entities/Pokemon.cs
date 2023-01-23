

using Acerto.Business.Core;
using Acerto.Business.Enums;
using FluentValidation.Results;

namespace Acerto.Business.Entities
{
    public class Pokemon : Entity
    {
        public string Name { get; private set; }
        public Guid CategoryId { get; private set; } //guid é bom pra gerar
                                             //guid numero hexadecimal gerado de forma aleatoria (diminui o num de req no banco)
        public Gender Gender { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Speed { get; private set; }

        public Pokemon(string name, Guid categoryId, Gender gender, int hp, int attack, int defense, int speed)
        {
            Name = name;
            CategoryId = categoryId;
            Gender = gender;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        public override ValidationResult Validate() //  o que é válido em um pokemon
        {
            var result = new ValidationResult();
            if(Name.Length < 3 || Name.Length > 50)
            {
                result.Errors.Add(new ValidationFailure(nameof(Name), "O nome do pokémon deve ter entre 3 e 50 caracteres."));
            }

            return result;
        }
    }
}
