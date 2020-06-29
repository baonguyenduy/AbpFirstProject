using AbpFirstProject.Models.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpFirstProject.Controllers
{
    [Route("api/tests")]
    public class TestController : AbpFirstProjectController
    {
        private List<TestModel> tests;

        public TestController()
        {
            tests = new List<TestModel>()
            {
                new TestModel() { Name = "John" },
                new TestModel() { Name = "Max" }
            };
        }

        [HttpGet]
        public List<TestModel> GetAll()
        {
            return tests;
        }

        [HttpPost]
        public IActionResult Create([FromBody] TestModel test)
        {
            tests.Add(test);
            return Ok();
        }
    }
}
