using MeuPonto.Domain.Entities._base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPonto.Domain.Entities
{
    public class HorarioPonto : EntityBase
    {
        public HorarioPonto(Guid funcionarioId)
        {
            Id = Guid.NewGuid();
            //Chave estrangeira
            FuncionarioId = funcionarioId;
            BatidaPonto = DateTime.Now;
        }
        public DateTime BatidaPonto { get; private set; }
        public Guid FuncionarioId { get; private set; }

    }
}
