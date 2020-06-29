using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace AbpFirstProject
{
    public interface ITodoDomainService : IDomainService
    {
        Task<Todo> CreateAsync(Todo todo);
    }
}
