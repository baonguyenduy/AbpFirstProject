using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Validation;

namespace AbpFirstProject
{
    public class TodoAppService : ApplicationService, ITodoAppService
    {
        private readonly IRepository<Todo> repository;
        private readonly ITodoDomainService todoDomainService;

        public TodoAppService(IRepository<Todo> repository, ITodoDomainService todoDomainService)
        {
            this.repository = repository;
            this.todoDomainService = todoDomainService;
        }

        public async Task<List<TodoDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<Todo>, List<TodoDto>>(await repository.GetListAsync());
        }

        public async Task<TodoDto> GetAsync(Guid id)
        {
            var todo = repository.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                throw new EntityNotFoundException("The todo is not found");
            }
            return ObjectMapper.Map<Todo, TodoDto>(todo);
        }

        public async Task<Guid> CreateAsync(CreateTodoInput input)
        {
            var newTodo = new Todo(GuidGenerator.Create()) { Note = input.Note };
            await todoDomainService.CreateAsync(newTodo);
            return newTodo.Id;
        }

        public async Task UpdateAsync(Guid id, UpdateTodoInput input)
        {
            var todo = repository.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                throw new EntityNotFoundException("The todo is not found");
            }
            todo.Note = input.Note;
        }

        public async Task DeleteAsync(Guid id)
        {
            await repository.DeleteAsync(t => t.Id == id);
        }
    }
}
