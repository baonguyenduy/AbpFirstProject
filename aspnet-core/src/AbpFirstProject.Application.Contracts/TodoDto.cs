using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace AbpFirstProject
{
    public class TodoDto : EntityDto<Guid>
    {
        public string Note { get; set; }
    }
}
