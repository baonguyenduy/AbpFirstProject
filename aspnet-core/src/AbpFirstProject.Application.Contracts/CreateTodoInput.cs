using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpFirstProject
{
    public class CreateTodoInput
    {
        [Required]
        public string Note { get; set; }
    }
}
