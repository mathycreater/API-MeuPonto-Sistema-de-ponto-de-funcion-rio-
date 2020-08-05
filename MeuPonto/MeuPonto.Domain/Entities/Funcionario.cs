using MeuPonto.Domain.Entities._base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPonto.Domain.Entities
{
    public class Funcionario : EntityBase
    {
        public Funcionario(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
