using Agenda.Domain.ValueObject;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Api.Models.Person
{
    public class PersonModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public Name Name { get; set; }

        public ICollection<Address> Adresses { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}