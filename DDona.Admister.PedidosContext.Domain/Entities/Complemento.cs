using DDona.Admister.SharedKernel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.PedidosContext.Domain.Entities
{
    public class Complemento : Entity
    {
        public Complemento(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; private set; }
        public decimal Valor { get; set; }
    }
}
