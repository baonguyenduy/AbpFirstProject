using System;
using System.ComponentModel.DataAnnotations;

namespace AbpFirstProject.Models.Test
{
    public class TestModel
    {
        [Required]
        public string Name { get; set; }

        //public DateTime BirthDate { get; set; }
    }
}