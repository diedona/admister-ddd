using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.SharedKernel.Core.ValueObjects
{
    public class DataNascimento : ValueObject
    {
        public DataNascimento(DateTime dtNascimento, DateTime? dtAtual)
        {
            DtNascimento = dtNascimento;
            DtAtual = dtAtual ?? DateTime.Now;
        }

        public DateTime DtNascimento { get; private set; }
        public DateTime DtAtual { get; private set; }

        public void SetDtAtual(DateTime now)
        {
            DtAtual = now;
        }

        public int Idade
        {
            get
            {
                int idade = DtAtual.Year - DtNascimento.Year;
                // se ainda não fez aniversário, diminui 1 ano
                if (DtAtual.Month < DtNascimento.Month || (DtAtual.Month == DtNascimento.Month && DtAtual.Day < DtNascimento.Day))
                {
                    idade--;
                }

                return idade;
            }
        }
    }
}
