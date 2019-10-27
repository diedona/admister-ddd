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

        public Pedido(string observacoes)
        {
            Observacoes = observacoes;
            _acaiPessoas = new List<AcaiPessoa>();
        }

        public string Observacoes { get; set; }
        public IReadOnlyCollection<AcaiPessoa> AcaiPessoas { get { return _acaiPessoas.ToArray(); } }

        public void AdicionarItem(AcaiPessoa acaiPessoa)
        {
            // SE A PESSOA JÁ FOI ADICIONADA
            if(_acaiPessoas.Any(x => x.Pessoa.Id.Equals(acaiPessoa.Pessoa.Id)))
            {
                AdicionarErroValidacao("AcaiPessoa.Pessoa.Id", "Esta pessoa já está no pedido");
            }

            // SE O ACAI JÁ FOI ADICIONADO
            if (_acaiPessoas.Any(x => x.Acai.Id.Equals(acaiPessoa.Acai.Id)))
            {
                AdicionarErroValidacao("AcaiPessoa.Acai.Id", "Este açaí já está no pedido");
            }

            _acaiPessoas.Add(acaiPessoa);
        }

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
