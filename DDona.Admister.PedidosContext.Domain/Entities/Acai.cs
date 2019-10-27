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

        public Acai(AcaiTamanho tamanho)
        {
            Tamanho = tamanho;
            _complementos = new List<Complemento>();
        }

        public AcaiTamanho Tamanho { get; private set; }
        public IReadOnlyCollection<Complemento> Complementos { get { return _complementos.ToArray(); } }

        public void AddComplemento(Complemento complemento)
        {
            // não pode adicionar 2x o mesmo complemento
            if (_complementos.Any(x => x.Id.Equals(complemento.Id)))
            {
                AdicionarErroValidacao("Complemento.Id", "Complemento já adicionado");
            }

            // não pode ter mais que 5 complementos
            if (_complementos.Count >= 5)
            {
                AdicionarErroValidacao("Acai.Complementos", "Já possui 5 complementos");
            }

            _complementos.Add(complemento);
        }

        public decimal CalcularValor()
        {
            // valor base
            decimal valor = Tamanho.Valor;

            // somando os complementos
            foreach (var complemento in _complementos)
            {
                valor += complemento.Valor;
            }

            return valor;
        }

        public static class AcaiFactory
        {
            public static Acai CriarAcai(ETamanhoAcai tamanho, decimal valor)
            {
                var acai = new Acai(new AcaiTamanho(tamanho, valor));
                return acai;
            }
        }
    }
}
