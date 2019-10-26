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

        public Acai(ETamanhoAcai tamanho)
        {
            Tamanho = tamanho;
            _complementos = new List<Complemento>();
        }

        public ETamanhoAcai Tamanho { get; private set; }
        public IReadOnlyCollection<Complemento> Complementos { get { return _complementos.ToArray(); } }

        public void AddComplemento(Complemento complemento)
        {
            // não pode adicionar 2x o mesmo complemento
            if(_complementos.Any(x => x.Id.Equals(complemento.Id)))
            {
                // notify
            }

            // não pode ter mais que 5 complementos
            if(_complementos.Count >= 5)
            {
                // notify
            }

            _complementos.Add(complemento);
        }
    }
}
