using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend1.Models
{
    public class Person
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public Person()
        {
        }
    }
}
