using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Validation;

namespace AbpFirstProject.Controllers
{
    [Route("api/todos")]
    public class TodosController : AbpFirstProjectController
    {
        private readonly ITodoAppService todoAppService;

        public TodosController(ITodoAppService todoAppService)
        {
            this.todoAppService = todoAppService;
        }

        [HttpGet]
        public async Task<List<TodoDto>> GetAllTodos()
        {
            return await todoAppService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<TodoDto> GetTodo(Guid id)
        {
            var todo = await todoAppService.GetAsync(id);
            return todo;
        }

        [HttpPost]
        public async Task<JsonResult> CreateTodo([FromBody] CreateTodoInput input)
        {
            var id = await todoAppService.CreateAsync(input);
            return Json(new { Id = id });
        }

        [HttpPut("{id}")]
        public async Task UpdateTodo(Guid id, [FromBody] UpdateTodoInput input)
        {
            await todoAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTodo(Guid id)
        {
            await todoAppService.DeleteAsync(id);
        }
    }
}
