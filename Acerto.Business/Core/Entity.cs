using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto.Business.Core
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt    { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public virtual ValidationResult Validate()
        {
            throw new NotImplementedException("Override the validate method with valid conditions.");
        }
    }
}
