using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace AbpFirstProject
{
    public class TodoDomainService : DomainService, ITodoDomainService
    {
        private readonly IRepository<Todo> repository;

        public TodoDomainService(IRepository<Todo> repository)
        {
            this.repository = repository;
        }

        public async Task<Todo> CreateAsync(Todo todo)
        {
            return await this.repository.InsertAsync(todo);
        }
    }
}
