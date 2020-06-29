using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpFirstProject
{
    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoDto>> GetAllAsync();
        Task<TodoDto> GetAsync(Guid id);
        Task<Guid> CreateAsync(CreateTodoInput input);
        Task UpdateAsync(Guid id, UpdateTodoInput input);
        Task DeleteAsync(Guid id);
    }
}
