using DDona.Admister.AdministracaoContext.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Admister.AdministracaoContext.Domain.Validation
{
    public class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(x => x.Nome.PrimeiroNome)
                .NotEmpty()
                .WithMessage("Primeiro nome é obrigatório");

            RuleFor(x => x.Nome.Sobrenome)
                .NotEmpty()
                .WithMessage("Sobrenome é obrigatório");
        }
    }
}
