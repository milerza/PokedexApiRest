

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

        public override ValidationResult Validate()
        {
            return base.Validate();
        }
    }
}
