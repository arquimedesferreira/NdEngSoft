using Agenda.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Interface.Repository
{
    public interface IRepositoryPerson
    {
        void Update(Person pessoa);
        Task<Person> SearchForName(string primerName);
        Task<Person> SearchForId(string id);
        Task<IList<Person>> SearchAll();
        Task Remove(Person person);
        Task Add(Person person);
    }
}
