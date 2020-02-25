using System.ComponentModel.DataAnnotations;
using System;
namespace WebPerson.Models
{
    public class Person
    {
        [Key]

        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public string NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public DateTime ModifielDate { get; set; }

    }
}
