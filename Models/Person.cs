using System;
using System.ComponentModel.DataAnnotations;

namespace demowebapp.Models
{
    public class Person
    {
        public int ID { get; set; }
        public String Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}