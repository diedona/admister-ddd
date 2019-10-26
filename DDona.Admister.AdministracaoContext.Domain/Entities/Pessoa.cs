using DDona.Admister.SharedKernel.Core.Entities;
using DDona.Admister.SharedKernel.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.AdministracaoContext.Domain.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(Nome nome, DataNascimento dataNascimento) : base()
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public Nome Nome { get; private set; }
        public DataNascimento DataNascimento { get; private set; }
        public bool Status { get; private set; }
    }
}
