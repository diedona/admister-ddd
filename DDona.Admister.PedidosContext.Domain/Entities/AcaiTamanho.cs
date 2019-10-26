using DDona.Admister.PedidosContext.Domain.Enums;
using DDona.Admister.SharedKernel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.PedidosContext.Domain.Entities
{
    public class AcaiTamanho : Entity
    {
        public AcaiTamanho(ETamanhoAcai tamanho, decimal valor)
        {
            Tamanho = tamanho;
            Valor = valor;
        }

        public ETamanhoAcai Tamanho { get; private set; }
        public decimal Valor { get; private set; }
    }
}
