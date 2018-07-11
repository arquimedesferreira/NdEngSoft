using Agenda.Domain.ValueObject;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Agenda.Domain.Entity
{
    public class Person
    {
        public Person(Name name)
        {
            this.Name = name;

            this.Adresses = new List<Address>();
            this.Contacts = new List<Contact>();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public Name Name { get; private set; }
        public ICollection<Address> Adresses { get; private set; }
        public ICollection<Contact> Contacts { get; private set; }

        public void AlterName(Name name)
        {
            if (name != null)
                this.Name = name;
        }

        public void Add(Address addres)
        {
            if (addres != null)
                Adresses.Add(addres);
        }

        public void Add(Contact contact)
        {
            if (contact != null)
                Contacts.Add(contact);
        }
    }
}
