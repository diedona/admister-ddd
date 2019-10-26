using DDona.Admister.PedidosContext.Domain.Entities;
using DDona.Admister.PedidosContext.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.Admister.PedidosContext.Tests.Entities
{
    public class AcaiTests
    {
        [Fact]
        public void Invalido_Complemento_Repetido()
        {
            var acai = new Acai(ETamanhoAcai.Pequeno);
            var complemento = new Complemento("Banana", 2.5m);

            acai.AddComplemento(complemento);
            acai.AddComplemento(complemento);

            Assert.False(acai.IsValid());
        }
    }
}
