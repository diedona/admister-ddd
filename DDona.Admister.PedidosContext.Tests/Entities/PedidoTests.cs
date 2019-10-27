using DDona.Admister.PedidosContext.Domain.Entities;
using DDona.Admister.PedidosContext.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.Admister.PedidosContext.Tests.Entities
{
    public class PedidoTests
    {
        [Fact]
        public void Calcular_ValorTotal_Correto()
        {
            Pessoa pessoa1 = new Pessoa(Guid.NewGuid());
            Pessoa pessoa2 = new Pessoa(Guid.NewGuid());

            AcaiTamanho tamanho = new AcaiTamanho(ETamanhoAcai.Grande, 10m);
            Acai acai1 = new Acai(tamanho);
            Acai acai2 = new Acai(tamanho);

            AcaiPessoa ap1 = new AcaiPessoa(pessoa1, acai1);
            AcaiPessoa ap2 = new AcaiPessoa(pessoa2, acai2);

            Pedido pedido = new Pedido("Trás rápido", new AcaiPessoa[] { ap1, ap2 });

            //

            decimal precoCerto = 20;

            //

            Assert.Equal(precoCerto, pedido.CalcularValorTotal());
        }
    }
}
