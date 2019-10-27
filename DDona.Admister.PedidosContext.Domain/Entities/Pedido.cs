using DDona.Admister.SharedKernel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.Admister.PedidosContext.Domain.Entities
{
    public class Pedido : Entity
    {
        private readonly IList<AcaiPessoa> _acaiPessoas;

        public Pedido(string observacoes, IList<AcaiPessoa> acaiPessoas)
        {
            Observacoes = observacoes;
            _acaiPessoas = acaiPessoas;
        }

        public string Observacoes { get; set; }
        public IReadOnlyCollection<AcaiPessoa> AcaiPessoas { get { return _acaiPessoas.ToArray(); } }

        public decimal CalcularValorTotal()
        {
            decimal valor = 0;

            foreach (var acaiPessoa in _acaiPessoas)
            {
                valor += acaiPessoa.Acai.CalcularValor();
            }

            return valor;
        }
    }
}
