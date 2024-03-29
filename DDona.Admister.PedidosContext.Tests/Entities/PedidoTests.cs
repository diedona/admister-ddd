﻿using DDona.Admister.PedidosContext.Domain.Entities;
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

            Acai acai1 = Acai.AcaiFactory.CriarAcai(ETamanhoAcai.Grande, 10m);
            Acai acai2 = Acai.AcaiFactory.CriarAcai(ETamanhoAcai.Grande, 15m);

            AcaiPessoa ap1 = new AcaiPessoa(pessoa1, acai1);
            AcaiPessoa ap2 = new AcaiPessoa(pessoa2, acai2);

            Pedido pedido = new Pedido("Trás rápido");
            pedido.AdicionarItem(ap1);
            pedido.AdicionarItem(ap2);

            //

            decimal precoCerto = 25;

            //

            Assert.Equal(precoCerto, pedido.CalcularValorTotal());
        }
    }
}
