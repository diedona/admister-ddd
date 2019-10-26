using DDona.Admister.PedidosContext.Domain.Enums;
using DDona.Admister.SharedKernel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.Admister.PedidosContext.Domain.Entities
{
    public class Acai : Entity
    {
        private readonly IList<Complemento> _complementos;

        public Acai(ETamanhoAcai tamanho, IList<Complemento> complementos)
        {
            Tamanho = tamanho;
            _complementos = complementos;
        }

        public ETamanhoAcai Tamanho { get; private set; }
        public IReadOnlyCollection<Complemento> Complementos { get { return _complementos.ToArray(); } }

    }
}
