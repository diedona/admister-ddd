using DDona.Admister.SharedKernel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.PedidosContext.Domain.Entities
{
    public class AcaiPessoa : Entity
    {
        public AcaiPessoa(Pessoa pessoa, Acai acai)
        {
            Pessoa = pessoa;
            Acai = acai;
        }

        public Pessoa Pessoa { get; private set; }
        public Acai Acai { get; private set; }
    }
}
