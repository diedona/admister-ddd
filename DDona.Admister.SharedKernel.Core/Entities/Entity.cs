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
        }

        public Guid Id { get; protected set; }
    }
}
