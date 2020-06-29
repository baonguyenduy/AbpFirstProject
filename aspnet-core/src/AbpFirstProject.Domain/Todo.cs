using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace AbpFirstProject
{
    public class Todo : Entity<Guid>
    {
        public string Note { get; set; }

        public Todo(Guid id) : base(id)
        {

        }
    }
}
