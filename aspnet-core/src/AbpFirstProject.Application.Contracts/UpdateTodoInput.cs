using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpFirstProject
{
    public class UpdateTodoInput
    {
        [Required]
        public string Note { get; set; }
    }
}
