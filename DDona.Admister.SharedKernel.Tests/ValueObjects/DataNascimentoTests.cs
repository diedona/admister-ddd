using DDona.Admister.SharedKernel.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DDona.Admister.SharedKernel.Tests.ValueObjects
{
    public class DataNascimentoTests
    {
        [Fact]
        public void Calcular_Idade_Correta_Ainda_Nao_Fez_Aniversario()
        {
            DateTime dtNascimento = new DateTime(2000, 6, 20);
            DateTime dtAtual = new DateTime(2018, 1, 7);
            int idadeCorreta = 17;

            DataNascimento dtNascimentoVO = new DataNascimento(dtNascimento, dtAtual);
            Assert.Equal(idadeCorreta, dtNascimentoVO.Idade);
        }

        [Fact]
        public void Calcular_Idade_Correta_Fez_Aniversario()
        {
            DateTime dtNascimento = new DateTime(1995, 4, 18);
            DateTime dtAtual = new DateTime(2017, 6, 2);
            int idadeCorreta = 22;

            DataNascimento dtNascimentoVO = new DataNascimento(dtNascimento, dtAtual);
            Assert.Equal(idadeCorreta, dtNascimentoVO.Idade);
        }
    }
}
