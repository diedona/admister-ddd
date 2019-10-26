using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.SharedKernel.Core.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
