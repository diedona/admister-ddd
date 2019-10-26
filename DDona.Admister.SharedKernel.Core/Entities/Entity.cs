using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.SharedKernel.Core.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }

        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }

        public virtual bool IsValid()
        {
            return this.ValidationResult.IsValid;
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }

        protected void AdicionarErroValidacao(string propertyName, string errorMessage)
        {
            this.ValidationResult.Errors.Add(new ValidationFailure(propertyName, errorMessage));
        }
    }
}
